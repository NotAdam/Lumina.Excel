using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lumina.Excel.Generator;

// Adapted from: https://github.com/xivdev/EXDTools/blob/main/ColDefReader.cs
public sealed class ColumnDefinitions(ImmutableSortedDictionary<string, ExcelColumnDefinition[]> dict,
    ImmutableSortedSet<string> subrows)
{
    public ImmutableSortedDictionary<string, ExcelColumnDefinition[]> Sheets { get; } = dict;
    public ImmutableSortedSet<string> SubrowSheets { get; } = subrows;

    public static ColumnDefinitions FromColumnFile(string file)
    {
        var deserializer = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();

        using var f = FileIO.TryOpenFile(file) ?? throw new FileNotFoundException($"Could not find column definitions file: {file}");
        using var reader = new StreamReader(f);
        var sheets = deserializer.Deserialize<Dictionary<string, ExcelColumnDefinition[]>>(reader);

        var subrowSheets = sheets.Where(sheet => sheet.Key.EndsWith("@Subrow"))
            .Select(sheet => sheet.Key[..^7])
            .ToImmutableSortedSet();
        foreach (var sheet in subrowSheets)
        {
            sheets[sheet] = sheets[$"{sheet}@Subrow"];
            sheets.Remove($"{sheet}@Subrow");
        }

        if (subrowSheets.Count == 0)
        {
            // If no subrow sheets are defined, use the default set
            subrowSheets = [.. DefaultSubrowSheets.Where(sheets.ContainsKey)];
        }

        return new(sheets.ToImmutableSortedDictionary(), subrowSheets);
    }

    public ExcelColumnDefinition[] this[string sheetName] => Sheets[sheetName];

    public uint GetColumnsHash(string sheetName)
    {
        var data = MemoryMarshal.Cast<ExcelColumnDefinition, ushort>(Sheets[sheetName].AsSpan());

        // Column hashes are based on the file data, so we need to ensure the endianness matches
        if (BitConverter.IsLittleEndian)
        {
            var temp = data.ToArray();
            foreach (ref var el in temp.AsSpan())
                el = BinaryPrimitives.ReverseEndianness(el);
            data = temp.AsSpan();
        }

        return Crc32.Get(MemoryMarshal.Cast<ushort, byte>(data));
    }

    public void WriteTo(TextWriter writer)
    {
        var schemaSerializer = new SerializerBuilder()
            .DisableAliases()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .WithEnumNamingConvention(LowerCaseNamingConvention.Instance)
            .WithIndentedSequences()
            .EnsureRoundtrip()
            .Build();

        schemaSerializer.Serialize(writer, Sheets.ToImmutableSortedDictionary(pair => $"{pair.Key}{(SubrowSheets.Contains(pair.Key) ? "@Subrow" : string.Empty)}", pair => pair.Value));
    }

    private static readonly ImmutableSortedSet<string> DefaultSubrowSheets =
    [
        "AkatsukiNote",
        "AnimaWeapon5SpiritTalk",
        "AnimaWeaponFUITalk",
        "AOZArrangement",
        "AOZContentBriefingObject",
        "ArchiveItem",
        "Behavior",
        "BGMSwitch",
        "ClassJobActionUI",
        "ClassJobResident",
        "CollectablesShopItem",
        "ContentDirectorBattleTalk",
        "ContentDirectorManagedSG",
        "ContentEventItem",
        "ContentRandomSelect",
        "ContentTodo",
        "ContentTourismConstruct",
        "Credit",
        "CreditBackImage",
        "CreditList",
        "CSBonusMission",
        "CustomTalkDefineClient",
        "CustomTalkNestHandlers",
        "CutSceneIncompQuest",
        "DawnContentParticipable",
        "DeepDungeonMap5X",
        "DescriptionPage",
        "DescriptionSection",
        "DisposalShopItem",
        "DynamicEventSet",
        "EmjCostume",
        "ENpcDressUpDress",
        "EurekaDungeonPortal",
        "FittingShopCategoryItem",
        "GathererReductionReward",
        "GatheringItemPoint",
        "GCScripShopItem",
        "GilShopItem",
        "GuidePage",
        "HousingEmploymentNpcList",
        "HousingMapMarkerInfo",
        "HWDDevLively",
        "HWDSharedGroup",
        "HWDSharedGroupControlParam",
        "InclusionShopSeries",
        "ItemBarterCheck",
        "LivelyActorGroup",
        "MapMarker",
        "MapReplace",
        "MassivePcContentBattleTalk",
        "MassivePcContentTodo",
        "MiniGameRANotes",
        "MiniGameTurnBreakPop",
        "MJIBuilding",
        "MJILivelyActor",
        "MJIStockyardManagementTable",
        "MJIVillageAppearanceUI",
        "MKDGrowDataSJob",
        "MobHuntOrder",
        "MultipleHelpPage",
        "PointMenuChoice",
        "PvPActionSort",
        "PvPSelectAction",
        "QuestAdditionalToolIcon",
        "QuestAroundPlayerHide",
        "QuestClassJobReward",
        "QuestClassJobSupply",
        "QuestDefineClient",
        "QuestEffectDefine",
        "QuestEventAreaEntranceInfo",
        "QuestLinkMarker",
        "QuestRedoIncompChapter",
        "QuestRedoValidCustomTalk",
        "QuestSceneAbortCondition",
        "QuestSetDefine",
        "QuestSubCommand",
        "RaidFinderParam",
        "ReactionEventObject",
        "ReactionEventObjectInfo",
        "ReplaceAction",
        "Resident",
        "RideShootingScheduler",
        "RideShootingTargetScheduler",
        "SatisfactionArbitration",
        "SatisfactionSupply",
        "SatisfactionSupplyRewardExp",
        "ScenarioTreeTipsClassQuest",
        "SequentialEventMultipleRange",
        "SnipeHitEvent",
        "SwitchTalkVariation",
        "SystemGraphicPreset",
        "TerritoryAetheryteList",
        "TreasureSpot",
        "VVDRouteData",
        "VVDVariantAction",
        "WeatherGroup",
        "WKSDevGradeBGSet",
        "WKSEmergencyInfo",
        "WKSEmergencyMission",
        "WKSEmergencyMissionGroup",
        "WKSMechaEventObjectGroup",
        "WKSMechaEventRewardUI",
        "WKSMechaLivelyActorGroup",
        "WKSMissionInfo",
        "WKSMissionToDoEvalutionItem",
        "WKSPioneeringTrail",
        "WKSPraiseHologram",
        "WKSZoneFloorCollision",
        "ZoneSharedGroup",
        "ZoneTimeline",
    ];
}
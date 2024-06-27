// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Action", columnHash: 0x7df0878f )]
public partial class Action : ExcelRow
{
    
    public SeString Name { get; private set; }
    public ILazyRow UnlockLink { get; private set; }
    public ushort Icon { get; private set; }
    public LazyRow< ActionCastVFX > VFX { get; private set; }
    public LazyRow< ActionTimeline > ActionTimelineHit { get; private set; }
    public ushort PrimaryCostValue { get; private set; }
    public ILazyRow SecondaryCostValue { get; private set; }
    public LazyRow< Action > ActionCombo { get; private set; }
    public ushort Cast100ms { get; private set; }
    public ushort Recast100ms { get; private set; }
    public LazyRow< Status > StatusGainSelf { get; private set; }
    public LazyRow< Omen > Omen { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< ActionTimeline > AnimationEnd { get; private set; }
    public LazyRow< ActionCategory > ActionCategory { get; private set; }
    public byte Unknown1 { get; private set; }
    public LazyRow< ActionCastTimeline > AnimationStart { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte BehaviourType { get; private set; }
    public byte ClassJobLevel { get; private set; }
    public byte CastType { get; private set; }
    public byte EffectRange { get; private set; }
    public byte XAxisModifier { get; private set; }
    public byte PrimaryCostType { get; private set; }
    public byte SecondaryCostType { get; private set; }
    public byte ExtraCastTime100ms { get; private set; }
    public byte CooldownGroup { get; private set; }
    public byte AdditionalCooldownGroup { get; private set; }
    public byte MaxCharges { get; private set; }
    public byte Aspect { get; private set; }
    public LazyRow< ActionProcStatus > ActionProcStatus { get; private set; }
    public byte Unknown4 { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown_70 { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    public sbyte Range { get; private set; }
    public sbyte DeadTargetBehaviour { get; private set; }
    public LazyRow< AttackType > AttackType { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool IsRoleAction { get; private set; }
    public bool CanTargetSelf { get; private set; }
    public bool CanTargetParty { get; private set; }
    public bool CanTargetAlliance { get; private set; }
    public bool CanTargetHostile { get; private set; }
    public bool CanTargetAlly { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool TargetArea { get; private set; }
    public bool CanTargetOwnPet { get; private set; }
    public bool CanTargetPartyPet { get; private set; }
    public bool RequiresLineOfSight { get; private set; }
    public bool NeedToFaceTarget { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool PreservesCombo { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool AffectsPosition { get; private set; }
    public bool IsPvP { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool LogCastMessage { get; private set; }
    public bool Unknown18 { get; private set; }
    public bool LogMissMessage { get; private set; }
    public bool LogActionMessage { get; private set; }
    public bool Unknown21 { get; private set; }
    public bool Unknown22 { get; private set; }
    public bool Unknown23 { get; private set; }
    public bool Unknown24 { get; private set; }
    public bool Unknown25 { get; private set; }
    public bool IsPlayerAction { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        UnlockLink = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 4 ), language, "ChocoboTaxiStand", "CraftLeve", "CustomTalk", "DefaultTalk", "FccShop", "GCShop", "GilShop", "GuildleveAssignment", "GuildOrderGuide", "GuildOrderOfficer", "Quest", "SpecialShop", "Story", "SwitchTalk", "TopicSelect", "TripleTriad", "Warp" );
        Icon = parser.ReadOffset< ushort >( 8 );
        VFX = new LazyRow< ActionCastVFX >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        ActionTimelineHit = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        PrimaryCostValue = parser.ReadOffset< ushort >( 14 );
        var SecondaryCostValueRowId = parser.ReadOffset< ushort >( 16 );
        ActionCombo = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 18 ), language );
        Cast100ms = parser.ReadOffset< ushort >( 20 );
        Recast100ms = parser.ReadOffset< ushort >( 22 );
        StatusGainSelf = new LazyRow< Status >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        Omen = new LazyRow< Omen >( gameData, parser.ReadOffset< ushort >( 26 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 28 );
        AnimationEnd = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< short >( 30 ), language );
        ActionCategory = new LazyRow< ActionCategory >( gameData, parser.ReadOffset< byte >( 32 ), language );
        Unknown1 = parser.ReadOffset< byte >( 33 );
        AnimationStart = new LazyRow< ActionCastTimeline >( gameData, parser.ReadOffset< byte >( 34 ), language );
        Unknown2 = parser.ReadOffset< byte >( 35 );
        BehaviourType = parser.ReadOffset< byte >( 36 );
        ClassJobLevel = parser.ReadOffset< byte >( 37 );
        CastType = parser.ReadOffset< byte >( 38 );
        EffectRange = parser.ReadOffset< byte >( 39 );
        XAxisModifier = parser.ReadOffset< byte >( 40 );
        PrimaryCostType = parser.ReadOffset< byte >( 41 );
        SecondaryCostType = parser.ReadOffset< byte >( 42 );
        ExtraCastTime100ms = parser.ReadOffset< byte >( 43 );
        CooldownGroup = parser.ReadOffset< byte >( 44 );
        AdditionalCooldownGroup = parser.ReadOffset< byte >( 45 );
        MaxCharges = parser.ReadOffset< byte >( 46 );
        Aspect = parser.ReadOffset< byte >( 47 );
        ActionProcStatus = new LazyRow< ActionProcStatus >( gameData, parser.ReadOffset< byte >( 48 ), language );
        Unknown4 = parser.ReadOffset< byte >( 49 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 50 ), language );
        Unknown5 = parser.ReadOffset< byte >( 51 );
        Unknown6 = parser.ReadOffset< byte >( 52 );
        Unknown_70 = parser.ReadOffset< byte >( 53 );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< sbyte >( 54 ), language );
        Range = parser.ReadOffset< sbyte >( 55 );
        DeadTargetBehaviour = parser.ReadOffset< sbyte >( 56 );
        AttackType = new LazyRow< AttackType >( gameData, parser.ReadOffset< sbyte >( 57 ), language );
        Unknown8 = parser.ReadOffset< bool >( 58 );
        IsRoleAction = parser.ReadOffset< bool >( 58, 2 );
        CanTargetSelf = parser.ReadOffset< bool >( 58, 4 );
        CanTargetParty = parser.ReadOffset< bool >( 58, 8 );
        CanTargetAlliance = parser.ReadOffset< bool >( 58, 16 );
        CanTargetHostile = parser.ReadOffset< bool >( 58, 32 );
        CanTargetAlly = parser.ReadOffset< bool >( 58, 64 );
        Unknown10 = parser.ReadOffset< bool >( 58, 128 );
        TargetArea = parser.ReadOffset< bool >( 59 );
        CanTargetOwnPet = parser.ReadOffset< bool >( 59, 2 );
        CanTargetPartyPet = parser.ReadOffset< bool >( 59, 4 );
        RequiresLineOfSight = parser.ReadOffset< bool >( 59, 8 );
        NeedToFaceTarget = parser.ReadOffset< bool >( 59, 16 );
        Unknown14 = parser.ReadOffset< bool >( 59, 32 );
        PreservesCombo = parser.ReadOffset< bool >( 59, 64 );
        Unknown15 = parser.ReadOffset< bool >( 59, 128 );
        AffectsPosition = parser.ReadOffset< bool >( 60 );
        IsPvP = parser.ReadOffset< bool >( 60, 2 );
        Unknown16 = parser.ReadOffset< bool >( 60, 4 );
        LogCastMessage = parser.ReadOffset< bool >( 60, 8 );
        Unknown18 = parser.ReadOffset< bool >( 60, 16 );
        LogMissMessage = parser.ReadOffset< bool >( 60, 32 );
        LogActionMessage = parser.ReadOffset< bool >( 60, 64 );
        Unknown21 = parser.ReadOffset< bool >( 60, 128 );
        Unknown22 = parser.ReadOffset< bool >( 61 );
        Unknown23 = parser.ReadOffset< bool >( 61, 2 );
        Unknown24 = parser.ReadOffset< bool >( 61, 4 );
        Unknown25 = parser.ReadOffset< bool >( 61, 8 );
        IsPlayerAction = parser.ReadOffset< bool >( 61, 16 );
        
        SecondaryCostValue = SecondaryCostType switch
        {
        	32 => new LazyRow< Status >( gameData, SecondaryCostValueRowId, language ),
        	35 => new LazyRow< Status >( gameData, SecondaryCostValueRowId, language ),
        	46 => new LazyRow< Status >( gameData, SecondaryCostValueRowId, language ),
        	_ => new EmptyLazyRow( (uint) SecondaryCostValueRowId ),
        };
    }
}
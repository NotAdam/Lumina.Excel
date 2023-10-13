// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Action", columnHash: 0xfedb4d9a )]
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
    public ushort Unknown54 { get; private set; }
    public LazyRow< ActionTimeline > AnimationEnd { get; private set; }
    public LazyRow< ActionCategory > ActionCategory { get; private set; }
    public byte Unknown4 { get; private set; }
    public LazyRow< ActionCastTimeline > AnimationStart { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte BehaviourType { get; private set; }
    public byte ClassJobLevel { get; private set; }
    public byte CastType { get; private set; }
    public byte EffectRange { get; private set; }
    public byte XAxisModifier { get; private set; }
    public byte PrimaryCostType { get; private set; }
    public byte SecondaryCostType { get; private set; }
    public byte Unknown38 { get; private set; }
    public byte CooldownGroup { get; private set; }
    public byte AdditionalCooldownGroup { get; private set; }
    public byte MaxCharges { get; private set; }
    public byte Aspect { get; private set; }
    public LazyRow< ActionProcStatus > ActionProcStatus { get; private set; }
    public byte Unknown46 { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte Unknown50 { get; private set; }
    public byte Unknown64 { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    public sbyte Range { get; private set; }
    public sbyte Unknown24 { get; private set; }
    public LazyRow< AttackType > AttackType { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool IsRoleAction { get; private set; }
    public bool CanTargetSelf { get; private set; }
    public bool CanTargetParty { get; private set; }
    public bool CanTargetFriendly { get; private set; }
    public bool CanTargetHostile { get; private set; }
    public bool Unknown19 { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool TargetArea { get; private set; }
    public bool Unknown22 { get; private set; }
    public bool Unknown23 { get; private set; }
    public bool CanTargetDead { get; private set; }
    public bool Unknown26 { get; private set; }
    public bool Unknown30 { get; private set; }
    public bool PreservesCombo { get; private set; }
    public bool Unknown51 { get; private set; }
    public bool AffectsPosition { get; private set; }
    public bool IsPvP { get; private set; }
    public bool Unknown56 { get; private set; }
    public bool Unknown57 { get; private set; }
    public bool Unknown58 { get; private set; }
    public bool Unknown59 { get; private set; }
    public bool Unknown60 { get; private set; }
    public bool Unknown61 { get; private set; }
    public bool Unknown62 { get; private set; }
    public bool Unknown63 { get; private set; }
    public bool Unknown65 { get; private set; }
    public bool Unknown66 { get; private set; }
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
        Unknown54 = parser.ReadOffset< ushort >( 28 );
        AnimationEnd = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< short >( 30 ), language );
        ActionCategory = new LazyRow< ActionCategory >( gameData, parser.ReadOffset< byte >( 32 ), language );
        Unknown4 = parser.ReadOffset< byte >( 33 );
        AnimationStart = new LazyRow< ActionCastTimeline >( gameData, parser.ReadOffset< byte >( 34 ), language );
        Unknown9 = parser.ReadOffset< byte >( 35 );
        BehaviourType = parser.ReadOffset< byte >( 36 );
        ClassJobLevel = parser.ReadOffset< byte >( 37 );
        CastType = parser.ReadOffset< byte >( 38 );
        EffectRange = parser.ReadOffset< byte >( 39 );
        XAxisModifier = parser.ReadOffset< byte >( 40 );
        PrimaryCostType = parser.ReadOffset< byte >( 41 );
        SecondaryCostType = parser.ReadOffset< byte >( 42 );
        Unknown38 = parser.ReadOffset< byte >( 43 );
        CooldownGroup = parser.ReadOffset< byte >( 44 );
        AdditionalCooldownGroup = parser.ReadOffset< byte >( 45 );
        MaxCharges = parser.ReadOffset< byte >( 46 );
        Aspect = parser.ReadOffset< byte >( 47 );
        ActionProcStatus = new LazyRow< ActionProcStatus >( gameData, parser.ReadOffset< byte >( 48 ), language );
        Unknown46 = parser.ReadOffset< byte >( 49 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 50 ), language );
        Unknown50 = parser.ReadOffset< byte >( 51 );
        Unknown64 = parser.ReadOffset< byte >( 52 );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< sbyte >( 53 ), language );
        Range = parser.ReadOffset< sbyte >( 54 );
        Unknown24 = parser.ReadOffset< sbyte >( 55 );
        AttackType = new LazyRow< AttackType >( gameData, parser.ReadOffset< sbyte >( 56 ), language );
        Unknown1 = parser.ReadOffset< bool >( 57 );
        IsRoleAction = parser.ReadOffset< bool >( 57, 2 );
        CanTargetSelf = parser.ReadOffset< bool >( 57, 4 );
        CanTargetParty = parser.ReadOffset< bool >( 57, 8 );
        CanTargetFriendly = parser.ReadOffset< bool >( 57, 16 );
        CanTargetHostile = parser.ReadOffset< bool >( 57, 32 );
        Unknown19 = parser.ReadOffset< bool >( 57, 64 );
        Unknown20 = parser.ReadOffset< bool >( 57, 128 );
        TargetArea = parser.ReadOffset< bool >( 58 );
        Unknown22 = parser.ReadOffset< bool >( 58, 2 );
        Unknown23 = parser.ReadOffset< bool >( 58, 4 );
        CanTargetDead = parser.ReadOffset< bool >( 58, 8 );
        Unknown26 = parser.ReadOffset< bool >( 58, 16 );
        Unknown30 = parser.ReadOffset< bool >( 58, 32 );
        PreservesCombo = parser.ReadOffset< bool >( 58, 64 );
        Unknown51 = parser.ReadOffset< bool >( 58, 128 );
        AffectsPosition = parser.ReadOffset< bool >( 59 );
        IsPvP = parser.ReadOffset< bool >( 59, 2 );
        Unknown56 = parser.ReadOffset< bool >( 59, 4 );
        Unknown57 = parser.ReadOffset< bool >( 59, 8 );
        Unknown58 = parser.ReadOffset< bool >( 59, 16 );
        Unknown59 = parser.ReadOffset< bool >( 59, 32 );
        Unknown60 = parser.ReadOffset< bool >( 59, 64 );
        Unknown61 = parser.ReadOffset< bool >( 59, 128 );
        Unknown62 = parser.ReadOffset< bool >( 60 );
        Unknown63 = parser.ReadOffset< bool >( 60, 2 );
        Unknown65 = parser.ReadOffset< bool >( 60, 4 );
        Unknown66 = parser.ReadOffset< bool >( 60, 8 );
        IsPlayerAction = parser.ReadOffset< bool >( 60, 16 );
        
        SecondaryCostValue = SecondaryCostType switch
        {
        	32 => new LazyRow< Status >( gameData, SecondaryCostValueRowId, language ),
        	35 => new LazyRow< Status >( gameData, SecondaryCostValueRowId, language ),
        	46 => new LazyRow< Status >( gameData, SecondaryCostValueRowId, language ),
        	_ => new EmptyLazyRow( (uint) SecondaryCostValueRowId ),
        };
    }
}
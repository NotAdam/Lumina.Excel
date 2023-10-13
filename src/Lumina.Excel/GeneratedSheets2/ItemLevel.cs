// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemLevel", columnHash: 0xe216399f )]
public partial class ItemLevel : ExcelRow
{
    
    public ushort Strength { get; private set; }
    public ushort Dexterity { get; private set; }
    public ushort Vitality { get; private set; }
    public ushort Intelligence { get; private set; }
    public ushort Mind { get; private set; }
    public ushort Piety { get; private set; }
    public ushort HP { get; private set; }
    public ushort MP { get; private set; }
    public ushort TP { get; private set; }
    public ushort GP { get; private set; }
    public ushort CP { get; private set; }
    public ushort PhysicalDamage { get; private set; }
    public ushort MagicalDamage { get; private set; }
    public ushort Delay { get; private set; }
    public ushort AdditionalEffect { get; private set; }
    public ushort AttackSpeed { get; private set; }
    public ushort BlockRate { get; private set; }
    public ushort BlockStrength { get; private set; }
    public ushort Tenacity { get; private set; }
    public ushort AttackPower { get; private set; }
    public ushort Defense { get; private set; }
    public ushort DirectHitRate { get; private set; }
    public ushort Evasion { get; private set; }
    public ushort MagicDefense { get; private set; }
    public ushort CriticalHitPower { get; private set; }
    public ushort CriticalHitResilience { get; private set; }
    public ushort CriticalHit { get; private set; }
    public ushort CriticalHitEvasion { get; private set; }
    public ushort SlashingResistance { get; private set; }
    public ushort PiercingResistance { get; private set; }
    public ushort BluntResistance { get; private set; }
    public ushort ProjectileResistance { get; private set; }
    public ushort AttackMagicPotency { get; private set; }
    public ushort HealingMagicPotency { get; private set; }
    public ushort EnhancementMagicPotency { get; private set; }
    public ushort EnfeeblingMagicPotency { get; private set; }
    public ushort FireResistance { get; private set; }
    public ushort IceResistance { get; private set; }
    public ushort WindResistance { get; private set; }
    public ushort EarthResistance { get; private set; }
    public ushort LightningResistance { get; private set; }
    public ushort WaterResistance { get; private set; }
    public ushort MagicResistance { get; private set; }
    public ushort Determination { get; private set; }
    public ushort SkillSpeed { get; private set; }
    public ushort SpellSpeed { get; private set; }
    public ushort Haste { get; private set; }
    public ushort Morale { get; private set; }
    public ushort Enmity { get; private set; }
    public ushort EnmityReduction { get; private set; }
    public ushort CarefulDesynthesis { get; private set; }
    public ushort EXPBonus { get; private set; }
    public ushort Regen { get; private set; }
    public ushort Refresh { get; private set; }
    public ushort MovementSpeed { get; private set; }
    public ushort Spikes { get; private set; }
    public ushort SlowResistance { get; private set; }
    public ushort PetrificationResistance { get; private set; }
    public ushort ParalysisResistance { get; private set; }
    public ushort SilenceResistance { get; private set; }
    public ushort BlindResistance { get; private set; }
    public ushort PoisonResistance { get; private set; }
    public ushort StunResistance { get; private set; }
    public ushort SleepResistance { get; private set; }
    public ushort BindResistance { get; private set; }
    public ushort HeavyResistance { get; private set; }
    public ushort DoomResistance { get; private set; }
    public ushort ReducedDurabilityLoss { get; private set; }
    public ushort IncreasedSpiritbondGain { get; private set; }
    public ushort Craftsmanship { get; private set; }
    public ushort Control { get; private set; }
    public ushort Gathering { get; private set; }
    public ushort Perception { get; private set; }
    public ushort Unknown73 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Strength = parser.ReadOffset< ushort >( 0 );
        Dexterity = parser.ReadOffset< ushort >( 2 );
        Vitality = parser.ReadOffset< ushort >( 4 );
        Intelligence = parser.ReadOffset< ushort >( 6 );
        Mind = parser.ReadOffset< ushort >( 8 );
        Piety = parser.ReadOffset< ushort >( 10 );
        HP = parser.ReadOffset< ushort >( 12 );
        MP = parser.ReadOffset< ushort >( 14 );
        TP = parser.ReadOffset< ushort >( 16 );
        GP = parser.ReadOffset< ushort >( 18 );
        CP = parser.ReadOffset< ushort >( 20 );
        PhysicalDamage = parser.ReadOffset< ushort >( 22 );
        MagicalDamage = parser.ReadOffset< ushort >( 24 );
        Delay = parser.ReadOffset< ushort >( 26 );
        AdditionalEffect = parser.ReadOffset< ushort >( 28 );
        AttackSpeed = parser.ReadOffset< ushort >( 30 );
        BlockRate = parser.ReadOffset< ushort >( 32 );
        BlockStrength = parser.ReadOffset< ushort >( 34 );
        Tenacity = parser.ReadOffset< ushort >( 36 );
        AttackPower = parser.ReadOffset< ushort >( 38 );
        Defense = parser.ReadOffset< ushort >( 40 );
        DirectHitRate = parser.ReadOffset< ushort >( 42 );
        Evasion = parser.ReadOffset< ushort >( 44 );
        MagicDefense = parser.ReadOffset< ushort >( 46 );
        CriticalHitPower = parser.ReadOffset< ushort >( 48 );
        CriticalHitResilience = parser.ReadOffset< ushort >( 50 );
        CriticalHit = parser.ReadOffset< ushort >( 52 );
        CriticalHitEvasion = parser.ReadOffset< ushort >( 54 );
        SlashingResistance = parser.ReadOffset< ushort >( 56 );
        PiercingResistance = parser.ReadOffset< ushort >( 58 );
        BluntResistance = parser.ReadOffset< ushort >( 60 );
        ProjectileResistance = parser.ReadOffset< ushort >( 62 );
        AttackMagicPotency = parser.ReadOffset< ushort >( 64 );
        HealingMagicPotency = parser.ReadOffset< ushort >( 66 );
        EnhancementMagicPotency = parser.ReadOffset< ushort >( 68 );
        EnfeeblingMagicPotency = parser.ReadOffset< ushort >( 70 );
        FireResistance = parser.ReadOffset< ushort >( 72 );
        IceResistance = parser.ReadOffset< ushort >( 74 );
        WindResistance = parser.ReadOffset< ushort >( 76 );
        EarthResistance = parser.ReadOffset< ushort >( 78 );
        LightningResistance = parser.ReadOffset< ushort >( 80 );
        WaterResistance = parser.ReadOffset< ushort >( 82 );
        MagicResistance = parser.ReadOffset< ushort >( 84 );
        Determination = parser.ReadOffset< ushort >( 86 );
        SkillSpeed = parser.ReadOffset< ushort >( 88 );
        SpellSpeed = parser.ReadOffset< ushort >( 90 );
        Haste = parser.ReadOffset< ushort >( 92 );
        Morale = parser.ReadOffset< ushort >( 94 );
        Enmity = parser.ReadOffset< ushort >( 96 );
        EnmityReduction = parser.ReadOffset< ushort >( 98 );
        CarefulDesynthesis = parser.ReadOffset< ushort >( 100 );
        EXPBonus = parser.ReadOffset< ushort >( 102 );
        Regen = parser.ReadOffset< ushort >( 104 );
        Refresh = parser.ReadOffset< ushort >( 106 );
        MovementSpeed = parser.ReadOffset< ushort >( 108 );
        Spikes = parser.ReadOffset< ushort >( 110 );
        SlowResistance = parser.ReadOffset< ushort >( 112 );
        PetrificationResistance = parser.ReadOffset< ushort >( 114 );
        ParalysisResistance = parser.ReadOffset< ushort >( 116 );
        SilenceResistance = parser.ReadOffset< ushort >( 118 );
        BlindResistance = parser.ReadOffset< ushort >( 120 );
        PoisonResistance = parser.ReadOffset< ushort >( 122 );
        StunResistance = parser.ReadOffset< ushort >( 124 );
        SleepResistance = parser.ReadOffset< ushort >( 126 );
        BindResistance = parser.ReadOffset< ushort >( 128 );
        HeavyResistance = parser.ReadOffset< ushort >( 130 );
        DoomResistance = parser.ReadOffset< ushort >( 132 );
        ReducedDurabilityLoss = parser.ReadOffset< ushort >( 134 );
        IncreasedSpiritbondGain = parser.ReadOffset< ushort >( 136 );
        Craftsmanship = parser.ReadOffset< ushort >( 138 );
        Control = parser.ReadOffset< ushort >( 140 );
        Gathering = parser.ReadOffset< ushort >( 142 );
        Perception = parser.ReadOffset< ushort >( 144 );
        Unknown73 = parser.ReadOffset< ushort >( 146 );
        

    }
}
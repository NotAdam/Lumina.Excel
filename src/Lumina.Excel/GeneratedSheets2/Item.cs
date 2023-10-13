// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Item", columnHash: 0x800968c9 )]
public partial class Item : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public SeString Description { get; private set; }
    public SeString Name { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public ulong ModelMain { get; private set; }
    public ulong ModelSub { get; private set; }
    public ushort DamagePhys { get; private set; }
    public ushort DamageMag { get; private set; }
    public ushort Delayms { get; private set; }
    public ushort BlockRate { get; private set; }
    public ushort Block { get; private set; }
    public ushort DefensePhys { get; private set; }
    public ushort DefenseMag { get; private set; }
    public short[] BaseParamValue { get; private set; }
    public short[] BaseParamValueSpecial { get; private set; }
    public byte LevelEquip { get; private set; }
    public byte Unknown41 { get; private set; }
    public byte EquipRestriction { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public LazyRow< GrandCompany > GrandCompany { get; private set; }
    public LazyRow< ItemSeries > ItemSeries { get; private set; }
    public byte BaseParamModifier { get; private set; }
    public LazyRow< ClassJob > ClassJobUse { get; private set; }
    public byte Unknown50 { get; private set; }
    public byte Unknown54 { get; private set; }
    public LazyRow< BaseParam >[] BaseParam { get; private set; }
    public LazyRow< ItemSpecialBonus > ItemSpecialBonus { get; private set; }
    public byte ItemSpecialBonusParam { get; private set; }
    public LazyRow< BaseParam >[] BaseParamSpecial { get; private set; }
    public byte MaterializeType { get; private set; }
    public byte MateriaSlotCount { get; private set; }
    public byte SubStatCategory { get; private set; }
    public bool IsAdvancedMeldingPermitted { get; private set; }
    public bool IsPvP { get; private set; }
    public bool IsGlamorous { get; private set; }
    public ILazyRow AdditionalData { get; private set; }
    public uint StackSize { get; private set; }
    public uint PriceMid { get; private set; }
    public uint PriceLow { get; private set; }
    public LazyRow< ItemRepairResource > ItemRepair { get; private set; }
    public LazyRow< Item > ItemGlamour { get; private set; }
    public ushort Icon { get; private set; }
    public LazyRow< ItemLevel > LevelItem { get; private set; }
    public ushort Unknown19 { get; private set; }
    public LazyRow< ItemAction > ItemAction { get; private set; }
    public ushort Cooldowns { get; private set; }
    public ushort Desynth { get; private set; }
    public ushort AetherialReduce { get; private set; }
    public byte Rarity { get; private set; }
    public byte FilterGroup { get; private set; }
    public LazyRow< ItemUICategory > ItemUICategory { get; private set; }
    public LazyRow< ItemSearchCategory > ItemSearchCategory { get; private set; }
    public LazyRow< EquipSlotCategory > EquipSlotCategory { get; private set; }
    public LazyRow< ItemSortCategory > ItemSortCategory { get; private set; }
    public byte CastTimes { get; private set; }
    public LazyRow< ClassJob > ClassJobRepair { get; private set; }
    public bool IsUnique { get; private set; }
    public bool IsUntradable { get; private set; }
    public bool IsIndisposable { get; private set; }
    public bool Lot { get; private set; }
    public bool CanBeHq { get; private set; }
    public bool IsDyeable { get; private set; }
    public bool IsCrestWorthy { get; private set; }
    public bool IsCollectable { get; private set; }
    public bool AlwaysCollectable { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        Description = parser.ReadOffset< SeString >( 8 );
        Name = parser.ReadOffset< SeString >( 12 );
        Adjective = parser.ReadOffset< sbyte >( 16 );
        PossessivePronoun = parser.ReadOffset< sbyte >( 17 );
        StartsWithVowel = parser.ReadOffset< sbyte >( 18 );
        Unknown5 = parser.ReadOffset< sbyte >( 19 );
        Pronoun = parser.ReadOffset< sbyte >( 20 );
        Article = parser.ReadOffset< sbyte >( 21 );
        ModelMain = parser.ReadOffset< ulong >( 24 );
        ModelSub = parser.ReadOffset< ulong >( 32 );
        DamagePhys = parser.ReadOffset< ushort >( 40 );
        DamageMag = parser.ReadOffset< ushort >( 42 );
        Delayms = parser.ReadOffset< ushort >( 44 );
        BlockRate = parser.ReadOffset< ushort >( 46 );
        Block = parser.ReadOffset< ushort >( 48 );
        DefensePhys = parser.ReadOffset< ushort >( 50 );
        DefenseMag = parser.ReadOffset< ushort >( 52 );
        BaseParamValue = new short[6];
        for (int i = 0; i < 6; i++)
        	BaseParamValue[i] = parser.ReadOffset< short >( 54 + i * 2 );
        BaseParamValueSpecial = new short[6];
        for (int i = 0; i < 6; i++)
        	BaseParamValueSpecial[i] = parser.ReadOffset< short >( 66 + i * 2 );
        LevelEquip = parser.ReadOffset< byte >( 78 );
        Unknown41 = parser.ReadOffset< byte >( 79 );
        EquipRestriction = parser.ReadOffset< byte >( 80 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 81 ), language );
        GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadOffset< byte >( 82 ), language );
        ItemSeries = new LazyRow< ItemSeries >( gameData, parser.ReadOffset< byte >( 83 ), language );
        BaseParamModifier = parser.ReadOffset< byte >( 84 );
        ClassJobUse = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 85 ), language );
        Unknown50 = parser.ReadOffset< byte >( 86 );
        Unknown54 = parser.ReadOffset< byte >( 87 );
        BaseParam = new LazyRow< BaseParam >[6];
        for (int i = 0; i < 6; i++)
        	BaseParam[i] = new LazyRow< BaseParam >( gameData, parser.ReadOffset< byte >( (ushort) ( 88 + i * 1 ) ), language );
        ItemSpecialBonus = new LazyRow< ItemSpecialBonus >( gameData, parser.ReadOffset< byte >( 94 ), language );
        ItemSpecialBonusParam = parser.ReadOffset< byte >( 95 );
        BaseParamSpecial = new LazyRow< BaseParam >[6];
        for (int i = 0; i < 6; i++)
        	BaseParamSpecial[i] = new LazyRow< BaseParam >( gameData, parser.ReadOffset< byte >( (ushort) ( 96 + i * 1 ) ), language );
        MaterializeType = parser.ReadOffset< byte >( 102 );
        MateriaSlotCount = parser.ReadOffset< byte >( 103 );
        SubStatCategory = parser.ReadOffset< byte >( 104 );
        IsAdvancedMeldingPermitted = parser.ReadOffset< bool >( 105 );
        IsPvP = parser.ReadOffset< bool >( 105, 2 );
        IsGlamorous = parser.ReadOffset< bool >( 105, 4 );
        var AdditionalDataRowId = parser.ReadOffset< uint >( 112 );
        StackSize = parser.ReadOffset< uint >( 116 );
        PriceMid = parser.ReadOffset< uint >( 120 );
        PriceLow = parser.ReadOffset< uint >( 124 );
        ItemRepair = new LazyRow< ItemRepairResource >( gameData, parser.ReadOffset< int >( 128 ), language );
        ItemGlamour = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 132 ), language );
        Icon = parser.ReadOffset< ushort >( 136 );
        LevelItem = new LazyRow< ItemLevel >( gameData, parser.ReadOffset< ushort >( 138 ), language );
        Unknown19 = parser.ReadOffset< ushort >( 140 );
        ItemAction = new LazyRow< ItemAction >( gameData, parser.ReadOffset< ushort >( 142 ), language );
        Cooldowns = parser.ReadOffset< ushort >( 144 );
        Desynth = parser.ReadOffset< ushort >( 146 );
        AetherialReduce = parser.ReadOffset< ushort >( 148 );
        Rarity = parser.ReadOffset< byte >( 150 );
        FilterGroup = parser.ReadOffset< byte >( 151 );
        ItemUICategory = new LazyRow< ItemUICategory >( gameData, parser.ReadOffset< byte >( 152 ), language );
        ItemSearchCategory = new LazyRow< ItemSearchCategory >( gameData, parser.ReadOffset< byte >( 153 ), language );
        EquipSlotCategory = new LazyRow< EquipSlotCategory >( gameData, parser.ReadOffset< byte >( 154 ), language );
        ItemSortCategory = new LazyRow< ItemSortCategory >( gameData, parser.ReadOffset< byte >( 155 ), language );
        CastTimes = parser.ReadOffset< byte >( 156 );
        ClassJobRepair = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 157 ), language );
        IsUnique = parser.ReadOffset< bool >( 158 );
        IsUntradable = parser.ReadOffset< bool >( 158, 2 );
        IsIndisposable = parser.ReadOffset< bool >( 158, 4 );
        Lot = parser.ReadOffset< bool >( 158, 8 );
        CanBeHq = parser.ReadOffset< bool >( 158, 16 );
        IsDyeable = parser.ReadOffset< bool >( 158, 32 );
        IsCrestWorthy = parser.ReadOffset< bool >( 158, 64 );
        IsCollectable = parser.ReadOffset< bool >( 158, 128 );
        AlwaysCollectable = parser.ReadOffset< bool >( 159 );
        
        AdditionalData = FilterGroup switch
        {
        	14 => EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) AdditionalDataRowId, language, "HousingExterior", "HousingInterior", "HousingYardObject", "HousingFurniture", "HousingPreset", "HousingUnitedExterior" ),
        	15 => new LazyRow< Stain >( gameData, AdditionalDataRowId, language ),
        	18 => new LazyRow< TreasureHuntRank >( gameData, AdditionalDataRowId, language ),
        	20 => new LazyRow< GardeningSeed >( gameData, AdditionalDataRowId, language ),
        	25 => new LazyRow< AetherialWheel >( gameData, AdditionalDataRowId, language ),
        	26 => new LazyRow< CompanyAction >( gameData, AdditionalDataRowId, language ),
        	27 => new LazyRow< TripleTriadCard >( gameData, AdditionalDataRowId, language ),
        	28 => new LazyRow< AirshipExplorationPart >( gameData, AdditionalDataRowId, language ),
        	32 => new LazyRow< Orchestrion >( gameData, AdditionalDataRowId, language ),
        	36 => new LazyRow< SubmarinePart >( gameData, AdditionalDataRowId, language ),
        	_ => new EmptyLazyRow( (uint) AdditionalDataRowId ),
        };
    }
}
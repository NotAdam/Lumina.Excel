// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ClassJob", columnHash: 0xe62cb7ae )]
public partial class ClassJob : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Abbreviation { get; private set; }
    public SeString Unknown0 { get; private set; }
    public bool CanQueueForDuty { get; private set; }
    public SeString NameEnglish { get; private set; }
    public LazyRow< Item > ItemSoulCrystal { get; private set; }
    public LazyRow< Quest > UnlockQuest { get; private set; }
    public LazyRow< Quest > RelicQuest { get; private set; }
    public LazyRow< Quest > Prerequisite { get; private set; }
    public int Unknown_70_1 { get; private set; }
    public int Unknown_70_2 { get; private set; }
    public LazyRow< Item > ItemStartingWeapon { get; private set; }
    public int Unknown1 { get; private set; }
    public ushort ModifierHitPoints { get; private set; }
    public ushort ModifierManaPoints { get; private set; }
    public ushort ModifierStrength { get; private set; }
    public ushort ModifierVitality { get; private set; }
    public ushort ModifierDexterity { get; private set; }
    public ushort ModifierIntelligence { get; private set; }
    public ushort ModifierMind { get; private set; }
    public ushort ModifierPiety { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public LazyRow< Action > LimitBreak1 { get; private set; }
    public LazyRow< Action > LimitBreak2 { get; private set; }
    public LazyRow< Action > LimitBreak3 { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte JobIndex { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte PvPActionSortRow { get; private set; }
    public byte Unknown10 { get; private set; }
    public LazyRow< ClassJob > ClassJobParent { get; private set; }
    public byte Role { get; private set; }
    public LazyRow< Town > StartingTown { get; private set; }
    public byte PrimaryStat { get; private set; }
    public byte UIPriority { get; private set; }
    public byte StartingLevel { get; private set; }
    public byte PartyBonus { get; private set; }
    public byte Unknown11 { get; private set; }
    public sbyte ExpArrayIndex { get; private set; }
    public sbyte BattleClassIndex { get; private set; }
    public sbyte DohDolJobIndex { get; private set; }
    public LazyRow< MonsterNote > MonsterNote { get; private set; }
    public bool IsLimitedJob { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Abbreviation = parser.ReadOffset< SeString >( 4 );
        Unknown0 = parser.ReadOffset< SeString >( 8 );
        CanQueueForDuty = parser.ReadOffset< bool >( 12 );
        NameEnglish = parser.ReadOffset< SeString >( 16 );
        ItemSoulCrystal = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 20 ), language );
        UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 24 ), language );
        RelicQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 28 ), language );
        Prerequisite = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 32 ), language );
        Unknown_70_1 = parser.ReadOffset< int >( 36 );
        Unknown_70_2 = parser.ReadOffset< int >( 40 );
        ItemStartingWeapon = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 44 ), language );
        Unknown1 = parser.ReadOffset< int >( 48 );
        ModifierHitPoints = parser.ReadOffset< ushort >( 52 );
        ModifierManaPoints = parser.ReadOffset< ushort >( 54 );
        ModifierStrength = parser.ReadOffset< ushort >( 56 );
        ModifierVitality = parser.ReadOffset< ushort >( 58 );
        ModifierDexterity = parser.ReadOffset< ushort >( 60 );
        ModifierIntelligence = parser.ReadOffset< ushort >( 62 );
        ModifierMind = parser.ReadOffset< ushort >( 64 );
        ModifierPiety = parser.ReadOffset< ushort >( 66 );
        Unknown2 = parser.ReadOffset< ushort >( 68 );
        Unknown3 = parser.ReadOffset< ushort >( 70 );
        Unknown4 = parser.ReadOffset< ushort >( 72 );
        Unknown5 = parser.ReadOffset< ushort >( 74 );
        Unknown6 = parser.ReadOffset< ushort >( 76 );
        Unknown7 = parser.ReadOffset< ushort >( 78 );
        LimitBreak1 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 80 ), language );
        LimitBreak2 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 82 ), language );
        LimitBreak3 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 84 ), language );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 86 ), language );
        Unknown8 = parser.ReadOffset< byte >( 87 );
        JobIndex = parser.ReadOffset< byte >( 88 );
        Unknown9 = parser.ReadOffset< byte >( 89 );
        PvPActionSortRow = parser.ReadOffset< byte >( 90 );
        Unknown10 = parser.ReadOffset< byte >( 91 );
        ClassJobParent = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 92 ), language );
        Role = parser.ReadOffset< byte >( 93 );
        StartingTown = new LazyRow< Town >( gameData, parser.ReadOffset< byte >( 94 ), language );
        PrimaryStat = parser.ReadOffset< byte >( 95 );
        UIPriority = parser.ReadOffset< byte >( 96 );
        StartingLevel = parser.ReadOffset< byte >( 97 );
        PartyBonus = parser.ReadOffset< byte >( 98 );
        Unknown11 = parser.ReadOffset< byte >( 99 );
        ExpArrayIndex = parser.ReadOffset< sbyte >( 100 );
        BattleClassIndex = parser.ReadOffset< sbyte >( 101 );
        DohDolJobIndex = parser.ReadOffset< sbyte >( 102 );
        MonsterNote = new LazyRow< MonsterNote >( gameData, parser.ReadOffset< sbyte >( 103 ), language );
        IsLimitedJob = parser.ReadOffset< bool >( 104 );
        

    }
}
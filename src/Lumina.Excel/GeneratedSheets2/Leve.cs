// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Leve", columnHash: 0xb1795a98 )]
public partial class Leve : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public float ExpFactor { get; private set; }
    public uint ExpReward { get; private set; }
    public uint GilReward { get; private set; }
    public LazyRow< LeveRewardItem > LeveRewardItem { get; private set; }
    public LazyRow< JournalGenre > JournalGenre { get; private set; }
    public LazyRow< Level > LevelLevemete { get; private set; }
    public LazyRow< Level > LevelStart { get; private set; }
    public LazyRow< LeveClient > LeveClient { get; private set; }
    public LazyRow< LeveAssignmentType > LeveAssignmentType { get; private set; }
    public LazyRow< Town > Town { get; private set; }
    public int Evaluation { get; private set; }
    public LazyRow< PlaceName > PlaceNameStart { get; private set; }
    public LazyRow< PlaceName > PlaceNameIssued { get; private set; }
    public int Unknown17 { get; private set; }
    public LazyRow< PlaceName > PlaceNameStartZone { get; private set; }
    public int IconCityState { get; private set; }
    public ILazyRow DataId { get; private set; }
    public int IconIssuer { get; private set; }
    public ushort ClassJobLevel { get; private set; }
    public LazyRow< FishingSpot > FishingSpot { get; private set; }
    public LazyRow< BGM > BGM { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte TimeLimit { get; private set; }
    public byte AllowanceCost { get; private set; }
    public byte Unknown13 { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte MaxDifficulty { get; private set; }
    public LazyRow< LeveVfx > LeveVfx { get; private set; }
    public LazyRow< LeveVfx > LeveVfxFrame { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool CanCancel { get; private set; }
    public bool LockedLeve { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        ExpFactor = parser.ReadOffset< float >( 8 );
        ExpReward = parser.ReadOffset< uint >( 12 );
        GilReward = parser.ReadOffset< uint >( 16 );
        LeveRewardItem = new LazyRow< LeveRewardItem >( gameData, parser.ReadOffset< ushort >( 20 ), language );
        JournalGenre = new LazyRow< JournalGenre >( gameData, parser.ReadOffset< uint >( 24 ), language );
        LevelLevemete = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( 28 ), language );
        LevelStart = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( 32 ), language );
        LeveClient = new LazyRow< LeveClient >( gameData, parser.ReadOffset< int >( 36 ), language );
        LeveAssignmentType = new LazyRow< LeveAssignmentType >( gameData, parser.ReadOffset< int >( 40 ), language );
        Town = new LazyRow< Town >( gameData, parser.ReadOffset< int >( 44 ), language );
        Evaluation = parser.ReadOffset< int >( 48 );
        PlaceNameStart = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 52 ), language );
        PlaceNameIssued = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 56 ), language );
        Unknown17 = parser.ReadOffset< int >( 60 );
        PlaceNameStartZone = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 64 ), language );
        IconCityState = parser.ReadOffset< int >( 68 );
        DataId = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 72 ), language, "CraftLeve", "CompanyLeve", "GatheringLeve", "BattleLeve" );
        IconIssuer = parser.ReadOffset< int >( 76 );
        ClassJobLevel = parser.ReadOffset< ushort >( 80 );
        FishingSpot = new LazyRow< FishingSpot >( gameData, parser.ReadOffset< ushort >( 82 ), language );
        BGM = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 84 ), language );
        Unknown3 = parser.ReadOffset< byte >( 86 );
        TimeLimit = parser.ReadOffset< byte >( 87 );
        AllowanceCost = parser.ReadOffset< byte >( 88 );
        Unknown13 = parser.ReadOffset< byte >( 89 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 90 ), language );
        MaxDifficulty = parser.ReadOffset< byte >( 91 );
        LeveVfx = new LazyRow< LeveVfx >( gameData, parser.ReadOffset< byte >( 92 ), language );
        LeveVfxFrame = new LazyRow< LeveVfx >( gameData, parser.ReadOffset< byte >( 93 ), language );
        Unknown14 = parser.ReadOffset< bool >( 94 );
        CanCancel = parser.ReadOffset< bool >( 94, 2 );
        LockedLeve = parser.ReadOffset< bool >( 94, 4 );
        

    }
}
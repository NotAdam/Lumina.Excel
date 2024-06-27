// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Leve", columnHash: 0xdab38bf5 )]
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
    public LazyRow< PlaceName > PlaceNameStart { get; private set; }
    public LazyRow< PlaceName > PlaceNameIssued { get; private set; }
    public LazyRow< PlaceName > PlaceNameStartZone { get; private set; }
    public int IconCityState { get; private set; }
    public ILazyRow DataId { get; private set; }
    public int IconIssuer { get; private set; }
    public ushort ClassJobLevel { get; private set; }
    public LazyRow< FishingSpot > FishingSpot { get; private set; }
    public LazyRow< BGM > BGM { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte TimeLimit { get; private set; }
    public byte AllowanceCost { get; private set; }
    public byte Unknown2 { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte MaxDifficulty { get; private set; }
    public LazyRow< LeveVfx > LeveVfx { get; private set; }
    public LazyRow< LeveVfx > LeveVfxFrame { get; private set; }
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
        PlaceNameStart = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 48 ), language );
        PlaceNameIssued = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 52 ), language );
        PlaceNameStartZone = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 56 ), language );
        IconCityState = parser.ReadOffset< int >( 60 );
        DataId = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 64 ), language, "CraftLeve", "CompanyLeve", "GatheringLeve", "BattleLeve" );
        IconIssuer = parser.ReadOffset< int >( 68 );
        ClassJobLevel = parser.ReadOffset< ushort >( 72 );
        FishingSpot = new LazyRow< FishingSpot >( gameData, parser.ReadOffset< ushort >( 74 ), language );
        BGM = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 76 ), language );
        Unknown1 = parser.ReadOffset< byte >( 78 );
        TimeLimit = parser.ReadOffset< byte >( 79 );
        AllowanceCost = parser.ReadOffset< byte >( 80 );
        Unknown2 = parser.ReadOffset< byte >( 81 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 82 ), language );
        MaxDifficulty = parser.ReadOffset< byte >( 83 );
        LeveVfx = new LazyRow< LeveVfx >( gameData, parser.ReadOffset< byte >( 84 ), language );
        LeveVfxFrame = new LazyRow< LeveVfx >( gameData, parser.ReadOffset< byte >( 85 ), language );
        CanCancel = parser.ReadOffset< bool >( 86 );
        LockedLeve = parser.ReadOffset< bool >( 86, 2 );
        

    }
}
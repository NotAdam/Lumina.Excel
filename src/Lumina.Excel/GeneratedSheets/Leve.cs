// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Leve", columnHash: 0xdab38bf5 )]
    public partial class Leve : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public LazyRow< LeveClient > LeveClient { get; set; }
        public byte Unknown3 { get; set; }
        public LazyRow< LeveAssignmentType > LeveAssignmentType { get; set; }
        public LazyRow< Town > Town { get; set; }
        public ushort ClassJobLevel { get; set; }
        public byte TimeLimit { get; set; }
        public byte AllowanceCost { get; set; }
        public LazyRow< PlaceName > PlaceNameStart { get; set; }
        public LazyRow< PlaceName > PlaceNameIssued { get; set; }
        public LazyRow< FishingSpot > FishingSpot { get; set; }
        public byte Unknown12 { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public LazyRow< JournalGenre > JournalGenre { get; set; }
        public LazyRow< PlaceName > PlaceNameStartZone { get; set; }
        public int IconCityState { get; set; }
        public int DataId { get; set; }
        public bool CanCancel { get; set; }
        public byte MaxDifficulty { get; set; }
        public float ExpFactor { get; set; }
        public uint ExpReward { get; set; }
        public uint GilReward { get; set; }
        public LazyRow< LeveRewardItem > LeveRewardItem { get; set; }
        public LazyRow< LeveVfx > LeveVfx { get; set; }
        public LazyRow< LeveVfx > LeveVfxFrame { get; set; }
        public LazyRow< Level > LevelLevemete { get; set; }
        public int IconIssuer { get; set; }
        public bool LockedLeve { get; set; }
        public LazyRow< Level > LevelStart { get; set; }
        public LazyRow< BGM > BGM { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            LeveClient = new LazyRow< LeveClient >( gameData, parser.ReadColumn< int >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            LeveAssignmentType = new LazyRow< LeveAssignmentType >( gameData, parser.ReadColumn< int >( 4 ), language );
            Town = new LazyRow< Town >( gameData, parser.ReadColumn< int >( 5 ), language );
            ClassJobLevel = parser.ReadColumn< ushort >( 6 );
            TimeLimit = parser.ReadColumn< byte >( 7 );
            AllowanceCost = parser.ReadColumn< byte >( 8 );
            PlaceNameStart = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 9 ), language );
            PlaceNameIssued = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 10 ), language );
            FishingSpot = new LazyRow< FishingSpot >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 13 ), language );
            JournalGenre = new LazyRow< JournalGenre >( gameData, parser.ReadColumn< uint >( 14 ), language );
            PlaceNameStartZone = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 15 ), language );
            IconCityState = parser.ReadColumn< int >( 16 );
            DataId = parser.ReadColumn< int >( 17 );
            CanCancel = parser.ReadColumn< bool >( 18 );
            MaxDifficulty = parser.ReadColumn< byte >( 19 );
            ExpFactor = parser.ReadColumn< float >( 20 );
            ExpReward = parser.ReadColumn< uint >( 21 );
            GilReward = parser.ReadColumn< uint >( 22 );
            LeveRewardItem = new LazyRow< LeveRewardItem >( gameData, parser.ReadColumn< ushort >( 23 ), language );
            LeveVfx = new LazyRow< LeveVfx >( gameData, parser.ReadColumn< byte >( 24 ), language );
            LeveVfxFrame = new LazyRow< LeveVfx >( gameData, parser.ReadColumn< byte >( 25 ), language );
            LevelLevemete = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 26 ), language );
            IconIssuer = parser.ReadColumn< int >( 27 );
            LockedLeve = parser.ReadColumn< bool >( 28 );
            LevelStart = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 29 ), language );
            BGM = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 30 ), language );
        }
    }
}
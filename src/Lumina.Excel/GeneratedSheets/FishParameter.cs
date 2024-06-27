// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishParameter", columnHash: 0x7c44029d )]
    public partial class FishParameter : ExcelRow
    {
        
        public SeString Text { get; set; }
        public SeString Unknown1 { get; set; }
        public SeString Unknown2 { get; set; }
        public SeString Unknown3 { get; set; }
        public int Item { get; set; }
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; set; }
        public byte OceanStars { get; set; }
        public ushort Unknown7 { get; set; }
        public bool IsHidden { get; set; }
        public LazyRow< FishingRecordType > FishingRecordType { get; set; }
        public LazyRow< FishingSpot > FishingSpot { get; set; }
        public LazyRow< GatheringSubCategory > GatheringSubCategory { get; set; }
        public bool IsInLog { get; set; }
        public uint AchievementCredit { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Text = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
            Item = parser.ReadColumn< int >( 4 );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            OceanStars = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            IsHidden = parser.ReadColumn< bool >( 8 );
            FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadColumn< byte >( 9 ), language );
            FishingSpot = new LazyRow< FishingSpot >( gameData, parser.ReadColumn< ushort >( 10 ), language );
            GatheringSubCategory = new LazyRow< GatheringSubCategory >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            IsInLog = parser.ReadColumn< bool >( 12 );
            AchievementCredit = parser.ReadColumn< uint >( 13 );
        }
    }
}
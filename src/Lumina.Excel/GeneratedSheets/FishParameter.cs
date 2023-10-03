// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishParameter", columnHash: 0x9b87b2f1 )]
    public partial class FishParameter : ExcelRow
    {
        
        public SeString Text { get; set; }
        public int Item { get; set; }
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; set; }
        public byte OceanStars { get; set; }
        public ushort Unknown4 { get; set; }
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
            Item = parser.ReadColumn< int >( 1 );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            OceanStars = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            IsHidden = parser.ReadColumn< bool >( 5 );
            FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadColumn< byte >( 6 ), language );
            FishingSpot = new LazyRow< FishingSpot >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            GatheringSubCategory = new LazyRow< GatheringSubCategory >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            IsInLog = parser.ReadColumn< bool >( 9 );
            AchievementCredit = parser.ReadColumn< uint >( 10 );
        }
    }
}
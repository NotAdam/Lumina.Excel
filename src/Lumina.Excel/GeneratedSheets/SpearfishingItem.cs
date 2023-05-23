// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingItem", columnHash: 0x0d6bd3d9 )]
    public partial class SpearfishingItem : ExcelRow
    {
        
        public SeString Description { get; set; }
        public LazyRow< Item > Item { get; set; }
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; set; }
        public bool Unknown3 { get; set; }
        public LazyRow< FishingRecordType > FishingRecordType { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public ushort Unknown6 { get; set; }
        public bool IsVisible { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Description = parser.ReadColumn< SeString >( 0 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 1 ), language );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadColumn< byte >( 4 ), language );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            IsVisible = parser.ReadColumn< bool >( 7 );
        }
    }
}
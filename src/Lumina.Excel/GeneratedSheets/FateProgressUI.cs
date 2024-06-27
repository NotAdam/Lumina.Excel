// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateProgressUI", columnHash: 0xbccd5130 )]
    public partial class FateProgressUI : ExcelRow
    {
        
        public LazyRow< TerritoryType > Location { get; set; }
        public byte ReqFatesToRank2 { get; set; }
        public byte ReqFatesToRank3 { get; set; }
        public byte ReqFatesToRank4 { get; set; }
        public sbyte Unknown4 { get; set; }
        public byte DisplayOrder { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Location = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< int >( 0 ), language );
            ReqFatesToRank2 = parser.ReadColumn< byte >( 1 );
            ReqFatesToRank3 = parser.ReadColumn< byte >( 2 );
            ReqFatesToRank4 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            DisplayOrder = parser.ReadColumn< byte >( 5 );
        }
    }
}
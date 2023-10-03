// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIKeyItem", columnHash: 0xfc266fec )]
    public partial class MJIKeyItem : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public byte Sort { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Sort = parser.ReadColumn< byte >( 1 );
        }
    }
}
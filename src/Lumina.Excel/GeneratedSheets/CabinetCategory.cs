// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CabinetCategory", columnHash: 0x0d4b5075 )]
    public partial class CabinetCategory : ExcelRow
    {
        
        public byte MenuOrder { get; set; }
        public byte HideOrder { get; set; }
        public int Icon { get; set; }
        public LazyRow< Addon > Category { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MenuOrder = parser.ReadColumn< byte >( 0 );
            HideOrder = parser.ReadColumn< byte >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            Category = new LazyRow< Addon >( gameData, parser.ReadColumn< int >( 3 ), language );
        }
    }
}
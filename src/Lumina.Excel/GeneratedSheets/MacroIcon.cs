// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MacroIcon", columnHash: 0xf8ab135e )]
    public partial class MacroIcon : ExcelRow
    {
        
        public int Icon { get; set; }
        public ushort Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Marker", columnHash: 0x30ebf383 )]
    public partial class Marker : ExcelRow
    {
        
        public int Icon { get; set; }
        public byte Unknown1 { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
        }
    }
}
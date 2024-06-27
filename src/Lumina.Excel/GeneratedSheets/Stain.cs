// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Stain", columnHash: 0x97c471bd )]
    public partial class Stain : ExcelRow
    {
        
        public uint Color { get; set; }
        public byte Shade { get; set; }
        public byte SubOrder { get; set; }
        public SeString Name { get; set; }
        public SeString Name2 { get; set; }
        public bool Unknown5 { get; set; }
        public bool Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Color = parser.ReadColumn< uint >( 0 );
            Shade = parser.ReadColumn< byte >( 1 );
            SubOrder = parser.ReadColumn< byte >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
            Name2 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MultipleHelp", columnHash: 0x49c8f3d3 )]
    public partial class MultipleHelp : ExcelRow
    {
        
        public ushort Unknown0 { get; set; }
        public SeString Unknown1 { get; set; }
        public SeString Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
        }
    }
}
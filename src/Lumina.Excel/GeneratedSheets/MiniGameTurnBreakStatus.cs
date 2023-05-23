// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MiniGameTurnBreakStatus", columnHash: 0x057e61f4 )]
    public partial class MiniGameTurnBreakStatus : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public SeString Unknown4 { get; set; }
        public SeString Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
        }
    }
}
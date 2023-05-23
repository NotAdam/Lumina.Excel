// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MiniGameTurnBreakPopOffset", columnHash: 0x522ed050 )]
    public partial class MiniGameTurnBreakPopOffset : ExcelRow
    {
        
        public sbyte Unknown0 { get; set; }
        public sbyte Unknown1 { get; set; }
        public sbyte Unknown2 { get; set; }
        public sbyte Unknown3 { get; set; }
        public sbyte Unknown4 { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Unknown6 { get; set; }
        public sbyte Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< sbyte >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Unknown2 = parser.ReadColumn< sbyte >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
        }
    }
}
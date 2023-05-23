// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MiniGameTurnBreakPop", columnHash: 0x00a94fea )]
    public partial class MiniGameTurnBreakPop : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
        }
    }
}
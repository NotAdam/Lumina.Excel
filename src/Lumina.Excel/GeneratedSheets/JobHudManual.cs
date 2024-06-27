// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JobHudManual", columnHash: 0xa5aa10b4 )]
    public partial class JobHudManual : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public LazyRow< Action > Action { get; set; }
        public byte Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public LazyRow< Guide > Guide { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Action = new LazyRow< Action >( gameData, parser.ReadColumn< uint >( 3 ), language );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Guide = new LazyRow< Guide >( gameData, parser.ReadColumn< ushort >( 6 ), language );
        }
    }
}
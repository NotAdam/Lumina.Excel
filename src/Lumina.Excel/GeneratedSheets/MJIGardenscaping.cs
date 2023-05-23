// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIGardenscaping", columnHash: 0x3554ffd5 )]
    public partial class MJIGardenscaping : ExcelRow
    {
        
        public byte Level { get; set; }
        public int Unknown1 { get; set; }
        public int Unknown2 { get; set; }
        public int Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public LazyRow< Item > Item { get; set; }
        public ushort Unknown6 { get; set; }
        public int Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Level = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 5 ), language );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< int >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
        }
    }
}
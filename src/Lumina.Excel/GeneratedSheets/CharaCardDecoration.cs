// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardDecoration", columnHash: 0x33648d46 )]
    public partial class CharaCardDecoration : ExcelRow
    {
        
        public byte Category { get; set; }
        public byte SubType { get; set; }
        public int Image { get; set; }
        public byte Unknown3 { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public ushort Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public ushort SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = parser.ReadColumn< byte >( 0 );
            SubType = parser.ReadColumn< byte >( 1 );
            Image = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            SortKey = parser.ReadColumn< ushort >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
        }
    }
}
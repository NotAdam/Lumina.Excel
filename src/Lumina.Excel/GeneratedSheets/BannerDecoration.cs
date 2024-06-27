// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerDecoration", columnHash: 0xdf1d09d9 )]
    public partial class BannerDecoration : ExcelRow
    {
        
        public int Image { get; set; }
        public int Icon { get; set; }
        public byte Unknown2 { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public ushort Unknown4 { get; set; }
        public ushort Unknown5 { get; set; }
        public ushort SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< int >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            SortKey = parser.ReadColumn< ushort >( 6 );
            Name = parser.ReadColumn< SeString >( 7 );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardDecoration", columnHash: 0xe7d0ab1d )]
    public partial class CharaCardDecoration : ExcelRow
    {
        
        public byte Category { get; set; }
        public byte Unknown1 { get; set; }
        public int Image { get; set; }
        public byte Unknown3 { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public byte Unknown5 { get; set; }
        public ushort SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Image = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            SortKey = parser.ReadColumn< ushort >( 6 );
            Name = parser.ReadColumn< SeString >( 7 );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIDisposalShopItem", columnHash: 0xece42e62 )]
    public partial class MJIDisposalShopItem : ExcelRow
    {
        
        public LazyRow< MJIItemPouch > Item { get; set; }
        public byte Currency { get; set; }
        public ushort Count { get; set; }
        public LazyRow< MJIDisposalShopUICategory > Category { get; set; }
        public byte Sort { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< MJIItemPouch >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Currency = parser.ReadColumn< byte >( 1 );
            Count = parser.ReadColumn< ushort >( 2 );
            Category = new LazyRow< MJIDisposalShopUICategory >( gameData, parser.ReadColumn< byte >( 3 ), language );
            Sort = parser.ReadColumn< byte >( 4 );
        }
    }
}
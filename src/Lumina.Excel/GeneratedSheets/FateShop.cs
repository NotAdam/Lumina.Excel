// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateShop", columnHash: 0x58d1a3e4 )]
    public partial class FateShop : ExcelRow
    {
        
        public LazyRow< SpecialShop >[] SpecialShop { get; set; }
        public LazyRow< DefaultTalk >[] DefaultTalk { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SpecialShop = new LazyRow< SpecialShop >[ 3 ];
            for( var i = 0; i < 3; i++ )
                SpecialShop[ i ] = new LazyRow< SpecialShop >( gameData, parser.ReadColumn< uint >( 0 + i ), language );
            DefaultTalk = new LazyRow< DefaultTalk >[ 10 ];
            for( var i = 0; i < 10; i++ )
                DefaultTalk[ i ] = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 3 + i ), language );
        }
    }
}
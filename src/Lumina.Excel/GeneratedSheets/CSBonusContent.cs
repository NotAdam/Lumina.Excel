// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CSBonusContent", columnHash: 0xf8d2be91 )]
    public partial class CSBonusContent : ExcelRow
    {
        
        public LazyRow< CSBonusContentType > ContentType { get; set; }
        public LazyRow< CSBonusContentIdentifier >[] Content { get; set; }
        public ushort[] Score { get; set; }
        public byte[] RewardCount { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ContentType = new LazyRow< CSBonusContentType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Content = new LazyRow< CSBonusContentIdentifier >[ 2 ];
            for( var i = 0; i < 2; i++ )
                Content[ i ] = new LazyRow< CSBonusContentIdentifier >( gameData, parser.ReadColumn< ushort >( 1 + i ), language );
            Score = new ushort[ 6 ];
            for( var i = 0; i < 6; i++ )
                Score[ i ] = parser.ReadColumn< ushort >( 3 + i );
            RewardCount = new byte[ 5 ];
            for( var i = 0; i < 5; i++ )
                RewardCount[ i ] = parser.ReadColumn< byte >( 9 + i );
        }
    }
}
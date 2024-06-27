// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CSBonusContentType", columnHash: 0x9ff5145f )]
    public partial class CSBonusContentType : ExcelRow
    {
        
        public LazyRow< ContentType > ContentType { get; set; }
        public LazyRow< Addon >[] Text { get; set; }
        public uint Image { get; set; }
        public bool Unknown6 { get; set; }
        public LazyRow< Quest > UnlockQuest { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ContentType = new LazyRow< ContentType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Text = new LazyRow< Addon >[ 4 ];
            for( var i = 0; i < 4; i++ )
                Text[ i ] = new LazyRow< Addon >( gameData, parser.ReadColumn< uint >( 1 + i ), language );
            Image = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 7 ), language );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
        }
    }
}
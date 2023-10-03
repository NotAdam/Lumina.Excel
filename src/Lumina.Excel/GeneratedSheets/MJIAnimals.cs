// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIAnimals", columnHash: 0xeae74967 )]
    public partial class MJIAnimals : ExcelRow
    {
        
        public LazyRow< BNpcBase > BNpcBase { get; set; }
        public byte Size { get; set; }
        public byte Rarity { get; set; }
        public byte Sort { get; set; }
        public LazyRow< Item >[] Reward { get; set; }
        public int Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BNpcBase = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Size = parser.ReadColumn< byte >( 1 );
            Rarity = parser.ReadColumn< byte >( 2 );
            Sort = parser.ReadColumn< byte >( 3 );
            Reward = new LazyRow< Item >[ 2 ];
            for( var i = 0; i < 2; i++ )
                Reward[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 4 + i ), language );
            Icon = parser.ReadColumn< int >( 6 );
        }
    }
}
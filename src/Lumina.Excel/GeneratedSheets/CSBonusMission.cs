// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CSBonusMission", columnHash: 0x2020acf6 )]
    public partial class CSBonusMission : ExcelRow
    {
        
        public LazyRow< CSBonusContent >[] Content { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Content = new LazyRow< CSBonusContent >[ 2 ];
            for( var i = 0; i < 2; i++ )
                Content[ i ] = new LazyRow< CSBonusContent >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
        }
    }
}
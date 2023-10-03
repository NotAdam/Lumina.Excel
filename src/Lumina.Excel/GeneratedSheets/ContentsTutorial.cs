// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentsTutorial", columnHash: 0x4f69f67d )]
    public partial class ContentsTutorial : ExcelRow
    {
        
        public LazyRow< ContentsTutorialPage >[] Page { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Page = new LazyRow< ContentsTutorialPage >[ 8 ];
            for( var i = 0; i < 8; i++ )
                Page[ i ] = new LazyRow< ContentsTutorialPage >( gameData, parser.ReadColumn< int >( 0 + i ), language );
            Name = parser.ReadColumn< SeString >( 8 );
            Description = parser.ReadColumn< SeString >( 9 );
        }
    }
}
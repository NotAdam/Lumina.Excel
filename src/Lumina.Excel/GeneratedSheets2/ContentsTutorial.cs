// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentsTutorial", columnHash: 0x85313f44 )]
public partial class ContentsTutorial : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public LazyRow< ContentsTutorialPage >[] Page { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Page = new LazyRow< ContentsTutorialPage >[8];
        for (int i = 0; i < 8; i++)
        	Page[i] = new LazyRow< ContentsTutorialPage >( gameData, parser.ReadOffset< int >( (ushort) ( 8 + i * 4 ) ), language );
        

    }
}
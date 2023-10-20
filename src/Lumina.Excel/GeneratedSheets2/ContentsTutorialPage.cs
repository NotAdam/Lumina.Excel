// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentsTutorialPage", columnHash: 0x0c8db36c )]
public partial class ContentsTutorialPage : ExcelRow
{
    
    public SeString Description { get; private set; }
    public int Image { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Description = parser.ReadOffset< SeString >( 0 );
        Image = parser.ReadOffset< int >( 4 );
        

    }
}
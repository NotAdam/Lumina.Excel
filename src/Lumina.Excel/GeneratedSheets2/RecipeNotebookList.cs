// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RecipeNotebookList", columnHash: 0xa067051f )]
public partial class RecipeNotebookList : ExcelRow
{
    
    public LazyRow< Recipe >[] Recipe { get; private set; }
    public byte Count { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Recipe = new LazyRow< Recipe >[160];
        for (int i = 0; i < 160; i++)
        	Recipe[i] = new LazyRow< Recipe >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        Count = parser.ReadOffset< byte >( 640 );
        

    }
}
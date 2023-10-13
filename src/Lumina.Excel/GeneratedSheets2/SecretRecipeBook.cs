// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SecretRecipeBook", columnHash: 0x0c8db36c )]
public partial class SecretRecipeBook : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        

    }
}
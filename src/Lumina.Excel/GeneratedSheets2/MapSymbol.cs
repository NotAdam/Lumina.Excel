// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MapSymbol", columnHash: 0xe7e370e4 )]
public partial class MapSymbol : ExcelRow
{
    
    public int Icon { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public bool DisplayNavi { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< int >( 0 );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 4 ), language );
        DisplayNavi = parser.ReadOffset< bool >( 8 );
        

    }
}
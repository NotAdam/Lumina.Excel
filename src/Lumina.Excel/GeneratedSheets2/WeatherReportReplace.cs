// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeatherReportReplace", columnHash: 0x2020acf6 )]
public partial class WeatherReportReplace : ExcelRow
{
    
    public LazyRow< PlaceName > PlaceNameSub { get; private set; }
    public LazyRow< PlaceName > PlaceNameParent { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        PlaceNameSub = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        PlaceNameParent = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        

    }
}
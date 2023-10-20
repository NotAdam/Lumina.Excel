// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboRaceWeather", columnHash: 0xfaedad07 )]
public partial class ChocoboRaceWeather : ExcelRow
{
    
    public LazyRow< Weather > WeatherType1 { get; private set; }
    public LazyRow< Weather > WeatherType2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        WeatherType1 = new LazyRow< Weather >( gameData, parser.ReadOffset< int >( 0 ), language );
        WeatherType2 = new LazyRow< Weather >( gameData, parser.ReadOffset< int >( 4 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeatherGroup", columnHash: 0xfaedad07 )]
public partial class WeatherGroup : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public LazyRow< WeatherRate > WeatherRate { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        WeatherRate = new LazyRow< WeatherRate >( gameData, parser.ReadOffset< int >( 4 ), language );
        

    }
}
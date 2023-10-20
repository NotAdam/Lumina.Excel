// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeatherRate", columnHash: 0x474abce2 )]
public partial class WeatherRate : ExcelRow
{
    
    public LazyRow< Weather >[] Weather { get; private set; }
    public byte[] Rate { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Weather = new LazyRow< Weather >[8];
        for (int i = 0; i < 8; i++)
        	Weather[i] = new LazyRow< Weather >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        Rate = new byte[8];
        for (int i = 0; i < 8; i++)
        	Rate[i] = parser.ReadOffset< byte >( 32 + i * 1 );
        

    }
}
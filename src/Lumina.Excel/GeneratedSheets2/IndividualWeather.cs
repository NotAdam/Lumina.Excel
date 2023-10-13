// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "IndividualWeather", columnHash: 0x4532afe5 )]
public partial class IndividualWeather : ExcelRow
{
    public struct IndividualWeatherDataStruct
    {
    	public LazyRow< Quest > Quest { get; internal set; }
    	public uint Unknown1 { get; internal set; }
    	public LazyRow< Weather > Weather { get; internal set; }
    	public byte Unknown2 { get; internal set; }
    }
    
    public IndividualWeatherDataStruct[] IndividualWeatherData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        IndividualWeatherData = new IndividualWeatherDataStruct[7];
        for (int i = 0; i < 7; i++)
        {
        	IndividualWeatherData[i].Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( (ushort) (i * 12 + 0) ), language );
        	IndividualWeatherData[i].Unknown1 = parser.ReadOffset< uint >( (ushort) (i * 12 + 4));
        	IndividualWeatherData[i].Weather = new LazyRow< Weather >( gameData, parser.ReadOffset< byte >( (ushort) (i * 12 + 8) ), language );
        	IndividualWeatherData[i].Unknown2 = parser.ReadOffset< byte >( (ushort) (i * 12 + 9));
        }
        

    }
}
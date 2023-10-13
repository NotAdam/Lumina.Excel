// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "LotteryExchangeShop", columnHash: 0xfd7b4ce5 )]
public partial class LotteryExchangeShop : ExcelRow
{
    public struct LotteryExchangeParamsStruct
    {
    	public uint AmountAccepted { get; internal set; }
    	public LazyRow< Item > ItemAccepted { get; internal set; }
    	public byte Unknown65 { get; internal set; }
    	public byte Unknown97 { get; internal set; }
    }
    
    public SeString Name { get; private set; }
    public LotteryExchangeParamsStruct[] LotteryExchangeParams { get; private set; }
    public SeString Script { get; private set; }
    public LazyRow< LogMessage >[] LogMessage { get; private set; }
    public bool Unknown133 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        LotteryExchangeParams = new LotteryExchangeParamsStruct[32];
        for (int i = 0; i < 32; i++)
        {
        	LotteryExchangeParams[i].AmountAccepted = parser.ReadOffset< uint >( (ushort) (i * 12 + 4));
        	LotteryExchangeParams[i].ItemAccepted = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) (i * 12 + 8) ), language );
        	LotteryExchangeParams[i].Unknown65 = parser.ReadOffset< byte >( (ushort) (i * 12 + 12));
        	LotteryExchangeParams[i].Unknown97 = parser.ReadOffset< byte >( (ushort) (i * 12 + 13));
        }
        Script = parser.ReadOffset< SeString >( 388 );
        LogMessage = new LazyRow< LogMessage >[3];
        for (int i = 0; i < 3; i++)
        	LogMessage[i] = new LazyRow< LogMessage >( gameData, parser.ReadOffset< uint >( (ushort) ( 392 + i * 4 ) ), language );
        Unknown133 = parser.ReadOffset< bool >( 404 );
        

    }
}
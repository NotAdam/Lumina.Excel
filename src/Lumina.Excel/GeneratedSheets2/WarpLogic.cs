// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WarpLogic", columnHash: 0x78e83215 )]
public partial class WarpLogic : ExcelRow
{
    public struct WarpParamsStruct
    {
    	public SeString Function { get; internal set; }
    	public ILazyRow Argument { get; internal set; }
    }
    
    public WarpParamsStruct[] WarpParams { get; private set; }
    public SeString Question { get; private set; }
    public SeString ResponseYes { get; private set; }
    public SeString ResponseNo { get; private set; }
    public SeString WarpName { get; private set; }
    public uint Unknown0 { get; private set; }
    public bool CanSkipCutscene { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        WarpParams = new WarpParamsStruct[10];
        for (int i = 0; i < 10; i++)
        {
        	WarpParams[i].Function = parser.ReadOffset< SeString >( (ushort) (i * 8 + 0));
        	WarpParams[i].Argument = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( i * 8 + 4 ), language, "HowTo", "Item", "Quest" );
        }
        Question = parser.ReadOffset< SeString >( 80 );
        ResponseYes = parser.ReadOffset< SeString >( 84 );
        ResponseNo = parser.ReadOffset< SeString >( 88 );
        WarpName = parser.ReadOffset< SeString >( 92 );
        Unknown0 = parser.ReadOffset< uint >( 96 );
        CanSkipCutscene = parser.ReadOffset< bool >( 100 );
        

    }
}
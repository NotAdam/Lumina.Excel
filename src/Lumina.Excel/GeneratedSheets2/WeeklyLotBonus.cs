// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeeklyLotBonus", columnHash: 0x69ba3687 )]
public partial class WeeklyLotBonus : ExcelRow
{
    public struct WeeklyLotBonusParamStruct
    {
    	public ushort Unknown0 { get; internal set; }
    	public LazyRow< WeeklyLotBonusThreshold > WeeklyLotBonusThreshold { get; internal set; }
    	public byte Unknown1 { get; internal set; }
    }
    
    public WeeklyLotBonusParamStruct[] WeeklyLotBonusParam { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        WeeklyLotBonusParam = new WeeklyLotBonusParamStruct[32];
        for (int i = 0; i < 32; i++)
        {
        	WeeklyLotBonusParam[i].Unknown0 = parser.ReadOffset< ushort >( (ushort) (i * 4 + 0));
        	WeeklyLotBonusParam[i].WeeklyLotBonusThreshold = new LazyRow< WeeklyLotBonusThreshold >( gameData, parser.ReadOffset< byte >( (ushort) (i * 4 + 2) ), language );
        	WeeklyLotBonusParam[i].Unknown1 = parser.ReadOffset< byte >( (ushort) (i * 4 + 3));
        }
        

    }
}
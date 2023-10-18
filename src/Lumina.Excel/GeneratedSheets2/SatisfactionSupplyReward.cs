// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SatisfactionSupplyReward", columnHash: 0xc81395f9 )]
public partial class SatisfactionSupplyReward : ExcelRow
{
    public struct SatisfactionSupplyRewardDataStruct
    {
    	public ushort RewardCurrency { get; internal set; }
    	public ushort QuantityLow { get; internal set; }
    	public ushort QuantityMid { get; internal set; }
    	public ushort QuantityHigh { get; internal set; }
    }
    
    public SatisfactionSupplyRewardDataStruct[] SatisfactionSupplyRewardData { get; private set; }
    public ushort SatisfactionLow { get; private set; }
    public ushort SatisfactionMid { get; private set; }
    public ushort SatisfactionHigh { get; private set; }
    public ushort GilLow { get; private set; }
    public ushort GilMid { get; private set; }
    public ushort GilHigh { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SatisfactionSupplyRewardData = new SatisfactionSupplyRewardDataStruct[2];
        for (int i = 0; i < 2; i++)
        {
        	SatisfactionSupplyRewardData[i].RewardCurrency = parser.ReadOffset< ushort >( (ushort) (i * 8 + 0));
        	SatisfactionSupplyRewardData[i].QuantityLow = parser.ReadOffset< ushort >( (ushort) (i * 8 + 2));
        	SatisfactionSupplyRewardData[i].QuantityMid = parser.ReadOffset< ushort >( (ushort) (i * 8 + 4));
        	SatisfactionSupplyRewardData[i].QuantityHigh = parser.ReadOffset< ushort >( (ushort) (i * 8 + 6));
        }
        SatisfactionLow = parser.ReadOffset< ushort >( 16 );
        SatisfactionMid = parser.ReadOffset< ushort >( 18 );
        SatisfactionHigh = parser.ReadOffset< ushort >( 20 );
        GilLow = parser.ReadOffset< ushort >( 22 );
        GilMid = parser.ReadOffset< ushort >( 24 );
        GilHigh = parser.ReadOffset< ushort >( 26 );
        Unknown0 = parser.ReadOffset< byte >( 28 );
        Unknown1 = parser.ReadOffset< byte >( 29 );
        

    }
}
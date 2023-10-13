// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDCrafterSupply", columnHash: 0xa04b4cc9 )]
public partial class HWDCrafterSupply : ExcelRow
{
    public struct HWDCrafterSupplyParamsStruct
    {
    	public LazyRow< Item > ItemTradeIn { get; internal set; }
    	public ushort BaseCollectableRating { get; internal set; }
    	public ushort MidCollectableRating { get; internal set; }
    	public ushort HighCollectableRating { get; internal set; }
    	public LazyRow< HWDCrafterSupplyReward > BaseCollectableReward { get; internal set; }
    	public LazyRow< HWDCrafterSupplyReward > MidCollectableReward { get; internal set; }
    	public LazyRow< HWDCrafterSupplyReward > HighCollectableReward { get; internal set; }
    	public LazyRow< HWDCrafterSupplyReward > BaseCollectableRewardPostPhase { get; internal set; }
    	public LazyRow< HWDCrafterSupplyReward > MidCollectableRewardPostPhase { get; internal set; }
    	public LazyRow< HWDCrafterSupplyReward > HighCollectableRewardPostPhase { get; internal set; }
    	public byte Level { get; internal set; }
    	public byte LevelMax { get; internal set; }
    	public byte Unknown1 { get; internal set; }
    	public LazyRow< HWDCrafterSupplyTerm > TermName { get; internal set; }
    }
    
    public HWDCrafterSupplyParamsStruct[] HWDCrafterSupplyParams { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        HWDCrafterSupplyParams = new HWDCrafterSupplyParamsStruct[23];
        for (int i = 0; i < 23; i++)
        {
        	HWDCrafterSupplyParams[i].ItemTradeIn = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) (i * 28 + 0) ), language );
        	HWDCrafterSupplyParams[i].BaseCollectableRating = parser.ReadOffset< ushort >( (ushort) (i * 28 + 4));
        	HWDCrafterSupplyParams[i].MidCollectableRating = parser.ReadOffset< ushort >( (ushort) (i * 28 + 6));
        	HWDCrafterSupplyParams[i].HighCollectableRating = parser.ReadOffset< ushort >( (ushort) (i * 28 + 8));
        	HWDCrafterSupplyParams[i].BaseCollectableReward = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 28 + 10) ), language );
        	HWDCrafterSupplyParams[i].MidCollectableReward = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 28 + 12) ), language );
        	HWDCrafterSupplyParams[i].HighCollectableReward = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 28 + 14) ), language );
        	HWDCrafterSupplyParams[i].BaseCollectableRewardPostPhase = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 28 + 16) ), language );
        	HWDCrafterSupplyParams[i].MidCollectableRewardPostPhase = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 28 + 18) ), language );
        	HWDCrafterSupplyParams[i].HighCollectableRewardPostPhase = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 28 + 20) ), language );
        	HWDCrafterSupplyParams[i].Level = parser.ReadOffset< byte >( (ushort) (i * 28 + 22));
        	HWDCrafterSupplyParams[i].LevelMax = parser.ReadOffset< byte >( (ushort) (i * 28 + 23));
        	HWDCrafterSupplyParams[i].Unknown1 = parser.ReadOffset< byte >( (ushort) (i * 28 + 24));
        	HWDCrafterSupplyParams[i].TermName = new LazyRow< HWDCrafterSupplyTerm >( gameData, parser.ReadOffset< byte >( (ushort) (i * 28 + 25) ), language );
        }
        

    }
}
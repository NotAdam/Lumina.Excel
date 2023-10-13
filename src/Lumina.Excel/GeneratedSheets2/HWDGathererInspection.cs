// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDGathererInspection", columnHash: 0xad239733 )]
public partial class HWDGathererInspection : ExcelRow
{
    public struct HWDGathererInspectionDataStruct
    {
    	public LazyRow< GatheringItem > RequiredItem { get; internal set; }
    	public LazyRow< FishParameter > FishParameter { get; internal set; }
    	public LazyRow< Item > ItemReceived { get; internal set; }
    	public LazyRow< HWDGathererInspectionReward >[] Reward { get; internal set; }
    	public byte AmountRequired { get; internal set; }
    	public LazyRow< HWDGathereInspectTerm > Phase { get; internal set; }
    }
    
    public HWDGathererInspectionDataStruct[] HWDGathererInspectionData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        HWDGathererInspectionData = new HWDGathererInspectionDataStruct[79];
        for (int i = 0; i < 79; i++)
        {
        	HWDGathererInspectionData[i].RequiredItem = new LazyRow< GatheringItem >( gameData, parser.ReadOffset< uint >( (ushort) (i * 20 + 0) ), language );
        	HWDGathererInspectionData[i].FishParameter = new LazyRow< FishParameter >( gameData, parser.ReadOffset< uint >( (ushort) (i * 20 + 4) ), language );
        	HWDGathererInspectionData[i].ItemReceived = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) (i * 20 + 8) ), language );
        	HWDGathererInspectionData[i].Reward = new LazyRow< HWDGathererInspectionReward >[2];
        	for (int RewardIndexer = 0; RewardIndexer < 2; RewardIndexer++)
        		HWDGathererInspectionData[i].Reward[RewardIndexer] = new LazyRow< HWDGathererInspectionReward >( gameData, parser.ReadOffset< ushort >( i * 20 +  12 + RewardIndexer * 2 ), language );
        	HWDGathererInspectionData[i].AmountRequired = parser.ReadOffset< byte >( (ushort) (i * 20 + 16));
        	HWDGathererInspectionData[i].Phase = new LazyRow< HWDGathereInspectTerm >( gameData, parser.ReadOffset< byte >( (ushort) (i * 20 + 17) ), language );
        }
        

    }
}
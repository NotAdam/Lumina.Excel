// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HugeCraftworksNpc", columnHash: 0xc1d2986a )]
public partial class HugeCraftworksNpc : ExcelRow
{
    public struct HugeCraftworksTurnInParamStruct
    {
    	public LazyRow< Item > RequestedItem { get; internal set; }
    	public ushort Unknown0 { get; internal set; }
    	public byte RequestedQuantity { get; internal set; }
    	public byte Unknown1 { get; internal set; }
    	public byte Unknown2 { get; internal set; }
    	public byte Unknown3 { get; internal set; }
    	public byte Unknown4 { get; internal set; }
    	public byte Unknown5 { get; internal set; }
    	public bool Unknown6 { get; internal set; }
    }
    public struct HugeCraftworksRewardParamStruct
    {
    	public LazyRow< Item >[] RewardItem { get; internal set; }
    	public byte[] RewardQuantity { get; internal set; }
    	public bool[] RewardHQ { get; internal set; }
    }
    
    public HugeCraftworksTurnInParamStruct[] HugeCraftworksTurnInParam { get; private set; }
    public HugeCraftworksRewardParamStruct[] HugeCraftworksRewardParam { get; private set; }
    public SeString Transient { get; private set; }
    public LazyRow< ENpcResident > EventNpc { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        HugeCraftworksTurnInParam = new HugeCraftworksTurnInParamStruct[6];
        for (int i = 0; i < 6; i++)
        {
        	HugeCraftworksTurnInParam[i].RequestedItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) (i * 16 + 0) ), language );
        	HugeCraftworksTurnInParam[i].Unknown0 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 4));
        	HugeCraftworksTurnInParam[i].RequestedQuantity = parser.ReadOffset< byte >( (ushort) (i * 16 + 6));
        	HugeCraftworksTurnInParam[i].Unknown1 = parser.ReadOffset< byte >( (ushort) (i * 16 + 7));
        	HugeCraftworksTurnInParam[i].Unknown2 = parser.ReadOffset< byte >( (ushort) (i * 16 + 8));
        	HugeCraftworksTurnInParam[i].Unknown3 = parser.ReadOffset< byte >( (ushort) (i * 16 + 9));
        	HugeCraftworksTurnInParam[i].Unknown4 = parser.ReadOffset< byte >( (ushort) (i * 16 + 10));
        	HugeCraftworksTurnInParam[i].Unknown5 = parser.ReadOffset< byte >( (ushort) (i * 16 + 11));
        	HugeCraftworksTurnInParam[i].Unknown6 = parser.ReadOffset< bool >( (ushort) (i * 16 + 12));
        }
        HugeCraftworksRewardParam = new HugeCraftworksRewardParamStruct[6];
        for (int i = 0; i < 6; i++)
        {
        	HugeCraftworksRewardParam[i].RewardItem = new LazyRow< Item >[2];
        	for (int RewardItemIndexer = 0; RewardItemIndexer < 2; RewardItemIndexer++)
        		HugeCraftworksRewardParam[i].RewardItem[RewardItemIndexer] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( i * 12 +  96 + RewardItemIndexer * 4 ), language );
        	HugeCraftworksRewardParam[i].RewardQuantity = new byte[2];
        	for (int RewardQuantityIndexer = 0; RewardQuantityIndexer < 2; RewardQuantityIndexer++)
        		HugeCraftworksRewardParam[i].RewardQuantity[RewardQuantityIndexer] = parser.ReadOffset< byte >( (ushort) ( i * 12 + 104 + RewardQuantityIndexer * 1 ) );
        	HugeCraftworksRewardParam[i].RewardHQ = new bool[2];
        	for (int RewardHQIndexer = 0; RewardHQIndexer < 2; RewardHQIndexer++)
        		HugeCraftworksRewardParam[i].RewardHQ[RewardHQIndexer] = parser.ReadOffset< bool >( (ushort) ( i * 12 + 106 + RewardHQIndexer * 1 ) );
        }
        Transient = parser.ReadOffset< SeString >( 168 );
        EventNpc = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 172 ), language );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< ushort >( 176 ), language );
        

    }
}
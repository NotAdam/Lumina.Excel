// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PvPSeries", columnHash: 0x45504238 )]
public partial class PvPSeries : ExcelRow
{
    public struct LevelRewardsStruct
    {
    	public LazyRow< Item >[] LevelRewardItem { get; internal set; }
    	public int Unknown0 { get; internal set; }
    	public ushort[] LevelRewardCount { get; internal set; }
    }
    
    public LevelRewardsStruct[] LevelRewards { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LevelRewards = new LevelRewardsStruct[32];
        for (int i = 0; i < 32; i++)
        {
        	LevelRewards[i].LevelRewardItem = new LazyRow< Item >[2];
        	for (int LevelRewardItemIndexer = 0; LevelRewardItemIndexer < 2; LevelRewardItemIndexer++)
        		LevelRewards[i].LevelRewardItem[LevelRewardItemIndexer] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( i * 16 +  0 + LevelRewardItemIndexer * 4 ), language );
        	LevelRewards[i].Unknown0 = parser.ReadOffset< int >( (ushort) (i * 16 + 8));
        	LevelRewards[i].LevelRewardCount = new ushort[2];
        	for (int LevelRewardCountIndexer = 0; LevelRewardCountIndexer < 2; LevelRewardCountIndexer++)
        		LevelRewards[i].LevelRewardCount[LevelRewardCountIndexer] = parser.ReadOffset< ushort >( (ushort) ( i * 16 + 12 + LevelRewardCountIndexer * 2 ) );
        }
        Unknown0 = parser.ReadOffset< byte >( 512 );
        

    }
}
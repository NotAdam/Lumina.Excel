// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIFarmPastureRank", columnHash: 0x7157b32e )]
public partial class MJIFarmPastureRank : ExcelRow
{
    public struct RankDataStruct
    {
    	public LazyRow< ExportedSG >[] SGB { get; internal set; }
    	public uint Unknown28 { get; internal set; }
    	public uint Unknown32 { get; internal set; }
    	public ushort Unknown40 { get; internal set; }
    	public ushort Unknown44 { get; internal set; }
    	public byte Unknown16 { get; internal set; }
    	public byte Unknown20 { get; internal set; }
    	public byte Unknown24 { get; internal set; }
    	public byte Unknown36 { get; internal set; }
    }
    
    public RankDataStruct[] RankData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        RankData = new RankDataStruct[4];
        for (int i = 0; i < 4; i++)
        {
        	RankData[i].SGB = new LazyRow< ExportedSG >[4];
        	for (int SGBIndexer = 0; SGBIndexer < 4; SGBIndexer++)
        		RankData[i].SGB[SGBIndexer] = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< uint >( i * 32 +  0 + SGBIndexer * 4 ), language );
        	RankData[i].Unknown28 = parser.ReadOffset< uint >( (ushort) (i * 32 + 16));
        	RankData[i].Unknown32 = parser.ReadOffset< uint >( (ushort) (i * 32 + 20));
        	RankData[i].Unknown40 = parser.ReadOffset< ushort >( (ushort) (i * 32 + 24));
        	RankData[i].Unknown44 = parser.ReadOffset< ushort >( (ushort) (i * 32 + 26));
        	RankData[i].Unknown16 = parser.ReadOffset< byte >( (ushort) (i * 32 + 28));
        	RankData[i].Unknown20 = parser.ReadOffset< byte >( (ushort) (i * 32 + 29));
        	RankData[i].Unknown24 = parser.ReadOffset< byte >( (ushort) (i * 32 + 30));
        	RankData[i].Unknown36 = parser.ReadOffset< byte >( (ushort) (i * 32 + 31));
        }
        

    }
}
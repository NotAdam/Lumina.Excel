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
    	public uint Unknown0 { get; internal set; }
    	public uint Unknown1 { get; internal set; }
    	public ushort Unknown2 { get; internal set; }
    	public ushort Unknown3 { get; internal set; }
    	public byte Unknown4 { get; internal set; }
    	public byte Unknown5 { get; internal set; }
    	public byte Unknown6 { get; internal set; }
    	public byte Unknown7 { get; internal set; }
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
        	RankData[i].Unknown0 = parser.ReadOffset< uint >( (ushort) (i * 32 + 16));
        	RankData[i].Unknown1 = parser.ReadOffset< uint >( (ushort) (i * 32 + 20));
        	RankData[i].Unknown2 = parser.ReadOffset< ushort >( (ushort) (i * 32 + 24));
        	RankData[i].Unknown3 = parser.ReadOffset< ushort >( (ushort) (i * 32 + 26));
        	RankData[i].Unknown4 = parser.ReadOffset< byte >( (ushort) (i * 32 + 28));
        	RankData[i].Unknown5 = parser.ReadOffset< byte >( (ushort) (i * 32 + 29));
        	RankData[i].Unknown6 = parser.ReadOffset< byte >( (ushort) (i * 32 + 30));
        	RankData[i].Unknown7 = parser.ReadOffset< byte >( (ushort) (i * 32 + 31));
        }
        

    }
}
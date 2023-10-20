// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Story", columnHash: 0xcaeee7ab )]
public partial class Story : ExcelRow
{
    public struct StoryParamsStruct
    {
    	public SeString Instruction { get; internal set; }
    	public uint Argument { get; internal set; }
    }
    public struct StoryDefineStruct
    {
    	public LazyRow< Quest >[] CompletedQuest { get; internal set; }
    	public LazyRow< Quest >[] AcceptedQuest { get; internal set; }
    	public uint[] LayerSet { get; internal set; }
    	public ushort Sequence { get; internal set; }
    	public byte CompletedQuestOperator { get; internal set; }
    	public byte AcceptedQuestOperator { get; internal set; }
    	public byte[] AcceptedQuestSequence { get; internal set; }
    }
    public struct StoryListenerStruct
    {
    	public ILazyRow Listener { get; internal set; }
    	public ushort SequenceBegin { get; internal set; }
    	public ushort SequenceEnd { get; internal set; }
    }
    
    public StoryParamsStruct[] StoryParams { get; private set; }
    public StoryDefineStruct[] StoryDefine { get; private set; }
    public StoryListenerStruct[] StoryListener { get; private set; }
    public SeString Script { get; private set; }
    public LazyRow< TerritoryType >[] LayerSetTerritoryType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        StoryParams = new StoryParamsStruct[40];
        for (int i = 0; i < 40; i++)
        {
        	StoryParams[i].Instruction = parser.ReadOffset< SeString >( (ushort) (i * 8 + 0));
        	StoryParams[i].Argument = parser.ReadOffset< uint >( (ushort) (i * 8 + 4));
        }
        StoryDefine = new StoryDefineStruct[110];
        for (int i = 0; i < 110; i++)
        {
        	StoryDefine[i].CompletedQuest = new LazyRow< Quest >[3];
        	for (int CompletedQuestIndexer = 0; CompletedQuestIndexer < 3; CompletedQuestIndexer++)
        		StoryDefine[i].CompletedQuest[CompletedQuestIndexer] = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( i * 40 +  320 + CompletedQuestIndexer * 4 ), language );
        	StoryDefine[i].AcceptedQuest = new LazyRow< Quest >[3];
        	for (int AcceptedQuestIndexer = 0; AcceptedQuestIndexer < 3; AcceptedQuestIndexer++)
        		StoryDefine[i].AcceptedQuest[AcceptedQuestIndexer] = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( i * 40 +  332 + AcceptedQuestIndexer * 4 ), language );
        	StoryDefine[i].LayerSet = new uint[2];
        	for (int LayerSetIndexer = 0; LayerSetIndexer < 2; LayerSetIndexer++)
        		StoryDefine[i].LayerSet[LayerSetIndexer] = parser.ReadOffset< uint >( (ushort) ( i * 40 + 344 + LayerSetIndexer * 4 ) );
        	StoryDefine[i].Sequence = parser.ReadOffset< ushort >( (ushort) (i * 40 + 352));
        	StoryDefine[i].CompletedQuestOperator = parser.ReadOffset< byte >( (ushort) (i * 40 + 354));
        	StoryDefine[i].AcceptedQuestOperator = parser.ReadOffset< byte >( (ushort) (i * 40 + 355));
        	StoryDefine[i].AcceptedQuestSequence = new byte[3];
        	for (int AcceptedQuestSequenceIndexer = 0; AcceptedQuestSequenceIndexer < 3; AcceptedQuestSequenceIndexer++)
        		StoryDefine[i].AcceptedQuestSequence[AcceptedQuestSequenceIndexer] = parser.ReadOffset< byte >( (ushort) ( i * 40 + 356 + AcceptedQuestSequenceIndexer * 1 ) );
        }
        StoryListener = new StoryListenerStruct[80];
        for (int i = 0; i < 80; i++)
        {
        	StoryListener[i].Listener = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( i * 8 + 4720 ), language, "EObjName", "ENpcResident" );
        	StoryListener[i].SequenceBegin = parser.ReadOffset< ushort >( (ushort) (i * 8 + 4724));
        	StoryListener[i].SequenceEnd = parser.ReadOffset< ushort >( (ushort) (i * 8 + 4726));
        }
        Script = parser.ReadOffset< SeString >( 5360 );
        LayerSetTerritoryType = new LazyRow< TerritoryType >[2];
        for (int i = 0; i < 2; i++)
        	LayerSetTerritoryType[i] = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( (ushort) ( 5364 + i * 2 ) ), language );
        

    }
}
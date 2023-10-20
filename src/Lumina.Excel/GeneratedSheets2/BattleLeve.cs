// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BattleLeve", columnHash: 0x1ce99cea )]
public partial class BattleLeve : ExcelRow
{
    public struct LeveDataStruct
    {
    	public LazyRow< BNpcName > BNpcName { get; internal set; }
    	public uint ToDoNumberInvolved { get; internal set; }
    	public uint[] ToDoParam { get; internal set; }
    	public ILazyRow BaseID { get; internal set; }
    	public LazyRow< EventItem > ItemsInvolved { get; internal set; }
    	public ushort EnemyLevel { get; internal set; }
    	public byte ItemsInvolvedQty { get; internal set; }
    	public byte ItemDropRate { get; internal set; }
    	public byte[] NumOfAppearance { get; internal set; }
    }
    
    public ushort[] Time { get; private set; }
    public LeveDataStruct[] LeveData { get; private set; }
    public byte[] ToDoSequence { get; private set; }
    public LazyRow< BattleLeveRule > Rule { get; private set; }
    public LazyRow< LeveString >[] Objectives { get; private set; }
    public ushort[] Help { get; private set; }
    public byte Variant { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Time = new ushort[8];
        for (int i = 0; i < 8; i++)
        	Time[i] = parser.ReadOffset< ushort >( 0 + i * 2 );
        LeveData = new LeveDataStruct[8];
        for (int i = 0; i < 8; i++)
        {
        	LeveData[i].BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< uint >( (ushort) (i * 48 + 16) ), language );
        	LeveData[i].ToDoNumberInvolved = parser.ReadOffset< uint >( (ushort) (i * 48 + 20));
        	LeveData[i].ToDoParam = new uint[5];
        	for (int ToDoParamIndexer = 0; ToDoParamIndexer < 5; ToDoParamIndexer++)
        		LeveData[i].ToDoParam[ToDoParamIndexer] = parser.ReadOffset< uint >( (ushort) ( i * 48 + 24 + ToDoParamIndexer * 4 ) );
        	LeveData[i].BaseID = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( i * 48 + 44 ), language, "EventItem", "BNpcBase" );
        	LeveData[i].ItemsInvolved = new LazyRow< EventItem >( gameData, parser.ReadOffset< int >( (ushort) (i * 48 + 48) ), language );
        	LeveData[i].EnemyLevel = parser.ReadOffset< ushort >( (ushort) (i * 48 + 52));
        	LeveData[i].ItemsInvolvedQty = parser.ReadOffset< byte >( (ushort) (i * 48 + 54));
        	LeveData[i].ItemDropRate = parser.ReadOffset< byte >( (ushort) (i * 48 + 55));
        	LeveData[i].NumOfAppearance = new byte[8];
        	for (int NumOfAppearanceIndexer = 0; NumOfAppearanceIndexer < 8; NumOfAppearanceIndexer++)
        		LeveData[i].NumOfAppearance[NumOfAppearanceIndexer] = parser.ReadOffset< byte >( (ushort) ( i * 48 + 56 + NumOfAppearanceIndexer * 1 ) );
        }
        ToDoSequence = new byte[8];
        for (int i = 0; i < 8; i++)
        	ToDoSequence[i] = parser.ReadOffset< byte >( 400 + i * 1 );
        Rule = new LazyRow< BattleLeveRule >( gameData, parser.ReadOffset< int >( 408 ), language );
        Objectives = new LazyRow< LeveString >[3];
        for (int i = 0; i < 3; i++)
        	Objectives[i] = new LazyRow< LeveString >( gameData, parser.ReadOffset< ushort >( (ushort) ( 412 + i * 2 ) ), language );
        Help = new ushort[2];
        for (int i = 0; i < 2; i++)
        	Help[i] = parser.ReadOffset< ushort >( 418 + i * 2 );
        Variant = parser.ReadOffset< byte >( 422 );
        

    }
}
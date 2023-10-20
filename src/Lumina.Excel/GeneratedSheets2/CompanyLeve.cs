// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanyLeve", columnHash: 0x688cf3da )]
public partial class CompanyLeve : ExcelRow
{
    public struct CompanyLeveStructStruct
    {
    	public LazyRow< BNpcName > BNpcName { get; internal set; }
    	public uint[] ToDoParam { get; internal set; }
    	public ILazyRow BaseID { get; internal set; }
    	public LazyRow< EventItem > ItemsInvolved { get; internal set; }
    	public ushort EnemyLevel { get; internal set; }
    	public byte ItemsInvolvedQty { get; internal set; }
    	public byte ItemDropRate { get; internal set; }
    	public byte[] NumOfAppearance { get; internal set; }
    }
    
    public ushort[] RoutePointTime { get; private set; }
    public CompanyLeveStructStruct[] CompanyLeveStruct { get; private set; }
    public byte[] ToDoSequence { get; private set; }
    public LazyRow< CompanyLeveRule > Rule { get; private set; }
    public byte RuleParam { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        RoutePointTime = new ushort[8];
        for (int i = 0; i < 8; i++)
        	RoutePointTime[i] = parser.ReadOffset< ushort >( 0 + i * 2 );
        CompanyLeveStruct = new CompanyLeveStructStruct[8];
        for (int i = 0; i < 8; i++)
        {
        	CompanyLeveStruct[i].BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< uint >( (ushort) (i * 48 + 16) ), language );
        	CompanyLeveStruct[i].ToDoParam = new uint[6];
        	for (int ToDoParamIndexer = 0; ToDoParamIndexer < 6; ToDoParamIndexer++)
        		CompanyLeveStruct[i].ToDoParam[ToDoParamIndexer] = parser.ReadOffset< uint >( (ushort) ( i * 48 + 20 + ToDoParamIndexer * 4 ) );
        	CompanyLeveStruct[i].BaseID = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( i * 48 + 44 ), language, "EventItem", "BNpcBase" );
        	CompanyLeveStruct[i].ItemsInvolved = new LazyRow< EventItem >( gameData, parser.ReadOffset< int >( (ushort) (i * 48 + 48) ), language );
        	CompanyLeveStruct[i].EnemyLevel = parser.ReadOffset< ushort >( (ushort) (i * 48 + 52));
        	CompanyLeveStruct[i].ItemsInvolvedQty = parser.ReadOffset< byte >( (ushort) (i * 48 + 54));
        	CompanyLeveStruct[i].ItemDropRate = parser.ReadOffset< byte >( (ushort) (i * 48 + 55));
        	CompanyLeveStruct[i].NumOfAppearance = new byte[8];
        	for (int NumOfAppearanceIndexer = 0; NumOfAppearanceIndexer < 8; NumOfAppearanceIndexer++)
        		CompanyLeveStruct[i].NumOfAppearance[NumOfAppearanceIndexer] = parser.ReadOffset< byte >( (ushort) ( i * 48 + 56 + NumOfAppearanceIndexer * 1 ) );
        }
        ToDoSequence = new byte[8];
        for (int i = 0; i < 8; i++)
        	ToDoSequence[i] = parser.ReadOffset< byte >( 400 + i * 1 );
        Rule = new LazyRow< CompanyLeveRule >( gameData, parser.ReadOffset< int >( 408 ), language );
        RuleParam = parser.ReadOffset< byte >( 412 );
        

    }
}
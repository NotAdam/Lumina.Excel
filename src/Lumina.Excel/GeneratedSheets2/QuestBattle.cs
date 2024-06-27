// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestBattle", columnHash: 0xd455ddb1 )]
public partial class QuestBattle : ExcelRow
{
    public struct QuestBattleParamsStruct
    {
    	public SeString ScriptInstruction { get; internal set; }
    	public uint ScriptValue { get; internal set; }
    }
    
    public QuestBattleParamsStruct[] QuestBattleParams { get; private set; }
    public ILazyRow Quest { get; private set; }
    public ushort TimeLimit { get; private set; }
    public ushort LevelSync { get; private set; }
    public byte QuestBattleScene { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        QuestBattleParams = new QuestBattleParamsStruct[220];
        for (int i = 0; i < 220; i++)
        {
        	QuestBattleParams[i].ScriptInstruction = parser.ReadOffset< SeString >( (ushort) (i * 8 + 0));
        	QuestBattleParams[i].ScriptValue = parser.ReadOffset< uint >( (ushort) (i * 8 + 4));
        }
        Quest = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 1760 ), language, "ArrayEventHandler", "Quest" );
        TimeLimit = parser.ReadOffset< ushort >( 1764 );
        LevelSync = parser.ReadOffset< ushort >( 1766 );
        QuestBattleScene = parser.ReadOffset< byte >( 1768 );
        

    }
}
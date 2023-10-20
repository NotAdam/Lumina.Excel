// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ParamGrow", columnHash: 0x64a92445 )]
public partial class ParamGrow : ExcelRow
{
    
    public int ExpToNext { get; private set; }
    public int MpModifier { get; private set; }
    public int BaseSpeed { get; private set; }
    public int LevelModifier { get; private set; }
    public int HuntingLogExpReward { get; private set; }
    public int MonsterNoteSeals { get; private set; }
    public ushort ScaledQuestXP { get; private set; }
    public ushort HpModifier { get; private set; }
    public ushort ItemLevelSync { get; private set; }
    public ushort ProperDungeon { get; private set; }
    public ushort ProperGuildOrder { get; private set; }
    public ushort CraftingLevel { get; private set; }
    public byte AdditionalActions { get; private set; }
    public byte ApplyAction { get; private set; }
    public byte QuestExpModifier { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpToNext = parser.ReadOffset< int >( 0 );
        MpModifier = parser.ReadOffset< int >( 4 );
        BaseSpeed = parser.ReadOffset< int >( 8 );
        LevelModifier = parser.ReadOffset< int >( 12 );
        HuntingLogExpReward = parser.ReadOffset< int >( 16 );
        MonsterNoteSeals = parser.ReadOffset< int >( 20 );
        ScaledQuestXP = parser.ReadOffset< ushort >( 24 );
        HpModifier = parser.ReadOffset< ushort >( 26 );
        ItemLevelSync = parser.ReadOffset< ushort >( 28 );
        ProperDungeon = parser.ReadOffset< ushort >( 30 );
        ProperGuildOrder = parser.ReadOffset< ushort >( 32 );
        CraftingLevel = parser.ReadOffset< ushort >( 34 );
        AdditionalActions = parser.ReadOffset< byte >( 36 );
        ApplyAction = parser.ReadOffset< byte >( 37 );
        QuestExpModifier = parser.ReadOffset< byte >( 38 );
        

    }
}
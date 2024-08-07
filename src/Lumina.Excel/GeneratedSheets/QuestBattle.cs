// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestBattle", columnHash: 0xd455ddb1 )]
    public partial class QuestBattle : ExcelRow
    {
        
        public int Quest { get; set; }
        public byte QuestBattleScene { get; set; }
        public ushort TimeLimit { get; set; }
        public ushort LevelSync { get; set; }
        public SeString[] ScriptInstruction { get; set; }
        public uint[] ScriptValue { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = parser.ReadColumn< int >( 0 );
            QuestBattleScene = parser.ReadColumn< byte >( 1 );
            TimeLimit = parser.ReadColumn< ushort >( 2 );
            LevelSync = parser.ReadColumn< ushort >( 3 );
            ScriptInstruction = new SeString[ 220 ];
            for( var i = 0; i < 220; i++ )
                ScriptInstruction[ i ] = parser.ReadColumn< SeString >( 4 + i );
            ScriptValue = new uint[ 220 ];
            for( var i = 0; i < 220; i++ )
                ScriptValue[ i ] = parser.ReadColumn< uint >( 224 + i );
        }
    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BattleLeveRule", columnHash: 0xdebb20e3 )]
public partial class BattleLeveRule : ExcelRow
{
    
    public SeString Rule { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Rule = parser.ReadOffset< SeString >( 0 );
        

    }
}
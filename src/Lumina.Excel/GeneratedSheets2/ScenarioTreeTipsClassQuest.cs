// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ScenarioTreeTipsClassQuest", columnHash: 0xae1d30a7 )]
public partial class ScenarioTreeTipsClassQuest : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< Quest > RequiredQuest { get; private set; }
    public ushort RequiredLevel { get; private set; }
    public LazyRow< ExVersion > RequiredExpansion { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        RequiredQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        RequiredLevel = parser.ReadOffset< ushort >( 8 );
        RequiredExpansion = new LazyRow< ExVersion >( gameData, parser.ReadOffset< byte >( 10 ), language );
        Unknown4 = parser.ReadOffset< bool >( 11 );
        Unknown5 = parser.ReadOffset< bool >( 11, 2 );
        

    }
}
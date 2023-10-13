// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Warp", columnHash: 0x1a234b7b )]
public partial class Warp : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Question { get; private set; }
    public LazyRow< Level > PopRange { get; private set; }
    public LazyRow< DefaultTalk > ConditionSuccessEvent { get; private set; }
    public LazyRow< DefaultTalk > ConditionFailEvent { get; private set; }
    public LazyRow< DefaultTalk > ConfirmEvent { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public LazyRow< WarpCondition > WarpCondition { get; private set; }
    public LazyRow< WarpLogic > WarpLogic { get; private set; }
    public LazyRow< Cutscene > StartCutscene { get; private set; }
    public LazyRow< Cutscene > EndCutscene { get; private set; }
    public bool CanSkipCutscene { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Question = parser.ReadOffset< SeString >( 4 );
        PopRange = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( 8 ), language );
        ConditionSuccessEvent = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 12 ), language );
        ConditionFailEvent = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 16 ), language );
        ConfirmEvent = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 20 ), language );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        WarpCondition = new LazyRow< WarpCondition >( gameData, parser.ReadOffset< ushort >( 26 ), language );
        WarpLogic = new LazyRow< WarpLogic >( gameData, parser.ReadOffset< ushort >( 28 ), language );
        StartCutscene = new LazyRow< Cutscene >( gameData, parser.ReadOffset< ushort >( 30 ), language );
        EndCutscene = new LazyRow< Cutscene >( gameData, parser.ReadOffset< ushort >( 32 ), language );
        CanSkipCutscene = parser.ReadOffset< bool >( 34 );
        

    }
}
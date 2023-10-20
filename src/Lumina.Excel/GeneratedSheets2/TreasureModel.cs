// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TreasureModel", columnHash: 0xdebb20e3 )]
public partial class TreasureModel : ExcelRow
{
    
    public SeString Path { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Path = parser.ReadOffset< SeString >( 0 );
        

    }
}
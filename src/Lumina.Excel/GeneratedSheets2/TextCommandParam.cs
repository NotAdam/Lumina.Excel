// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TextCommandParam", columnHash: 0xdebb20e3 )]
public partial class TextCommandParam : ExcelRow
{
    
    public SeString Param { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Param = parser.ReadOffset< SeString >( 0 );
        

    }
}
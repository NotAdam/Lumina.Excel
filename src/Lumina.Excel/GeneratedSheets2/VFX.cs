// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "VFX", columnHash: 0xdebb20e3 )]
public partial class VFX : ExcelRow
{
    
    public SeString Location { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Location = parser.ReadOffset< SeString >( 0 );
        

    }
}
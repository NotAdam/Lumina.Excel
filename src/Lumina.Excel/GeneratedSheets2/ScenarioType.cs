// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ScenarioType", columnHash: 0x9e3430e1 )]
public partial class ScenarioType : ExcelRow
{
    
    public SeString Type { get; private set; }
    public sbyte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Type = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< sbyte >( 4 );
        

    }
}
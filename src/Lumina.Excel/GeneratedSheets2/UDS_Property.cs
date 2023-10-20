// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "UDS_Property", columnHash: 0x9db0e48f )]
public partial class UDS_Property : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString Type { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        Type = parser.ReadOffset< SeString >( 4 );
        

    }
}
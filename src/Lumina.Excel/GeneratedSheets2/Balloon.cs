// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Balloon", columnHash: 0x9d1b5f4b )]
public partial class Balloon : ExcelRow
{
    
    public SeString Dialogue { get; private set; }
    public bool Slowly { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Dialogue = parser.ReadOffset< SeString >( 0 );
        Slowly = parser.ReadOffset< bool >( 4 );
        

    }
}
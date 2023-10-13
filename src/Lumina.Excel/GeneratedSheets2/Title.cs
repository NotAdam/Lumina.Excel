// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Title", columnHash: 0x83e3f9ba )]
public partial class Title : ExcelRow
{
    
    public SeString Masculine { get; private set; }
    public SeString Feminine { get; private set; }
    public bool IsPrefix { get; private set; }
    public ushort Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Masculine = parser.ReadOffset< SeString >( 0 );
        Feminine = parser.ReadOffset< SeString >( 4 );
        IsPrefix = parser.ReadOffset< bool >( 8 );
        Order = parser.ReadOffset< ushort >( 12 );
        

    }
}
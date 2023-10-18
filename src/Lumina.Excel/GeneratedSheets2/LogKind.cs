// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "LogKind", columnHash: 0x23b962ed )]
public partial class LogKind : ExcelRow
{
    
    public SeString Format { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Format = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< byte >( 4 );
        Unknown1 = parser.ReadOffset< bool >( 5 );
        

    }
}
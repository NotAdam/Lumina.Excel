// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Channeling", columnHash: 0xd5952f72 )]
public partial class Channeling : ExcelRow
{
    
    public SeString File { get; private set; }
    public byte WidthScale { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        File = parser.ReadOffset< SeString >( 0 );
        WidthScale = parser.ReadOffset< byte >( 4 );
        Unknown2 = parser.ReadOffset< bool >( 5 );
        Unknown3 = parser.ReadOffset< bool >( 5, 2 );
        Unknown4 = parser.ReadOffset< bool >( 5, 4 );
        

    }
}
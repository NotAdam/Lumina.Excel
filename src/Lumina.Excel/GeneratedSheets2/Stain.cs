// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Stain", columnHash: 0x97c471bd )]
public partial class Stain : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Unknown4 { get; private set; }
    public uint Color { get; private set; }
    public byte Shade { get; private set; }
    public byte SubOrder { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown4 = parser.ReadOffset< SeString >( 4 );
        Color = parser.ReadOffset< uint >( 8 );
        Shade = parser.ReadOffset< byte >( 12 );
        SubOrder = parser.ReadOffset< byte >( 13 );
        Unknown5 = parser.ReadOffset< bool >( 14 );
        Unknown6 = parser.ReadOffset< bool >( 14, 2 );
        

    }
}
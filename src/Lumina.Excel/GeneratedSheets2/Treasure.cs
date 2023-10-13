// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Treasure", columnHash: 0x030e840a )]
public partial class Treasure : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public SeString Unknown2 { get; private set; }
    public sbyte Unknown1 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public LazyRow< ExportedSG > SGB { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown2 = parser.ReadOffset< SeString >( 4 );
        Unknown1 = parser.ReadOffset< sbyte >( 8 );
        Unknown3 = parser.ReadOffset< sbyte >( 9 );
        Unknown4 = parser.ReadOffset< sbyte >( 10 );
        Unknown5 = parser.ReadOffset< sbyte >( 11 );
        Unknown6 = parser.ReadOffset< sbyte >( 12 );
        Unknown7 = parser.ReadOffset< sbyte >( 13 );
        SGB = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< uint >( 16 ), language );
        Unknown9 = parser.ReadOffset< bool >( 20 );
        Unknown10 = parser.ReadOffset< bool >( 20, 2 );
        

    }
}
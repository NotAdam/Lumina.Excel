// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Treasure", columnHash: 0xbc8c78db )]
public partial class Treasure : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public sbyte Unknown2 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public LazyRow< ExportedSG > SGB { get; private set; }
    public byte Unknown_70 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< SeString >( 4 );
        Unknown2 = parser.ReadOffset< sbyte >( 8 );
        Unknown3 = parser.ReadOffset< sbyte >( 9 );
        Unknown4 = parser.ReadOffset< sbyte >( 10 );
        Unknown5 = parser.ReadOffset< sbyte >( 11 );
        Unknown6 = parser.ReadOffset< sbyte >( 12 );
        Unknown7 = parser.ReadOffset< sbyte >( 13 );
        SGB = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< uint >( 16 ), language );
        Unknown_70 = parser.ReadOffset< byte >( 20 );
        Unknown8 = parser.ReadOffset< bool >( 21 );
        Unknown9 = parser.ReadOffset< bool >( 21, 2 );
        

    }
}
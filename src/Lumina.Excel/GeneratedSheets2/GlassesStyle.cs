// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GlassesStyle", columnHash: 0xc138bb6e )]
public partial class GlassesStyle : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public SeString Unknown2 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public sbyte Unknown8 { get; private set; }
    public int Unknown9 { get; private set; }
    public ushort Unknown10 { get; private set; }
    public ushort Unknown11 { get; private set; }
    public ushort Unknown12 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public ushort Unknown14 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public ushort Unknown16 { get; private set; }
    public ushort Unknown17 { get; private set; }
    public ushort Unknown18 { get; private set; }
    public ushort Unknown19 { get; private set; }
    public ushort Unknown20 { get; private set; }
    public ushort Unknown21 { get; private set; }
    public ushort Unknown22 { get; private set; }
    public short Unknown23 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< SeString >( 4 );
        Unknown2 = parser.ReadOffset< SeString >( 8 );
        Unknown3 = parser.ReadOffset< sbyte >( 12 );
        Unknown4 = parser.ReadOffset< sbyte >( 13 );
        Unknown5 = parser.ReadOffset< sbyte >( 14 );
        Unknown6 = parser.ReadOffset< sbyte >( 15 );
        Unknown7 = parser.ReadOffset< sbyte >( 16 );
        Unknown8 = parser.ReadOffset< sbyte >( 17 );
        Unknown9 = parser.ReadOffset< int >( 20 );
        Unknown10 = parser.ReadOffset< ushort >( 24 );
        Unknown11 = parser.ReadOffset< ushort >( 26 );
        Unknown12 = parser.ReadOffset< ushort >( 28 );
        Unknown13 = parser.ReadOffset< ushort >( 30 );
        Unknown14 = parser.ReadOffset< ushort >( 32 );
        Unknown15 = parser.ReadOffset< ushort >( 34 );
        Unknown16 = parser.ReadOffset< ushort >( 36 );
        Unknown17 = parser.ReadOffset< ushort >( 38 );
        Unknown18 = parser.ReadOffset< ushort >( 40 );
        Unknown19 = parser.ReadOffset< ushort >( 42 );
        Unknown20 = parser.ReadOffset< ushort >( 44 );
        Unknown21 = parser.ReadOffset< ushort >( 46 );
        Unknown22 = parser.ReadOffset< ushort >( 48 );
        Unknown23 = parser.ReadOffset< short >( 50 );
        

    }
}
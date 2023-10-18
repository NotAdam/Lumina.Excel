// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Pet", columnHash: 0x9416a25d )]
public partial class Pet : ExcelRow
{
    
    public SeString Name { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public sbyte Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        Unknown1 = parser.ReadOffset< ushort >( 6 );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        Unknown3 = parser.ReadOffset< ushort >( 10 );
        Unknown4 = parser.ReadOffset< ushort >( 12 );
        Unknown5 = parser.ReadOffset< byte >( 14 );
        Unknown6 = parser.ReadOffset< byte >( 15 );
        Unknown7 = parser.ReadOffset< byte >( 16 );
        Unknown8 = parser.ReadOffset< byte >( 17 );
        Unknown9 = parser.ReadOffset< byte >( 18 );
        Unknown10 = parser.ReadOffset< byte >( 19 );
        Unknown11 = parser.ReadOffset< byte >( 20 );
        Unknown12 = parser.ReadOffset< byte >( 21 );
        Unknown13 = parser.ReadOffset< byte >( 22 );
        Unknown14 = parser.ReadOffset< sbyte >( 23 );
        Unknown15 = parser.ReadOffset< bool >( 24 );
        Unknown16 = parser.ReadOffset< bool >( 24, 2 );
        Unknown17 = parser.ReadOffset< bool >( 24, 4 );
        

    }
}
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
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public sbyte Unknown12 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 6 );
        Unknown3 = parser.ReadOffset< ushort >( 8 );
        Unknown4 = parser.ReadOffset< ushort >( 10 );
        Unknown5 = parser.ReadOffset< ushort >( 12 );
        Unknown9 = parser.ReadOffset< byte >( 14 );
        Unknown10 = parser.ReadOffset< byte >( 15 );
        Unknown11 = parser.ReadOffset< byte >( 16 );
        Unknown13 = parser.ReadOffset< byte >( 17 );
        Unknown14 = parser.ReadOffset< byte >( 18 );
        Unknown15 = parser.ReadOffset< byte >( 19 );
        Unknown16 = parser.ReadOffset< byte >( 20 );
        Unknown17 = parser.ReadOffset< byte >( 21 );
        Unknown18 = parser.ReadOffset< byte >( 22 );
        Unknown12 = parser.ReadOffset< sbyte >( 23 );
        Unknown6 = parser.ReadOffset< bool >( 24 );
        Unknown7 = parser.ReadOffset< bool >( 24, 2 );
        Unknown8 = parser.ReadOffset< bool >( 24, 4 );
        

    }
}
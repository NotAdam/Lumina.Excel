// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PetMirage", columnHash: 0xc3af1cc0 )]
public partial class PetMirage : ExcelRow
{
    
    public SeString Name { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown33 { get; private set; }
    public ushort Unknown48 { get; private set; }
    public byte Unknown18 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown34 { get; private set; }
    public ushort Unknown49 { get; private set; }
    public byte Unknown19 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown35 { get; private set; }
    public ushort Unknown50 { get; private set; }
    public byte Unknown20 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public ushort Unknown36 { get; private set; }
    public ushort Unknown51 { get; private set; }
    public byte Unknown21 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public ushort Unknown37 { get; private set; }
    public ushort Unknown52 { get; private set; }
    public byte Unknown22 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public ushort Unknown38 { get; private set; }
    public ushort Unknown53 { get; private set; }
    public byte Unknown23 { get; private set; }
    public ushort Unknown9 { get; private set; }
    public ushort Unknown39 { get; private set; }
    public ushort Unknown54 { get; private set; }
    public byte Unknown24 { get; private set; }
    public ushort Unknown10 { get; private set; }
    public ushort Unknown40 { get; private set; }
    public ushort Unknown55 { get; private set; }
    public byte Unknown25 { get; private set; }
    public ushort Unknown11 { get; private set; }
    public ushort Unknown41 { get; private set; }
    public ushort Unknown56 { get; private set; }
    public byte Unknown26 { get; private set; }
    public ushort Unknown12 { get; private set; }
    public ushort Unknown42 { get; private set; }
    public ushort Unknown57 { get; private set; }
    public byte Unknown27 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public ushort Unknown43 { get; private set; }
    public ushort Unknown58 { get; private set; }
    public byte Unknown28 { get; private set; }
    public ushort Unknown14 { get; private set; }
    public ushort Unknown44 { get; private set; }
    public ushort Unknown59 { get; private set; }
    public byte Unknown29 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public ushort Unknown45 { get; private set; }
    public ushort Unknown60 { get; private set; }
    public byte Unknown30 { get; private set; }
    public ushort Unknown16 { get; private set; }
    public ushort Unknown46 { get; private set; }
    public ushort Unknown61 { get; private set; }
    public byte Unknown31 { get; private set; }
    public ushort Unknown17 { get; private set; }
    public ushort Unknown47 { get; private set; }
    public ushort Unknown62 { get; private set; }
    public byte Unknown32 { get; private set; }
    public float Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown3 = parser.ReadOffset< ushort >( 4 );
        Unknown33 = parser.ReadOffset< ushort >( 6 );
        Unknown48 = parser.ReadOffset< ushort >( 8 );
        Unknown18 = parser.ReadOffset< byte >( 10 );
        Unknown4 = parser.ReadOffset< ushort >( 12 );
        Unknown34 = parser.ReadOffset< ushort >( 14 );
        Unknown49 = parser.ReadOffset< ushort >( 16 );
        Unknown19 = parser.ReadOffset< byte >( 18 );
        Unknown5 = parser.ReadOffset< ushort >( 20 );
        Unknown35 = parser.ReadOffset< ushort >( 22 );
        Unknown50 = parser.ReadOffset< ushort >( 24 );
        Unknown20 = parser.ReadOffset< byte >( 26 );
        Unknown6 = parser.ReadOffset< ushort >( 28 );
        Unknown36 = parser.ReadOffset< ushort >( 30 );
        Unknown51 = parser.ReadOffset< ushort >( 32 );
        Unknown21 = parser.ReadOffset< byte >( 34 );
        Unknown7 = parser.ReadOffset< ushort >( 36 );
        Unknown37 = parser.ReadOffset< ushort >( 38 );
        Unknown52 = parser.ReadOffset< ushort >( 40 );
        Unknown22 = parser.ReadOffset< byte >( 42 );
        Unknown8 = parser.ReadOffset< ushort >( 44 );
        Unknown38 = parser.ReadOffset< ushort >( 46 );
        Unknown53 = parser.ReadOffset< ushort >( 48 );
        Unknown23 = parser.ReadOffset< byte >( 50 );
        Unknown9 = parser.ReadOffset< ushort >( 52 );
        Unknown39 = parser.ReadOffset< ushort >( 54 );
        Unknown54 = parser.ReadOffset< ushort >( 56 );
        Unknown24 = parser.ReadOffset< byte >( 58 );
        Unknown10 = parser.ReadOffset< ushort >( 60 );
        Unknown40 = parser.ReadOffset< ushort >( 62 );
        Unknown55 = parser.ReadOffset< ushort >( 64 );
        Unknown25 = parser.ReadOffset< byte >( 66 );
        Unknown11 = parser.ReadOffset< ushort >( 68 );
        Unknown41 = parser.ReadOffset< ushort >( 70 );
        Unknown56 = parser.ReadOffset< ushort >( 72 );
        Unknown26 = parser.ReadOffset< byte >( 74 );
        Unknown12 = parser.ReadOffset< ushort >( 76 );
        Unknown42 = parser.ReadOffset< ushort >( 78 );
        Unknown57 = parser.ReadOffset< ushort >( 80 );
        Unknown27 = parser.ReadOffset< byte >( 82 );
        Unknown13 = parser.ReadOffset< ushort >( 84 );
        Unknown43 = parser.ReadOffset< ushort >( 86 );
        Unknown58 = parser.ReadOffset< ushort >( 88 );
        Unknown28 = parser.ReadOffset< byte >( 90 );
        Unknown14 = parser.ReadOffset< ushort >( 92 );
        Unknown44 = parser.ReadOffset< ushort >( 94 );
        Unknown59 = parser.ReadOffset< ushort >( 96 );
        Unknown29 = parser.ReadOffset< byte >( 98 );
        Unknown15 = parser.ReadOffset< ushort >( 100 );
        Unknown45 = parser.ReadOffset< ushort >( 102 );
        Unknown60 = parser.ReadOffset< ushort >( 104 );
        Unknown30 = parser.ReadOffset< byte >( 106 );
        Unknown16 = parser.ReadOffset< ushort >( 108 );
        Unknown46 = parser.ReadOffset< ushort >( 110 );
        Unknown61 = parser.ReadOffset< ushort >( 112 );
        Unknown31 = parser.ReadOffset< byte >( 114 );
        Unknown17 = parser.ReadOffset< ushort >( 116 );
        Unknown47 = parser.ReadOffset< ushort >( 118 );
        Unknown62 = parser.ReadOffset< ushort >( 120 );
        Unknown32 = parser.ReadOffset< byte >( 122 );
        Unknown0 = parser.ReadOffset< float >( 124 );
        Unknown1 = parser.ReadOffset< ushort >( 128 );
        

    }
}
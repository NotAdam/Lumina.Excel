// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BNpcParts", columnHash: 0x4cf06d08 )]
public partial class BNpcParts : ExcelRow
{
    
    public float X1 { get; private set; }
    public float X2 { get; private set; }
    public float X3 { get; private set; }
    public float X4 { get; private set; }
    public float X5 { get; private set; }
    public float Unknown61 { get; private set; }
    public float Y1 { get; private set; }
    public float Y2 { get; private set; }
    public float Y3 { get; private set; }
    public float Y4 { get; private set; }
    public float Y5 { get; private set; }
    public float Unknown62 { get; private set; }
    public float Z1 { get; private set; }
    public float Z2 { get; private set; }
    public float Z3 { get; private set; }
    public float Z4 { get; private set; }
    public float Z5 { get; private set; }
    public float Unknown63 { get; private set; }
    public float Scale1 { get; private set; }
    public float Scale2 { get; private set; }
    public float Unknown32 { get; private set; }
    public float Scale4 { get; private set; }
    public float Scale5 { get; private set; }
    public float Unknown65 { get; private set; }
    public LazyRow< BNpcBase > BNpcBase1 { get; private set; }
    public LazyRow< BNpcBase > BNpcBase2 { get; private set; }
    public LazyRow< BNpcBase > BNpcBase3 { get; private set; }
    public LazyRow< BNpcBase > BNpcBase4 { get; private set; }
    public LazyRow< BNpcBase > BNpcBase5 { get; private set; }
    public ushort Unknown55 { get; private set; }
    public short Unknown9 { get; private set; }
    public short Unknown20 { get; private set; }
    public short Scale3 { get; private set; }
    public short Unknown42 { get; private set; }
    public short Unknown53 { get; private set; }
    public short Unknown64 { get; private set; }
    public byte PartSlot1 { get; private set; }
    public byte PartSlot2 { get; private set; }
    public byte PartSlot3 { get; private set; }
    public byte PartSlot4 { get; private set; }
    public byte PartSlot5 { get; private set; }
    public byte Unknown56 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown24 { get; private set; }
    public bool Unknown35 { get; private set; }
    public bool Unknown46 { get; private set; }
    public bool Unknown57 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown25 { get; private set; }
    public bool Unknown36 { get; private set; }
    public bool Unknown47 { get; private set; }
    public bool Unknown58 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown26 { get; private set; }
    public bool Unknown37 { get; private set; }
    public bool Unknown48 { get; private set; }
    public bool Unknown59 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool Unknown27 { get; private set; }
    public bool Unknown38 { get; private set; }
    public bool Unknown49 { get; private set; }
    public bool Unknown60 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        X1 = parser.ReadOffset< float >( 0 );
        X2 = parser.ReadOffset< float >( 4 );
        X3 = parser.ReadOffset< float >( 8 );
        X4 = parser.ReadOffset< float >( 12 );
        X5 = parser.ReadOffset< float >( 16 );
        Unknown61 = parser.ReadOffset< float >( 20 );
        Y1 = parser.ReadOffset< float >( 24 );
        Y2 = parser.ReadOffset< float >( 28 );
        Y3 = parser.ReadOffset< float >( 32 );
        Y4 = parser.ReadOffset< float >( 36 );
        Y5 = parser.ReadOffset< float >( 40 );
        Unknown62 = parser.ReadOffset< float >( 44 );
        Z1 = parser.ReadOffset< float >( 48 );
        Z2 = parser.ReadOffset< float >( 52 );
        Z3 = parser.ReadOffset< float >( 56 );
        Z4 = parser.ReadOffset< float >( 60 );
        Z5 = parser.ReadOffset< float >( 64 );
        Unknown63 = parser.ReadOffset< float >( 68 );
        Scale1 = parser.ReadOffset< float >( 72 );
        Scale2 = parser.ReadOffset< float >( 76 );
        Unknown32 = parser.ReadOffset< float >( 80 );
        Scale4 = parser.ReadOffset< float >( 84 );
        Scale5 = parser.ReadOffset< float >( 88 );
        Unknown65 = parser.ReadOffset< float >( 92 );
        BNpcBase1 = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< ushort >( 96 ), language );
        BNpcBase2 = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< ushort >( 98 ), language );
        BNpcBase3 = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< ushort >( 100 ), language );
        BNpcBase4 = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< ushort >( 102 ), language );
        BNpcBase5 = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< ushort >( 104 ), language );
        Unknown55 = parser.ReadOffset< ushort >( 106 );
        Unknown9 = parser.ReadOffset< short >( 108 );
        Unknown20 = parser.ReadOffset< short >( 110 );
        Scale3 = parser.ReadOffset< short >( 112 );
        Unknown42 = parser.ReadOffset< short >( 114 );
        Unknown53 = parser.ReadOffset< short >( 116 );
        Unknown64 = parser.ReadOffset< short >( 118 );
        PartSlot1 = parser.ReadOffset< byte >( 120 );
        PartSlot2 = parser.ReadOffset< byte >( 121 );
        PartSlot3 = parser.ReadOffset< byte >( 122 );
        PartSlot4 = parser.ReadOffset< byte >( 123 );
        PartSlot5 = parser.ReadOffset< byte >( 124 );
        Unknown56 = parser.ReadOffset< byte >( 125 );
        Unknown2 = parser.ReadOffset< bool >( 126 );
        Unknown13 = parser.ReadOffset< bool >( 127 );
        Unknown24 = parser.ReadOffset< bool >( 128 );
        Unknown35 = parser.ReadOffset< bool >( 129 );
        Unknown46 = parser.ReadOffset< bool >( 130 );
        Unknown57 = parser.ReadOffset< bool >( 131 );
        Unknown3 = parser.ReadOffset< bool >( 132 );
        Unknown14 = parser.ReadOffset< bool >( 133 );
        Unknown25 = parser.ReadOffset< bool >( 134 );
        Unknown36 = parser.ReadOffset< bool >( 135 );
        Unknown47 = parser.ReadOffset< bool >( 136 );
        Unknown58 = parser.ReadOffset< bool >( 137 );
        Unknown4 = parser.ReadOffset< bool >( 138 );
        Unknown15 = parser.ReadOffset< bool >( 139 );
        Unknown26 = parser.ReadOffset< bool >( 140 );
        Unknown37 = parser.ReadOffset< bool >( 141 );
        Unknown48 = parser.ReadOffset< bool >( 142 );
        Unknown59 = parser.ReadOffset< bool >( 143 );
        Unknown5 = parser.ReadOffset< bool >( 144 );
        Unknown16 = parser.ReadOffset< bool >( 145 );
        Unknown27 = parser.ReadOffset< bool >( 146 );
        Unknown38 = parser.ReadOffset< bool >( 147 );
        Unknown49 = parser.ReadOffset< bool >( 148 );
        Unknown60 = parser.ReadOffset< bool >( 149 );
        

    }
}
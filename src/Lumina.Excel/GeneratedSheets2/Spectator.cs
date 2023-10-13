// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Spectator", columnHash: 0xbb5e90d9 )]
public partial class Spectator : ExcelRow
{
    
    public float Unknown0 { get; private set; }
    public float Unknown1 { get; private set; }
    public float Unknown2 { get; private set; }
    public float Unknown3 { get; private set; }
    public float Unknown4 { get; private set; }
    public float Unknown5 { get; private set; }
    public float Unknown6 { get; private set; }
    public float Unknown7 { get; private set; }
    public float Unknown8 { get; private set; }
    public float Unknown9 { get; private set; }
    public float Unknown10 { get; private set; }
    public float Unknown11 { get; private set; }
    public float Unknown12 { get; private set; }
    public float Unknown13 { get; private set; }
    public float Unknown14 { get; private set; }
    public float Unknown15 { get; private set; }
    public float Unknown16 { get; private set; }
    public float Unknown17 { get; private set; }
    public float Unknown18 { get; private set; }
    public float Unknown19 { get; private set; }
    public float Unknown20 { get; private set; }
    public float Unknown21 { get; private set; }
    public float Unknown22 { get; private set; }
    public float Unknown23 { get; private set; }
    public float Unknown24 { get; private set; }
    public float Unknown25 { get; private set; }
    public float Unknown26 { get; private set; }
    public float Unknown27 { get; private set; }
    public float Unknown28 { get; private set; }
    public float Unknown29 { get; private set; }
    public float Unknown30 { get; private set; }
    public float Unknown31 { get; private set; }
    public float Unknown32 { get; private set; }
    public float Unknown33 { get; private set; }
    public float Unknown34 { get; private set; }
    public float Unknown35 { get; private set; }
    public float Unknown36 { get; private set; }
    public float Unknown37 { get; private set; }
    public float Unknown38 { get; private set; }
    public float Unknown39 { get; private set; }
    public byte Unknown40 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< float >( 0 );
        Unknown1 = parser.ReadOffset< float >( 4 );
        Unknown2 = parser.ReadOffset< float >( 8 );
        Unknown3 = parser.ReadOffset< float >( 12 );
        Unknown4 = parser.ReadOffset< float >( 16 );
        Unknown5 = parser.ReadOffset< float >( 20 );
        Unknown6 = parser.ReadOffset< float >( 24 );
        Unknown7 = parser.ReadOffset< float >( 28 );
        Unknown8 = parser.ReadOffset< float >( 32 );
        Unknown9 = parser.ReadOffset< float >( 36 );
        Unknown10 = parser.ReadOffset< float >( 40 );
        Unknown11 = parser.ReadOffset< float >( 44 );
        Unknown12 = parser.ReadOffset< float >( 48 );
        Unknown13 = parser.ReadOffset< float >( 52 );
        Unknown14 = parser.ReadOffset< float >( 56 );
        Unknown15 = parser.ReadOffset< float >( 60 );
        Unknown16 = parser.ReadOffset< float >( 64 );
        Unknown17 = parser.ReadOffset< float >( 68 );
        Unknown18 = parser.ReadOffset< float >( 72 );
        Unknown19 = parser.ReadOffset< float >( 76 );
        Unknown20 = parser.ReadOffset< float >( 80 );
        Unknown21 = parser.ReadOffset< float >( 84 );
        Unknown22 = parser.ReadOffset< float >( 88 );
        Unknown23 = parser.ReadOffset< float >( 92 );
        Unknown24 = parser.ReadOffset< float >( 96 );
        Unknown25 = parser.ReadOffset< float >( 100 );
        Unknown26 = parser.ReadOffset< float >( 104 );
        Unknown27 = parser.ReadOffset< float >( 108 );
        Unknown28 = parser.ReadOffset< float >( 112 );
        Unknown29 = parser.ReadOffset< float >( 116 );
        Unknown30 = parser.ReadOffset< float >( 120 );
        Unknown31 = parser.ReadOffset< float >( 124 );
        Unknown32 = parser.ReadOffset< float >( 128 );
        Unknown33 = parser.ReadOffset< float >( 132 );
        Unknown34 = parser.ReadOffset< float >( 136 );
        Unknown35 = parser.ReadOffset< float >( 140 );
        Unknown36 = parser.ReadOffset< float >( 144 );
        Unknown37 = parser.ReadOffset< float >( 148 );
        Unknown38 = parser.ReadOffset< float >( 152 );
        Unknown39 = parser.ReadOffset< float >( 156 );
        Unknown40 = parser.ReadOffset< byte >( 160 );
        

    }
}
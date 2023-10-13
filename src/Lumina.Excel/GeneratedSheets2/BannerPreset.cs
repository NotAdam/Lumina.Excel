// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BannerPreset", columnHash: 0xeeca93f7 )]
public partial class BannerPreset : ExcelRow
{
    
    public float Unknown0 { get; private set; }
    public float Unknown1 { get; private set; }
    public float Unknown2 { get; private set; }
    public float Unknown3 { get; private set; }
    public float Unknown4 { get; private set; }
    public float Unknown5 { get; private set; }
    public float Unknown9 { get; private set; }
    public float Unknown11 { get; private set; }
    public float Unknown12 { get; private set; }
    public float Unknown13 { get; private set; }
    public float Unknown14 { get; private set; }
    public int Unknown10 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public short Unknown6 { get; private set; }
    public short Unknown20 { get; private set; }
    public short Unknown21 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown22 { get; private set; }
    public byte Unknown23 { get; private set; }
    public byte Unknown24 { get; private set; }
    public byte Unknown25 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< float >( 0 );
        Unknown1 = parser.ReadOffset< float >( 4 );
        Unknown2 = parser.ReadOffset< float >( 8 );
        Unknown3 = parser.ReadOffset< float >( 12 );
        Unknown4 = parser.ReadOffset< float >( 16 );
        Unknown5 = parser.ReadOffset< float >( 20 );
        Unknown9 = parser.ReadOffset< float >( 24 );
        Unknown11 = parser.ReadOffset< float >( 28 );
        Unknown12 = parser.ReadOffset< float >( 32 );
        Unknown13 = parser.ReadOffset< float >( 36 );
        Unknown14 = parser.ReadOffset< float >( 40 );
        Unknown10 = parser.ReadOffset< int >( 44 );
        Unknown8 = parser.ReadOffset< ushort >( 48 );
        Unknown6 = parser.ReadOffset< short >( 50 );
        Unknown20 = parser.ReadOffset< short >( 52 );
        Unknown21 = parser.ReadOffset< short >( 54 );
        Unknown7 = parser.ReadOffset< byte >( 56 );
        Unknown15 = parser.ReadOffset< byte >( 57 );
        Unknown16 = parser.ReadOffset< byte >( 58 );
        Unknown17 = parser.ReadOffset< byte >( 59 );
        Unknown18 = parser.ReadOffset< byte >( 60 );
        Unknown19 = parser.ReadOffset< byte >( 61 );
        Unknown22 = parser.ReadOffset< byte >( 62 );
        Unknown23 = parser.ReadOffset< byte >( 63 );
        Unknown24 = parser.ReadOffset< byte >( 64 );
        Unknown25 = parser.ReadOffset< byte >( 65 );
        

    }
}
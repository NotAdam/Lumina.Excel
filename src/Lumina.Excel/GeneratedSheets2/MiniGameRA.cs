// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MiniGameRA", columnHash: 0x59d9cace )]
public partial class MiniGameRA : ExcelRow
{
    
    public uint Unknown7 { get; private set; }
    public int Unknown0 { get; private set; }
    public int Icon { get; private set; }
    public int Image { get; private set; }
    public LazyRow< BGM > BGM { get; private set; }
    public int Unknown4 { get; private set; }
    public ushort Unknown11 { get; private set; }
    public ushort Unknown12 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public short Unknown14 { get; private set; }
    public short Unknown15 { get; private set; }
    public short Unknown16 { get; private set; }
    public short Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    public byte Unknown21 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown7 = parser.ReadOffset< uint >( 0 );
        Unknown0 = parser.ReadOffset< int >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        Image = parser.ReadOffset< int >( 12 );
        BGM = new LazyRow< BGM >( gameData, parser.ReadOffset< int >( 16 ), language );
        Unknown4 = parser.ReadOffset< int >( 20 );
        Unknown11 = parser.ReadOffset< ushort >( 24 );
        Unknown12 = parser.ReadOffset< ushort >( 26 );
        Unknown13 = parser.ReadOffset< ushort >( 28 );
        Unknown14 = parser.ReadOffset< short >( 30 );
        Unknown15 = parser.ReadOffset< short >( 32 );
        Unknown16 = parser.ReadOffset< short >( 34 );
        Unknown17 = parser.ReadOffset< short >( 36 );
        Unknown18 = parser.ReadOffset< byte >( 38 );
        Unknown19 = parser.ReadOffset< byte >( 39 );
        Unknown20 = parser.ReadOffset< byte >( 40 );
        Unknown21 = parser.ReadOffset< byte >( 41 );
        Unknown5 = parser.ReadOffset< bool >( 42 );
        Unknown6 = parser.ReadOffset< bool >( 42, 2 );
        Unknown8 = parser.ReadOffset< bool >( 42, 4 );
        Unknown9 = parser.ReadOffset< bool >( 42, 8 );
        Unknown10 = parser.ReadOffset< bool >( 42, 16 );
        

    }
}
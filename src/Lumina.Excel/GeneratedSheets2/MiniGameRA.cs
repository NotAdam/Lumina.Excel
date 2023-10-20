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
    
    public uint Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Icon { get; private set; }
    public int Image { get; private set; }
    public LazyRow< BGM > BGM { get; private set; }
    public int Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public short Unknown6 { get; private set; }
    public short Unknown7 { get; private set; }
    public short Unknown8 { get; private set; }
    public short Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    public bool Unknown18 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        Image = parser.ReadOffset< int >( 12 );
        BGM = new LazyRow< BGM >( gameData, parser.ReadOffset< int >( 16 ), language );
        Unknown2 = parser.ReadOffset< int >( 20 );
        Unknown3 = parser.ReadOffset< ushort >( 24 );
        Unknown4 = parser.ReadOffset< ushort >( 26 );
        Unknown5 = parser.ReadOffset< ushort >( 28 );
        Unknown6 = parser.ReadOffset< short >( 30 );
        Unknown7 = parser.ReadOffset< short >( 32 );
        Unknown8 = parser.ReadOffset< short >( 34 );
        Unknown9 = parser.ReadOffset< short >( 36 );
        Unknown10 = parser.ReadOffset< byte >( 38 );
        Unknown11 = parser.ReadOffset< byte >( 39 );
        Unknown12 = parser.ReadOffset< byte >( 40 );
        Unknown13 = parser.ReadOffset< byte >( 41 );
        Unknown14 = parser.ReadOffset< bool >( 42 );
        Unknown15 = parser.ReadOffset< bool >( 42, 2 );
        Unknown16 = parser.ReadOffset< bool >( 42, 4 );
        Unknown17 = parser.ReadOffset< bool >( 42, 8 );
        Unknown18 = parser.ReadOffset< bool >( 42, 16 );
        

    }
}
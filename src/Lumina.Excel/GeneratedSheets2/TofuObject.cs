// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TofuObject", columnHash: 0x905cbcec )]
public partial class TofuObject : ExcelRow
{
    
    public SeString Unknown7 { get; private set; }
    public uint Unknown2 { get; private set; }
    public int Unknown8 { get; private set; }
    public int Unknown9 { get; private set; }
    public int Unknown10 { get; private set; }
    public int Unknown11 { get; private set; }
    public int Unknown12 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown7 = parser.ReadOffset< SeString >( 0 );
        Unknown2 = parser.ReadOffset< uint >( 4 );
        Unknown8 = parser.ReadOffset< int >( 8 );
        Unknown9 = parser.ReadOffset< int >( 12 );
        Unknown10 = parser.ReadOffset< int >( 16 );
        Unknown11 = parser.ReadOffset< int >( 20 );
        Unknown12 = parser.ReadOffset< int >( 24 );
        Unknown1 = parser.ReadOffset< ushort >( 28 );
        Unknown3 = parser.ReadOffset< ushort >( 30 );
        Unknown4 = parser.ReadOffset< ushort >( 32 );
        Unknown0 = parser.ReadOffset< byte >( 34 );
        Unknown5 = parser.ReadOffset< byte >( 35 );
        Unknown6 = parser.ReadOffset< byte >( 36 );
        Unknown13 = parser.ReadOffset< bool >( 37 );
        Unknown14 = parser.ReadOffset< bool >( 37, 2 );
        Unknown15 = parser.ReadOffset< bool >( 37, 4 );
        

    }
}
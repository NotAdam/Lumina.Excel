// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TofuPreset", columnHash: 0x345e7d0e )]
public partial class TofuPreset : ExcelRow
{
    
    public SeString Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown4 { get; private set; }
    public int Unknown5 { get; private set; }
    public int Unknown6 { get; private set; }
    public int Unknown7 { get; private set; }
    public int Unknown8 { get; private set; }
    public int Unknown9 { get; private set; }
    public int Unknown10 { get; private set; }
    public int Unknown11 { get; private set; }
    public int Unknown12 { get; private set; }
    public int Unknown13 { get; private set; }
    public ushort Unknown0 { get; private set; }
    public bool Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown1 = parser.ReadOffset< SeString >( 0 );
        Unknown2 = parser.ReadOffset< int >( 4 );
        Unknown4 = parser.ReadOffset< int >( 8 );
        Unknown5 = parser.ReadOffset< int >( 12 );
        Unknown6 = parser.ReadOffset< int >( 16 );
        Unknown7 = parser.ReadOffset< int >( 20 );
        Unknown8 = parser.ReadOffset< int >( 24 );
        Unknown9 = parser.ReadOffset< int >( 28 );
        Unknown10 = parser.ReadOffset< int >( 32 );
        Unknown11 = parser.ReadOffset< int >( 36 );
        Unknown12 = parser.ReadOffset< int >( 40 );
        Unknown13 = parser.ReadOffset< int >( 44 );
        Unknown0 = parser.ReadOffset< ushort >( 48 );
        Unknown3 = parser.ReadOffset< bool >( 50 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QTE", columnHash: 0x61035f90 )]
public partial class QTE : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public SeString Unknown2 { get; private set; }
    public SeString Unknown3 { get; private set; }
    public SeString Unknown4 { get; private set; }
    public int Unknown5 { get; private set; }
    public int Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< SeString >( 4 );
        Unknown2 = parser.ReadOffset< SeString >( 8 );
        Unknown3 = parser.ReadOffset< SeString >( 12 );
        Unknown4 = parser.ReadOffset< SeString >( 16 );
        Unknown5 = parser.ReadOffset< int >( 20 );
        Unknown6 = parser.ReadOffset< int >( 24 );
        Unknown7 = parser.ReadOffset< byte >( 28 );
        Unknown8 = parser.ReadOffset< byte >( 29 );
        Unknown9 = parser.ReadOffset< byte >( 30 );
        Unknown10 = parser.ReadOffset< byte >( 31 );
        Unknown11 = parser.ReadOffset< bool >( 32 );
        Unknown12 = parser.ReadOffset< bool >( 32, 2 );
        Unknown13 = parser.ReadOffset< bool >( 32, 4 );
        Unknown14 = parser.ReadOffset< bool >( 32, 8 );
        

    }
}
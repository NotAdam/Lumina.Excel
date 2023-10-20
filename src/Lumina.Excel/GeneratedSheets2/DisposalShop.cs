// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DisposalShop", columnHash: 0xca43e122 )]
public partial class DisposalShop : ExcelRow
{
    
    public SeString ShopName { get; private set; }
    public int Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public int Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public int Unknown6 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public int Unknown8 { get; private set; }
    public ushort Unknown9 { get; private set; }
    public int Unknown10 { get; private set; }
    public ushort Unknown11 { get; private set; }
    public int Unknown12 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public int Unknown14 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public bool Unknown16 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ShopName = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< int >( 4 );
        Unknown1 = parser.ReadOffset< ushort >( 8 );
        Unknown2 = parser.ReadOffset< int >( 12 );
        Unknown3 = parser.ReadOffset< ushort >( 16 );
        Unknown4 = parser.ReadOffset< int >( 20 );
        Unknown5 = parser.ReadOffset< ushort >( 24 );
        Unknown6 = parser.ReadOffset< int >( 28 );
        Unknown7 = parser.ReadOffset< ushort >( 32 );
        Unknown8 = parser.ReadOffset< int >( 36 );
        Unknown9 = parser.ReadOffset< ushort >( 40 );
        Unknown10 = parser.ReadOffset< int >( 44 );
        Unknown11 = parser.ReadOffset< ushort >( 48 );
        Unknown12 = parser.ReadOffset< int >( 52 );
        Unknown13 = parser.ReadOffset< ushort >( 56 );
        Unknown14 = parser.ReadOffset< int >( 60 );
        Unknown15 = parser.ReadOffset< ushort >( 64 );
        Unknown16 = parser.ReadOffset< bool >( 68 );
        

    }
}
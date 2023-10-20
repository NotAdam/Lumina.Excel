// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GoldSaucerTalk", columnHash: 0x49cf08f4 )]
public partial class GoldSaucerTalk : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public SeString Unknown2 { get; private set; }
    public SeString Unknown3 { get; private set; }
    public SeString Unknown4 { get; private set; }
    public SeString Unknown5 { get; private set; }
    public SeString Unknown6 { get; private set; }
    public SeString Unknown7 { get; private set; }
    public SeString Unknown8 { get; private set; }
    public SeString Unknown9 { get; private set; }
    public SeString Unknown10 { get; private set; }
    public ushort Unknown11 { get; private set; }
    public ushort Unknown12 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public ushort Unknown14 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public ushort Unknown16 { get; private set; }
    public ushort Unknown17 { get; private set; }
    public ushort Unknown18 { get; private set; }
    public ushort Unknown19 { get; private set; }
    public ushort Unknown20 { get; private set; }
    public ushort Unknown21 { get; private set; }
    public ushort Unknown22 { get; private set; }
    public byte Unknown23 { get; private set; }
    public byte Unknown24 { get; private set; }
    public byte Unknown25 { get; private set; }
    public bool Unknown26 { get; private set; }
    public bool Unknown27 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< SeString >( 4 );
        Unknown2 = parser.ReadOffset< SeString >( 8 );
        Unknown3 = parser.ReadOffset< SeString >( 12 );
        Unknown4 = parser.ReadOffset< SeString >( 16 );
        Unknown5 = parser.ReadOffset< SeString >( 20 );
        Unknown6 = parser.ReadOffset< SeString >( 24 );
        Unknown7 = parser.ReadOffset< SeString >( 28 );
        Unknown8 = parser.ReadOffset< SeString >( 32 );
        Unknown9 = parser.ReadOffset< SeString >( 36 );
        Unknown10 = parser.ReadOffset< SeString >( 40 );
        Unknown11 = parser.ReadOffset< ushort >( 44 );
        Unknown12 = parser.ReadOffset< ushort >( 46 );
        Unknown13 = parser.ReadOffset< ushort >( 48 );
        Unknown14 = parser.ReadOffset< ushort >( 50 );
        Unknown15 = parser.ReadOffset< ushort >( 52 );
        Unknown16 = parser.ReadOffset< ushort >( 54 );
        Unknown17 = parser.ReadOffset< ushort >( 56 );
        Unknown18 = parser.ReadOffset< ushort >( 58 );
        Unknown19 = parser.ReadOffset< ushort >( 60 );
        Unknown20 = parser.ReadOffset< ushort >( 62 );
        Unknown21 = parser.ReadOffset< ushort >( 64 );
        Unknown22 = parser.ReadOffset< ushort >( 66 );
        Unknown23 = parser.ReadOffset< byte >( 68 );
        Unknown24 = parser.ReadOffset< byte >( 69 );
        Unknown25 = parser.ReadOffset< byte >( 70 );
        Unknown26 = parser.ReadOffset< bool >( 71 );
        Unknown27 = parser.ReadOffset< bool >( 71, 2 );
        

    }
}
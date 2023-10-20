// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIProgress", columnHash: 0xe3dea9d5 )]
public partial class MJIProgress : ExcelRow
{
    
    public SeString Vision { get; private set; }
    public SeString Objective { get; private set; }
    public SeString PreviousObjective { get; private set; }
    public ushort Unknown0 { get; private set; }
    public short Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Vision = parser.ReadOffset< SeString >( 0 );
        Objective = parser.ReadOffset< SeString >( 4 );
        PreviousObjective = parser.ReadOffset< SeString >( 8 );
        Unknown0 = parser.ReadOffset< ushort >( 12 );
        Unknown1 = parser.ReadOffset< short >( 14 );
        Unknown2 = parser.ReadOffset< short >( 16 );
        Unknown3 = parser.ReadOffset< byte >( 18 );
        Unknown4 = parser.ReadOffset< byte >( 19 );
        Unknown5 = parser.ReadOffset< byte >( 20 );
        Unknown6 = parser.ReadOffset< byte >( 21 );
        Unknown7 = parser.ReadOffset< byte >( 22 );
        Unknown8 = parser.ReadOffset< byte >( 23 );
        Unknown9 = parser.ReadOffset< byte >( 24 );
        Unknown10 = parser.ReadOffset< byte >( 25 );
        Unknown11 = parser.ReadOffset< byte >( 26 );
        Unknown12 = parser.ReadOffset< byte >( 27 );
        Unknown13 = parser.ReadOffset< byte >( 28 );
        Unknown14 = parser.ReadOffset< byte >( 29 );
        Unknown15 = parser.ReadOffset< byte >( 30 );
        Unknown16 = parser.ReadOffset< byte >( 31 );
        Unknown17 = parser.ReadOffset< byte >( 32 );
        Unknown18 = parser.ReadOffset< byte >( 33 );
        Unknown19 = parser.ReadOffset< byte >( 34 );
        

    }
}
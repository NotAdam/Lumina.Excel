// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FittingShop", columnHash: 0x434f7f71 )]
public partial class FittingShop : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public ushort Unknown9 { get; private set; }
    public ushort Unknown10 { get; private set; }
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
    public ushort Unknown23 { get; private set; }
    public ushort Unknown24 { get; private set; }
    public ushort Unknown25 { get; private set; }
    public ushort Unknown26 { get; private set; }
    public ushort Unknown27 { get; private set; }
    public ushort Unknown28 { get; private set; }
    public ushort Unknown29 { get; private set; }
    public ushort Unknown30 { get; private set; }
    public ushort Unknown31 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 2 );
        Unknown2 = parser.ReadOffset< ushort >( 4 );
        Unknown3 = parser.ReadOffset< ushort >( 6 );
        Unknown4 = parser.ReadOffset< ushort >( 8 );
        Unknown5 = parser.ReadOffset< ushort >( 10 );
        Unknown6 = parser.ReadOffset< ushort >( 12 );
        Unknown7 = parser.ReadOffset< ushort >( 14 );
        Unknown8 = parser.ReadOffset< ushort >( 16 );
        Unknown9 = parser.ReadOffset< ushort >( 18 );
        Unknown10 = parser.ReadOffset< ushort >( 20 );
        Unknown11 = parser.ReadOffset< ushort >( 22 );
        Unknown12 = parser.ReadOffset< ushort >( 24 );
        Unknown13 = parser.ReadOffset< ushort >( 26 );
        Unknown14 = parser.ReadOffset< ushort >( 28 );
        Unknown15 = parser.ReadOffset< ushort >( 30 );
        Unknown16 = parser.ReadOffset< ushort >( 32 );
        Unknown17 = parser.ReadOffset< ushort >( 34 );
        Unknown18 = parser.ReadOffset< ushort >( 36 );
        Unknown19 = parser.ReadOffset< ushort >( 38 );
        Unknown20 = parser.ReadOffset< ushort >( 40 );
        Unknown21 = parser.ReadOffset< ushort >( 42 );
        Unknown22 = parser.ReadOffset< ushort >( 44 );
        Unknown23 = parser.ReadOffset< ushort >( 46 );
        Unknown24 = parser.ReadOffset< ushort >( 48 );
        Unknown25 = parser.ReadOffset< ushort >( 50 );
        Unknown26 = parser.ReadOffset< ushort >( 52 );
        Unknown27 = parser.ReadOffset< ushort >( 54 );
        Unknown28 = parser.ReadOffset< ushort >( 56 );
        Unknown29 = parser.ReadOffset< ushort >( 58 );
        Unknown30 = parser.ReadOffset< ushort >( 60 );
        Unknown31 = parser.ReadOffset< ushort >( 62 );
        

    }
}
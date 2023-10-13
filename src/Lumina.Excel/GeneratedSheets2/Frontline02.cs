// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Frontline02", columnHash: 0x4d1b9359 )]
public partial class Frontline02 : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Unknown7 { get; private set; }
    public uint Unknown8 { get; private set; }
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
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< uint >( 8 );
        Unknown3 = parser.ReadOffset< uint >( 12 );
        Unknown4 = parser.ReadOffset< uint >( 16 );
        Unknown5 = parser.ReadOffset< uint >( 20 );
        Unknown6 = parser.ReadOffset< uint >( 24 );
        Unknown7 = parser.ReadOffset< uint >( 28 );
        Unknown8 = parser.ReadOffset< uint >( 32 );
        Unknown9 = parser.ReadOffset< ushort >( 36 );
        Unknown10 = parser.ReadOffset< ushort >( 38 );
        Unknown11 = parser.ReadOffset< ushort >( 40 );
        Unknown12 = parser.ReadOffset< ushort >( 42 );
        Unknown13 = parser.ReadOffset< ushort >( 44 );
        Unknown14 = parser.ReadOffset< ushort >( 46 );
        Unknown15 = parser.ReadOffset< ushort >( 48 );
        Unknown16 = parser.ReadOffset< ushort >( 50 );
        Unknown17 = parser.ReadOffset< ushort >( 52 );
        Unknown18 = parser.ReadOffset< ushort >( 54 );
        Unknown19 = parser.ReadOffset< ushort >( 56 );
        Unknown20 = parser.ReadOffset< ushort >( 58 );
        Unknown21 = parser.ReadOffset< ushort >( 60 );
        Unknown22 = parser.ReadOffset< ushort >( 62 );
        Unknown23 = parser.ReadOffset< ushort >( 64 );
        Unknown24 = parser.ReadOffset< ushort >( 66 );
        Unknown25 = parser.ReadOffset< ushort >( 68 );
        Unknown26 = parser.ReadOffset< ushort >( 70 );
        Unknown27 = parser.ReadOffset< ushort >( 72 );
        Unknown28 = parser.ReadOffset< ushort >( 74 );
        Unknown29 = parser.ReadOffset< ushort >( 76 );
        

    }
}
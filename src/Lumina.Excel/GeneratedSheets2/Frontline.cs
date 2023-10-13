// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Frontline", columnHash: 0xd98c012d )]
public partial class Frontline : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
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
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< uint >( 8 );
        Unknown3 = parser.ReadOffset< ushort >( 12 );
        Unknown4 = parser.ReadOffset< ushort >( 14 );
        Unknown5 = parser.ReadOffset< ushort >( 16 );
        Unknown6 = parser.ReadOffset< ushort >( 18 );
        Unknown7 = parser.ReadOffset< ushort >( 20 );
        Unknown8 = parser.ReadOffset< ushort >( 22 );
        Unknown9 = parser.ReadOffset< ushort >( 24 );
        Unknown10 = parser.ReadOffset< ushort >( 26 );
        Unknown11 = parser.ReadOffset< ushort >( 28 );
        Unknown12 = parser.ReadOffset< ushort >( 30 );
        Unknown13 = parser.ReadOffset< ushort >( 32 );
        Unknown14 = parser.ReadOffset< ushort >( 34 );
        Unknown15 = parser.ReadOffset< ushort >( 36 );
        Unknown16 = parser.ReadOffset< ushort >( 38 );
        Unknown17 = parser.ReadOffset< ushort >( 40 );
        Unknown18 = parser.ReadOffset< ushort >( 42 );
        Unknown19 = parser.ReadOffset< ushort >( 44 );
        Unknown20 = parser.ReadOffset< ushort >( 46 );
        Unknown21 = parser.ReadOffset< ushort >( 48 );
        Unknown22 = parser.ReadOffset< ushort >( 50 );
        

    }
}
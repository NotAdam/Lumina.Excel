// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "OrnamentCustomizeGroup", columnHash: 0x90fd7146 )]
public partial class OrnamentCustomizeGroup : ExcelRow
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
    public ushort Unknown_70 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public ushort Unknown16 { get; private set; }
    public ushort Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    
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
        Unknown_70 = parser.ReadOffset< ushort >( 30 );
        Unknown15 = parser.ReadOffset< ushort >( 32 );
        Unknown16 = parser.ReadOffset< ushort >( 34 );
        Unknown17 = parser.ReadOffset< ushort >( 36 );
        Unknown18 = parser.ReadOffset< byte >( 38 );
        

    }
}
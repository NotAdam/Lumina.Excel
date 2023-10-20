// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CSBonusSeason", columnHash: 0x05c5101f )]
public partial class CSBonusSeason : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 6 );
        Unknown3 = parser.ReadOffset< ushort >( 8 );
        Unknown4 = parser.ReadOffset< ushort >( 10 );
        Unknown5 = parser.ReadOffset< ushort >( 12 );
        Unknown6 = parser.ReadOffset< ushort >( 14 );
        Unknown7 = parser.ReadOffset< byte >( 16 );
        Unknown8 = parser.ReadOffset< byte >( 17 );
        Unknown9 = parser.ReadOffset< byte >( 18 );
        Unknown10 = parser.ReadOffset< bool >( 19 );
        Unknown11 = parser.ReadOffset< bool >( 20 );
        Unknown12 = parser.ReadOffset< bool >( 21 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EventPathMove", columnHash: 0xb5e8d87a )]
public partial class EventPathMove : ExcelRow
{
    
    public SeString Unknown10 { get; private set; }
    public SeString Unknown11 { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Unknown7 { get; private set; }
    public uint Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown10 = parser.ReadOffset< SeString >( 0 );
        Unknown11 = parser.ReadOffset< SeString >( 4 );
        Unknown0 = parser.ReadOffset< uint >( 8 );
        Unknown5 = parser.ReadOffset< uint >( 12 );
        Unknown6 = parser.ReadOffset< uint >( 16 );
        Unknown7 = parser.ReadOffset< uint >( 20 );
        Unknown8 = parser.ReadOffset< uint >( 24 );
        Unknown9 = parser.ReadOffset< uint >( 28 );
        Unknown1 = parser.ReadOffset< ushort >( 32 );
        Unknown4 = parser.ReadOffset< ushort >( 34 );
        Unknown3 = parser.ReadOffset< byte >( 36 );
        Unknown2 = parser.ReadOffset< bool >( 37 );
        

    }
}
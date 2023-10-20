// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringLeveBNpcEntry", columnHash: 0x730863bd )]
public partial class GatheringLeveBNpcEntry : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public int Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public int Unknown7 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    public int Unknown10 { get; private set; }
    public ushort Unknown11 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        Unknown3 = parser.ReadOffset< uint >( 12 );
        Unknown4 = parser.ReadOffset< int >( 16 );
        Unknown5 = parser.ReadOffset< ushort >( 20 );
        Unknown6 = parser.ReadOffset< uint >( 24 );
        Unknown7 = parser.ReadOffset< int >( 28 );
        Unknown8 = parser.ReadOffset< ushort >( 32 );
        Unknown9 = parser.ReadOffset< uint >( 36 );
        Unknown10 = parser.ReadOffset< int >( 40 );
        Unknown11 = parser.ReadOffset< ushort >( 44 );
        

    }
}
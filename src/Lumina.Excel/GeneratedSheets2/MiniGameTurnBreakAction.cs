// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MiniGameTurnBreakAction", columnHash: 0x59f9f073 )]
public partial class MiniGameTurnBreakAction : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown3 { get; private set; }
    public int Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< SeString >( 4 );
        Unknown2 = parser.ReadOffset< int >( 8 );
        Unknown3 = parser.ReadOffset< int >( 12 );
        Unknown4 = parser.ReadOffset< int >( 16 );
        Unknown5 = parser.ReadOffset< byte >( 20 );
        Unknown6 = parser.ReadOffset< byte >( 21 );
        Unknown7 = parser.ReadOffset< byte >( 22 );
        Unknown8 = parser.ReadOffset< byte >( 23 );
        Unknown9 = parser.ReadOffset< byte >( 24 );
        

    }
}
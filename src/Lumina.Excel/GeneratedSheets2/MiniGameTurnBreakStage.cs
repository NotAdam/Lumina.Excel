// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MiniGameTurnBreakStage", columnHash: 0xc9ef8fad )]
public partial class MiniGameTurnBreakStage : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 2 );
        Unknown2 = parser.ReadOffset< byte >( 3 );
        Unknown3 = parser.ReadOffset< byte >( 4 );
        Unknown4 = parser.ReadOffset< byte >( 5 );
        Unknown5 = parser.ReadOffset< byte >( 6 );
        Unknown6 = parser.ReadOffset< byte >( 7 );
        Unknown7 = parser.ReadOffset< byte >( 8 );
        Unknown8 = parser.ReadOffset< byte >( 9 );
        Unknown9 = parser.ReadOffset< byte >( 10 );
        

    }
}
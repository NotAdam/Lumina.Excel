// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MiniGameTurnBreakStatus", columnHash: 0x057e61f4 )]
public partial class MiniGameTurnBreakStatus : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< SeString >( 4 );
        Unknown2 = parser.ReadOffset< int >( 8 );
        Unknown3 = parser.ReadOffset< byte >( 12 );
        Unknown4 = parser.ReadOffset< byte >( 13 );
        Unknown5 = parser.ReadOffset< bool >( 14 );
        

    }
}
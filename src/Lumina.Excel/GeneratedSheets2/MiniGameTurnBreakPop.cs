// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MiniGameTurnBreakPop", columnHash: 0x00a94fea )]
public partial class MiniGameTurnBreakPop : ExcelRow
{
    
    public ushort Unknown3 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown3 = parser.ReadOffset< ushort >( 0 );
        Unknown0 = parser.ReadOffset< byte >( 2 );
        Unknown1 = parser.ReadOffset< byte >( 3 );
        Unknown2 = parser.ReadOffset< byte >( 4 );
        

    }
}
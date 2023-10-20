// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CycleTime", columnHash: 0x5d58cc84 )]
public partial class CycleTime : ExcelRow
{
    
    public uint FirstCycle { get; private set; }
    public uint Cycle { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        FirstCycle = parser.ReadOffset< uint >( 0 );
        Cycle = parser.ReadOffset< uint >( 4 );
        

    }
}
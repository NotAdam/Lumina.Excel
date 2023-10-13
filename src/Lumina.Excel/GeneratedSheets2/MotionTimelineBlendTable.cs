// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MotionTimelineBlendTable", columnHash: 0x69213275 )]
public partial class MotionTimelineBlendTable : ExcelRow
{
    
    public byte DestBlendGroup { get; private set; }
    public byte SrcBlendGroup { get; private set; }
    public byte BlendFrame_PC { get; private set; }
    public byte BlendFram_TypeA { get; private set; }
    public byte BlendFram_TypeB { get; private set; }
    public byte BlendFram_TypeC { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        DestBlendGroup = parser.ReadOffset< byte >( 0 );
        SrcBlendGroup = parser.ReadOffset< byte >( 1 );
        BlendFrame_PC = parser.ReadOffset< byte >( 2 );
        BlendFram_TypeA = parser.ReadOffset< byte >( 3 );
        BlendFram_TypeB = parser.ReadOffset< byte >( 4 );
        BlendFram_TypeC = parser.ReadOffset< byte >( 5 );
        

    }
}
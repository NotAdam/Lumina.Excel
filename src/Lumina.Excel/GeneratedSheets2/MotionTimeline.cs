// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MotionTimeline", columnHash: 0x53852bca )]
public partial class MotionTimeline : ExcelRow
{
    
    public SeString Filename { get; private set; }
    public byte BlendGroup { get; private set; }
    public byte Unknown_70_1 { get; private set; }
    public byte Unknown_70_2 { get; private set; }
    public bool IsLoop { get; private set; }
    public bool IsBlinkEnable { get; private set; }
    public bool IsLipEnable { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Filename = parser.ReadOffset< SeString >( 0 );
        BlendGroup = parser.ReadOffset< byte >( 4 );
        Unknown_70_1 = parser.ReadOffset< byte >( 5 );
        Unknown_70_2 = parser.ReadOffset< byte >( 6 );
        IsLoop = parser.ReadOffset< bool >( 7 );
        IsBlinkEnable = parser.ReadOffset< bool >( 7, 2 );
        IsLipEnable = parser.ReadOffset< bool >( 7, 4 );
        

    }
}
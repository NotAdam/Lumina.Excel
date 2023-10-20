// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MotionTimeline", columnHash: 0xd5952f72 )]
public partial class MotionTimeline : ExcelRow
{
    
    public SeString Filename { get; private set; }
    public byte BlendGroup { get; private set; }
    public bool IsLoop { get; private set; }
    public bool IsBlinkEnable { get; private set; }
    public bool IsLipEnable { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Filename = parser.ReadOffset< SeString >( 0 );
        BlendGroup = parser.ReadOffset< byte >( 4 );
        IsLoop = parser.ReadOffset< bool >( 5 );
        IsBlinkEnable = parser.ReadOffset< bool >( 5, 2 );
        IsLipEnable = parser.ReadOffset< bool >( 5, 4 );
        

    }
}
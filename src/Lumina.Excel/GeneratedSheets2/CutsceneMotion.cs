// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CutsceneMotion", columnHash: 0x3d86ce33 )]
public partial class CutsceneMotion : ExcelRow
{
    
    public float WALK_LOOP_SPEED { get; private set; }
    public float RUN_LOOP_SPEED { get; private set; }
    public float SLOWWALK_LOOP_SPEED { get; private set; }
    public float SLOWRUN_LOOP_SPEED { get; private set; }
    public float BATTLEWALK_LOOP_SPEED { get; private set; }
    public float BATTLERUN_LOOP_SPEED { get; private set; }
    public float DASH_LOOP_SPEED { get; private set; }
    public byte TURN_CW90_FRAME { get; private set; }
    public byte TURN_CCW90_FRAME { get; private set; }
    public byte TURN_CW180_FRAME { get; private set; }
    public byte TURN_CCW180_FRAME { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        WALK_LOOP_SPEED = parser.ReadOffset< float >( 0 );
        RUN_LOOP_SPEED = parser.ReadOffset< float >( 4 );
        SLOWWALK_LOOP_SPEED = parser.ReadOffset< float >( 8 );
        SLOWRUN_LOOP_SPEED = parser.ReadOffset< float >( 12 );
        BATTLEWALK_LOOP_SPEED = parser.ReadOffset< float >( 16 );
        BATTLERUN_LOOP_SPEED = parser.ReadOffset< float >( 20 );
        DASH_LOOP_SPEED = parser.ReadOffset< float >( 24 );
        TURN_CW90_FRAME = parser.ReadOffset< byte >( 28 );
        TURN_CCW90_FRAME = parser.ReadOffset< byte >( 29 );
        TURN_CW180_FRAME = parser.ReadOffset< byte >( 30 );
        TURN_CCW180_FRAME = parser.ReadOffset< byte >( 31 );
        

    }
}
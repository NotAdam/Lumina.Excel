// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ModelSkeleton", columnHash: 0x94cc54f1 )]
public partial class ModelSkeleton : ExcelRow
{
    
    public float Radius { get; private set; }
    public float Height { get; private set; }
    public float VFXScale { get; private set; }
    public float FloatHeight { get; private set; }
    public float FloatDown { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public ushort Unknown9 { get; private set; }
    public ushort Unknown10 { get; private set; }
    public ushort FloatUp { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte LoopFlySE { get; private set; }
    public bool MotionBlendType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Radius = parser.ReadOffset< float >( 0 );
        Height = parser.ReadOffset< float >( 4 );
        VFXScale = parser.ReadOffset< float >( 8 );
        FloatHeight = parser.ReadOffset< float >( 12 );
        FloatDown = parser.ReadOffset< float >( 16 );
        Unknown3 = parser.ReadOffset< ushort >( 20 );
        Unknown4 = parser.ReadOffset< ushort >( 22 );
        Unknown5 = parser.ReadOffset< ushort >( 24 );
        Unknown6 = parser.ReadOffset< ushort >( 26 );
        Unknown7 = parser.ReadOffset< ushort >( 28 );
        Unknown8 = parser.ReadOffset< ushort >( 30 );
        Unknown9 = parser.ReadOffset< ushort >( 32 );
        Unknown10 = parser.ReadOffset< ushort >( 34 );
        FloatUp = parser.ReadOffset< ushort >( 36 );
        Unknown14 = parser.ReadOffset< byte >( 38 );
        LoopFlySE = parser.ReadOffset< byte >( 39 );
        MotionBlendType = parser.ReadOffset< bool >( 40 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AnimationLOD", columnHash: 0x261cfad0 )]
public partial class AnimationLOD : ExcelRow
{
    
    public float CameraDistance { get; private set; }
    public float SampleInterval { get; private set; }
    public sbyte BoneLOD { get; private set; }
    public bool[] AnimationEnable { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        CameraDistance = parser.ReadOffset< float >( 0 );
        SampleInterval = parser.ReadOffset< float >( 4 );
        BoneLOD = parser.ReadOffset< sbyte >( 8 );
        AnimationEnable = new bool[8];
        for (int i = 0; i < 8; i++)
        	AnimationEnable[i] = parser.ReadOffset< bool >( 9 + i * 1 );
        

    }
}
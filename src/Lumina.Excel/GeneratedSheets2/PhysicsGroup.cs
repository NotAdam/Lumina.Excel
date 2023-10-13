// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PhysicsGroup", columnHash: 0xfa594271 )]
public partial class PhysicsGroup : ExcelRow
{
    
    public float[] SimulationTime { get; private set; }
    public float[] PS3SimulationTime { get; private set; }
    public float RootFollowingGame { get; private set; }
    public float RootFollowingCutScene { get; private set; }
    public sbyte[] ConfigSwitch { get; private set; }
    public bool ResetByLookAt { get; private set; }
    public bool ForceAttractByPhysicsOff { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SimulationTime = new float[6];
        for (int i = 0; i < 6; i++)
        	SimulationTime[i] = parser.ReadOffset< float >( 0 + i * 4 );
        PS3SimulationTime = new float[6];
        for (int i = 0; i < 6; i++)
        	PS3SimulationTime[i] = parser.ReadOffset< float >( 24 + i * 4 );
        RootFollowingGame = parser.ReadOffset< float >( 48 );
        RootFollowingCutScene = parser.ReadOffset< float >( 52 );
        ConfigSwitch = new sbyte[3];
        for (int i = 0; i < 3; i++)
        	ConfigSwitch[i] = parser.ReadOffset< sbyte >( 56 + i * 1 );
        ResetByLookAt = parser.ReadOffset< bool >( 59 );
        ForceAttractByPhysicsOff = parser.ReadOffset< bool >( 59, 2 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RecastNavimesh", columnHash: 0x98c040df )]
public partial class RecastNavimesh : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public float TileSize { get; private set; }
    public float CellSize { get; private set; }
    public float CellHeight { get; private set; }
    public float AgentHeight { get; private set; }
    public float AgentRadius { get; private set; }
    public float AgentMaxClimb { get; private set; }
    public float AgentMaxSlope { get; private set; }
    public float RegionMinSize { get; private set; }
    public float RegionMergedSize { get; private set; }
    public float MaxEdgeLength { get; private set; }
    public float MaxEdgeError { get; private set; }
    public float VertsPerPoly { get; private set; }
    public float DetailMeshSampleDistance { get; private set; }
    public float DetailMeshMaxSampleError { get; private set; }
    public float Unknown17 { get; private set; }
    public float Unknown18 { get; private set; }
    public float Unknown19 { get; private set; }
    public float Unknown20 { get; private set; }
    public float Unknown21 { get; private set; }
    public float Unknown22 { get; private set; }
    public float Unknown23 { get; private set; }
    public float Unknown24 { get; private set; }
    public float Unknown25 { get; private set; }
    public float Unknown26 { get; private set; }
    public float Unknown27 { get; private set; }
    public float Unknown28 { get; private set; }
    public float Unknown29 { get; private set; }
    public float Unknown31 { get; private set; }
    public float Unknown32 { get; private set; }
    public float Unknown33 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown30 { get; private set; }
    public bool Unknown34 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        TileSize = parser.ReadOffset< float >( 4 );
        CellSize = parser.ReadOffset< float >( 8 );
        CellHeight = parser.ReadOffset< float >( 12 );
        AgentHeight = parser.ReadOffset< float >( 16 );
        AgentRadius = parser.ReadOffset< float >( 20 );
        AgentMaxClimb = parser.ReadOffset< float >( 24 );
        AgentMaxSlope = parser.ReadOffset< float >( 28 );
        RegionMinSize = parser.ReadOffset< float >( 32 );
        RegionMergedSize = parser.ReadOffset< float >( 36 );
        MaxEdgeLength = parser.ReadOffset< float >( 40 );
        MaxEdgeError = parser.ReadOffset< float >( 44 );
        VertsPerPoly = parser.ReadOffset< float >( 48 );
        DetailMeshSampleDistance = parser.ReadOffset< float >( 52 );
        DetailMeshMaxSampleError = parser.ReadOffset< float >( 56 );
        Unknown17 = parser.ReadOffset< float >( 60 );
        Unknown18 = parser.ReadOffset< float >( 64 );
        Unknown19 = parser.ReadOffset< float >( 68 );
        Unknown20 = parser.ReadOffset< float >( 72 );
        Unknown21 = parser.ReadOffset< float >( 76 );
        Unknown22 = parser.ReadOffset< float >( 80 );
        Unknown23 = parser.ReadOffset< float >( 84 );
        Unknown24 = parser.ReadOffset< float >( 88 );
        Unknown25 = parser.ReadOffset< float >( 92 );
        Unknown26 = parser.ReadOffset< float >( 96 );
        Unknown27 = parser.ReadOffset< float >( 100 );
        Unknown28 = parser.ReadOffset< float >( 104 );
        Unknown29 = parser.ReadOffset< float >( 108 );
        Unknown31 = parser.ReadOffset< float >( 112 );
        Unknown32 = parser.ReadOffset< float >( 116 );
        Unknown33 = parser.ReadOffset< float >( 120 );
        Unknown8 = parser.ReadOffset< bool >( 124 );
        Unknown11 = parser.ReadOffset< bool >( 124, 2 );
        Unknown30 = parser.ReadOffset< bool >( 124, 4 );
        Unknown34 = parser.ReadOffset< bool >( 124, 8 );
        

    }
}
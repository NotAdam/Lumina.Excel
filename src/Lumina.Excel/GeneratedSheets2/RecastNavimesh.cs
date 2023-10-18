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
    public float Unknown1 { get; private set; }
    public float Unknown2 { get; private set; }
    public float Unknown3 { get; private set; }
    public float Unknown4 { get; private set; }
    public float Unknown5 { get; private set; }
    public float Unknown6 { get; private set; }
    public float Unknown7 { get; private set; }
    public float Unknown8 { get; private set; }
    public float Unknown9 { get; private set; }
    public float Unknown10 { get; private set; }
    public float Unknown11 { get; private set; }
    public float Unknown12 { get; private set; }
    public float Unknown13 { get; private set; }
    public float Unknown14 { get; private set; }
    public float Unknown15 { get; private set; }
    public float Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    public bool Unknown18 { get; private set; }
    public bool Unknown19 { get; private set; }
    public bool Unknown20 { get; private set; }
    
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
        Unknown1 = parser.ReadOffset< float >( 60 );
        Unknown2 = parser.ReadOffset< float >( 64 );
        Unknown3 = parser.ReadOffset< float >( 68 );
        Unknown4 = parser.ReadOffset< float >( 72 );
        Unknown5 = parser.ReadOffset< float >( 76 );
        Unknown6 = parser.ReadOffset< float >( 80 );
        Unknown7 = parser.ReadOffset< float >( 84 );
        Unknown8 = parser.ReadOffset< float >( 88 );
        Unknown9 = parser.ReadOffset< float >( 92 );
        Unknown10 = parser.ReadOffset< float >( 96 );
        Unknown11 = parser.ReadOffset< float >( 100 );
        Unknown12 = parser.ReadOffset< float >( 104 );
        Unknown13 = parser.ReadOffset< float >( 108 );
        Unknown14 = parser.ReadOffset< float >( 112 );
        Unknown15 = parser.ReadOffset< float >( 116 );
        Unknown16 = parser.ReadOffset< float >( 120 );
        Unknown17 = parser.ReadOffset< bool >( 124 );
        Unknown18 = parser.ReadOffset< bool >( 124, 2 );
        Unknown19 = parser.ReadOffset< bool >( 124, 4 );
        Unknown20 = parser.ReadOffset< bool >( 124, 8 );
        

    }
}
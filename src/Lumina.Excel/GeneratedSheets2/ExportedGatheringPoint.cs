// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ExportedGatheringPoint", columnHash: 0xda46099c )]
public partial class ExportedGatheringPoint : ExcelRow
{
    
    public float X { get; private set; }
    public float Y { get; private set; }
    public ushort Radius { get; private set; }
    public LazyRow< GatheringType > GatheringType { get; private set; }
    public byte GatheringPointType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        X = parser.ReadOffset< float >( 0 );
        Y = parser.ReadOffset< float >( 4 );
        Radius = parser.ReadOffset< ushort >( 8 );
        GatheringType = new LazyRow< GatheringType >( gameData, parser.ReadOffset< byte >( 10 ), language );
        GatheringPointType = parser.ReadOffset< byte >( 11 );
        

    }
}
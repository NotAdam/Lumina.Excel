// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingMerchantPose", columnHash: 0x3d65a9f1 )]
public partial class HousingMerchantPose : ExcelRow
{
    
    public SeString Pose { get; private set; }
    public LazyRow< ActionTimeline > ActionTimeline { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Pose = parser.ReadOffset< SeString >( 0 );
        ActionTimeline = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        

    }
}
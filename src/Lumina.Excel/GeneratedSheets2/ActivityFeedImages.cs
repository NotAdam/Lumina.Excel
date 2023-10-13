// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActivityFeedImages", columnHash: 0x530c5199 )]
public partial class ActivityFeedImages : ExcelRow
{
    
    public SeString ExpansionImage { get; private set; }
    public SeString ActivityFeedJA { get; private set; }
    public SeString ActivityFeedEN { get; private set; }
    public SeString ActivityFeedDE { get; private set; }
    public SeString ActivityFeedFR { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpansionImage = parser.ReadOffset< SeString >( 0 );
        ActivityFeedJA = parser.ReadOffset< SeString >( 4 );
        ActivityFeedEN = parser.ReadOffset< SeString >( 8 );
        ActivityFeedDE = parser.ReadOffset< SeString >( 12 );
        ActivityFeedFR = parser.ReadOffset< SeString >( 16 );
        

    }
}
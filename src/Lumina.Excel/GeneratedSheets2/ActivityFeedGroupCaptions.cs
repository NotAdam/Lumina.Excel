// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActivityFeedGroupCaptions", columnHash: 0x776ee24c )]
public partial class ActivityFeedGroupCaptions : ExcelRow
{
    
    public SeString JA { get; private set; }
    public SeString EN { get; private set; }
    public SeString DE { get; private set; }
    public SeString FR { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        JA = parser.ReadOffset< SeString >( 0 );
        EN = parser.ReadOffset< SeString >( 4 );
        DE = parser.ReadOffset< SeString >( 8 );
        FR = parser.ReadOffset< SeString >( 12 );
        

    }
}
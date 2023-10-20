// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActivityFeedButtons", columnHash: 0x20072d40 )]
public partial class ActivityFeedButtons : ExcelRow
{
    
    public SeString BannerURL { get; private set; }
    public SeString Description { get; private set; }
    public SeString Language { get; private set; }
    public SeString PictureURL { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BannerURL = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Language = parser.ReadOffset< SeString >( 8 );
        PictureURL = parser.ReadOffset< SeString >( 12 );
        Unknown0 = parser.ReadOffset< byte >( 16 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AchievementCategory", columnHash: 0xb98d9baf )]
public partial class AchievementCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< AchievementKind > AchievementKind { get; private set; }
    public byte Order { get; private set; }
    public bool ShowComplete { get; private set; }
    public bool HideCategory { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        AchievementKind = new LazyRow< AchievementKind >( gameData, parser.ReadOffset< byte >( 4 ), language );
        Order = parser.ReadOffset< byte >( 5 );
        ShowComplete = parser.ReadOffset< bool >( 6 );
        HideCategory = parser.ReadOffset< bool >( 6, 2 );
        

    }
}
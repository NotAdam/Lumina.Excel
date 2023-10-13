// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AchievementHideCondition", columnHash: 0x824c4ccf )]
public partial class AchievementHideCondition : ExcelRow
{
    
    public bool HideAchievement { get; private set; }
    public bool HideName { get; private set; }
    public bool HideConditions { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        HideAchievement = parser.ReadOffset< bool >( 0 );
        HideName = parser.ReadOffset< bool >( 0, 2 );
        HideConditions = parser.ReadOffset< bool >( 0, 4 );
        

    }
}
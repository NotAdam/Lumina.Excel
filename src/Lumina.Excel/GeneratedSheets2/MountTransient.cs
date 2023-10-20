// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MountTransient", columnHash: 0x7f711762 )]
public partial class MountTransient : ExcelRow
{
    
    public SeString Description { get; private set; }
    public SeString DescriptionEnhanced { get; private set; }
    public SeString Tooltip { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Description = parser.ReadOffset< SeString >( 0 );
        DescriptionEnhanced = parser.ReadOffset< SeString >( 4 );
        Tooltip = parser.ReadOffset< SeString >( 8 );
        

    }
}
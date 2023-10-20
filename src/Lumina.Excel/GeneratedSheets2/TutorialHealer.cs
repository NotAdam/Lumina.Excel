// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TutorialHealer", columnHash: 0xdcfd9eba )]
public partial class TutorialHealer : ExcelRow
{
    
    public LazyRow< Tutorial > Objective { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Objective = new LazyRow< Tutorial >( gameData, parser.ReadOffset< byte >( 0 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PublicContentCutscene", columnHash: 0x5d58cc84 )]
public partial class PublicContentCutscene : ExcelRow
{
    
    public LazyRow< Cutscene > Cutscene { get; private set; }
    public LazyRow< Cutscene > Cutscene2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Cutscene = new LazyRow< Cutscene >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Cutscene2 = new LazyRow< Cutscene >( gameData, parser.ReadOffset< uint >( 4 ), language );
        

    }
}
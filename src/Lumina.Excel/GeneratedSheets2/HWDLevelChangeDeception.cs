// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDLevelChangeDeception", columnHash: 0xda365c51 )]
public partial class HWDLevelChangeDeception : ExcelRow
{
    
    public LazyRow< ScreenImage > Image { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Image = new LazyRow< ScreenImage >( gameData, parser.ReadOffset< int >( 0 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BGMFade", columnHash: 0xf09994a9 )]
public partial class BGMFade : ExcelRow
{
    
    public int SceneOut { get; private set; }
    public int SceneIn { get; private set; }
    public LazyRow< BGMFadeType > BGMFadeType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SceneOut = parser.ReadOffset< int >( 0 );
        SceneIn = parser.ReadOffset< int >( 4 );
        BGMFadeType = new LazyRow< BGMFadeType >( gameData, parser.ReadOffset< int >( 8 ), language );
        

    }
}
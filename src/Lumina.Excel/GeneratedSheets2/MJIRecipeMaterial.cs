// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIRecipeMaterial", columnHash: 0xfaedad07 )]
public partial class MJIRecipeMaterial : ExcelRow
{
    
    public LazyRow< MJIItemPouch > ItemPouch { get; private set; }
    public int Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ItemPouch = new LazyRow< MJIItemPouch >( gameData, parser.ReadOffset< int >( 0 ), language );
        Unknown0 = parser.ReadOffset< int >( 4 );
        

    }
}
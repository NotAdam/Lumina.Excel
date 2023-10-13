// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ExVersion", columnHash: 0xcc3ad729 )]
public partial class ExVersion : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< ScreenImage > AcceptJingle { get; private set; }
    public LazyRow< ScreenImage > CompleteJingle { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        AcceptJingle = new LazyRow< ScreenImage >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        CompleteJingle = new LazyRow< ScreenImage >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TraitRecast", columnHash: 0xdc23efe7 )]
public partial class TraitRecast : ExcelRow
{
    
    public LazyRow< Trait > Trait { get; private set; }
    public LazyRow< Action > Action { get; private set; }
    public ushort Timeds { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Trait = new LazyRow< Trait >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Action = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        Timeds = parser.ReadOffset< ushort >( 4 );
        

    }
}
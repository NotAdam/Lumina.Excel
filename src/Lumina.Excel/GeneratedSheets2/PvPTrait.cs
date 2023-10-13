// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PvPTrait", columnHash: 0xdc23efe7 )]
public partial class PvPTrait : ExcelRow
{
    
    public LazyRow< Trait > Trait1 { get; private set; }
    public LazyRow< Trait > Trait2 { get; private set; }
    public LazyRow< Trait > Trait3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Trait1 = new LazyRow< Trait >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Trait2 = new LazyRow< Trait >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        Trait3 = new LazyRow< Trait >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        

    }
}
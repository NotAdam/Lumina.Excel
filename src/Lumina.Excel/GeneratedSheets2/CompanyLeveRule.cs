// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanyLeveRule", columnHash: 0xcc3ad729 )]
public partial class CompanyLeveRule : ExcelRow
{
    
    public SeString Type { get; private set; }
    public LazyRow< LeveString > Objective { get; private set; }
    public LazyRow< LeveString > Help { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Type = parser.ReadOffset< SeString >( 0 );
        Objective = new LazyRow< LeveString >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        Help = new LazyRow< LeveString >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        

    }
}
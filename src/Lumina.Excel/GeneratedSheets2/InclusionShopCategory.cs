// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "InclusionShopCategory", columnHash: 0x3b24d05f )]
public partial class InclusionShopCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< InclusionShopSeries > InclusionShopSeries { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        InclusionShopSeries = new LazyRow< InclusionShopSeries >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 6 ), language );
        

    }
}
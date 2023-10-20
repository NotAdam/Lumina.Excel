// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GCScripShopCategory", columnHash: 0x9b330d8a )]
public partial class GCScripShopCategory : ExcelRow
{
    
    public LazyRow< GrandCompany > GrandCompany { get; private set; }
    public sbyte Tier { get; private set; }
    public sbyte SubCategory { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadOffset< sbyte >( 0 ), language );
        Tier = parser.ReadOffset< sbyte >( 1 );
        SubCategory = parser.ReadOffset< sbyte >( 2 );
        

    }
}
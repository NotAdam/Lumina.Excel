// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FurnitureCatalogItemList", columnHash: 0x24e9963a )]
public partial class FurnitureCatalogItemList : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< FurnitureCatalogCategory > Category { get; private set; }
    public ushort Patch { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        Category = new LazyRow< FurnitureCatalogCategory >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        Patch = parser.ReadOffset< ushort >( 6 );
        

    }
}
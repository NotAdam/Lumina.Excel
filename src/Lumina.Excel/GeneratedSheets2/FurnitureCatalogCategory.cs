// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FurnitureCatalogCategory", columnHash: 0xc8b7ab9b )]
public partial class FurnitureCatalogCategory : ExcelRow
{
    
    public SeString Category { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Category = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        Unknown1 = parser.ReadOffset< byte >( 6 );
        

    }
}
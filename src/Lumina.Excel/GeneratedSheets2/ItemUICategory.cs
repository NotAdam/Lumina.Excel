// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemUICategory", columnHash: 0xdc1f7844 )]
public partial class ItemUICategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Icon { get; private set; }
    public byte OrderMinor { get; private set; }
    public byte OrderMajor { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< int >( 4 );
        OrderMinor = parser.ReadOffset< byte >( 8 );
        OrderMajor = parser.ReadOffset< byte >( 9 );
        

    }
}
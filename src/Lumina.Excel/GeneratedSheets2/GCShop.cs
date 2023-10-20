// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GCShop", columnHash: 0xdd3ff48d )]
public partial class GCShop : ExcelRow
{
    
    public LazyRow< GrandCompany > GrandCompany { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadOffset< sbyte >( 0 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GCScripShopItem", columnHash: 0x6c3dae69 )]
public partial class GCScripShopItem : ExcelRow
{
    
    public uint CostGCSeals { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< GrandCompanyRank > RequiredGrandCompanyRank { get; private set; }
    public byte SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        CostGCSeals = parser.ReadOffset< uint >( 0 );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        RequiredGrandCompanyRank = new LazyRow< GrandCompanyRank >( gameData, parser.ReadOffset< int >( 8 ), language );
        SortKey = parser.ReadOffset< byte >( 12 );
        

    }
}
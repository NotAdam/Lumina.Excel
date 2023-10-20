// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CollectablesShop", columnHash: 0x6a066e9a )]
public partial class CollectablesShop : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< CollectablesShopItem >[] ShopItems { get; private set; }
    public byte RewardType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        ShopItems = new LazyRow< CollectablesShopItem >[11];
        for (int i = 0; i < 11; i++)
        	ShopItems[i] = new LazyRow< CollectablesShopItem >( gameData, parser.ReadOffset< ushort >( (ushort) ( 8 + i * 2 ) ), language );
        RewardType = parser.ReadOffset< byte >( 30 );
        

    }
}
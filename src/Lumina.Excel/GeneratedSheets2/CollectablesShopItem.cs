// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CollectablesShopItem", columnHash: 0x5d438d38 )]
public partial class CollectablesShopItem : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public uint Unknown3 { get; private set; }
    public ushort LevelMin { get; private set; }
    public ushort LevelMax { get; private set; }
    public LazyRow< CollectablesShopRefine > CollectablesShopRefine { get; private set; }
    public LazyRow< CollectablesShopRewardScrip > CollectablesShopRewardScrip { get; private set; }
    public LazyRow< CollectablesShopItemGroup > CollectablesShopItemGroup { get; private set; }
    public byte Stars { get; private set; }
    public byte Key { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown3 = parser.ReadOffset< uint >( 4 );
        LevelMin = parser.ReadOffset< ushort >( 8 );
        LevelMax = parser.ReadOffset< ushort >( 10 );
        CollectablesShopRefine = new LazyRow< CollectablesShopRefine >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        CollectablesShopRewardScrip = new LazyRow< CollectablesShopRewardScrip >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        CollectablesShopItemGroup = new LazyRow< CollectablesShopItemGroup >( gameData, parser.ReadOffset< byte >( 16 ), language );
        Stars = parser.ReadOffset< byte >( 17 );
        Key = parser.ReadOffset< byte >( 18 );
        

    }
}
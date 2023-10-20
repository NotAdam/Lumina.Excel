// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CollectablesShopRewardItem", columnHash: 0xf7e08b71 )]
public partial class CollectablesShopRewardItem : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public uint Unknown0 { get; private set; }
    public byte RewardLow { get; private set; }
    public byte RewardMid { get; private set; }
    public byte RewardHigh { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        RewardLow = parser.ReadOffset< byte >( 8 );
        RewardMid = parser.ReadOffset< byte >( 9 );
        RewardHigh = parser.ReadOffset< byte >( 10 );
        Unknown1 = parser.ReadOffset< byte >( 11 );
        Unknown2 = parser.ReadOffset< byte >( 12 );
        Unknown3 = parser.ReadOffset< byte >( 13 );
        Unknown4 = parser.ReadOffset< bool >( 14 );
        Unknown5 = parser.ReadOffset< bool >( 14, 2 );
        

    }
}
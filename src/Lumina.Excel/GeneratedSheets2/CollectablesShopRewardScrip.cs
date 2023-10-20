// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CollectablesShopRewardScrip", columnHash: 0x0c33ce97 )]
public partial class CollectablesShopRewardScrip : ExcelRow
{
    
    public ushort Currency { get; private set; }
    public ushort LowReward { get; private set; }
    public ushort MidReward { get; private set; }
    public ushort HighReward { get; private set; }
    public ushort ExpRatioLow { get; private set; }
    public ushort ExpRatioMid { get; private set; }
    public ushort ExpRatioHigh { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Currency = parser.ReadOffset< ushort >( 0 );
        LowReward = parser.ReadOffset< ushort >( 2 );
        MidReward = parser.ReadOffset< ushort >( 4 );
        HighReward = parser.ReadOffset< ushort >( 6 );
        ExpRatioLow = parser.ReadOffset< ushort >( 8 );
        ExpRatioMid = parser.ReadOffset< ushort >( 10 );
        ExpRatioHigh = parser.ReadOffset< ushort >( 12 );
        

    }
}
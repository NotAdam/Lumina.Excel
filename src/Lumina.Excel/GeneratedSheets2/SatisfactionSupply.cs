// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SatisfactionSupply", columnHash: 0x8c188eb2 )]
public partial class SatisfactionSupply : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public ushort CollectabilityLow { get; private set; }
    public ushort CollectabilityMid { get; private set; }
    public ushort CollectabilityHigh { get; private set; }
    public LazyRow< SatisfactionSupplyReward > Reward { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public byte Slot { get; private set; }
    public byte ProbabilityPercent { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        CollectabilityLow = parser.ReadOffset< ushort >( 4 );
        CollectabilityMid = parser.ReadOffset< ushort >( 6 );
        CollectabilityHigh = parser.ReadOffset< ushort >( 8 );
        Reward = new LazyRow< SatisfactionSupplyReward >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 12 );
        Unknown1 = parser.ReadOffset< ushort >( 14 );
        Slot = parser.ReadOffset< byte >( 16 );
        ProbabilityPercent = parser.ReadOffset< byte >( 17 );
        Unknown2 = parser.ReadOffset< bool >( 18 );
        

    }
}
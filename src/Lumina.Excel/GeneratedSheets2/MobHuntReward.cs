// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MobHuntReward", columnHash: 0x4ace707c )]
public partial class MobHuntReward : ExcelRow
{
    
    public uint ExpReward { get; private set; }
    public ushort GilReward { get; private set; }
    public ushort CurrencyReward { get; private set; }
    public LazyRow< ExVersion > Expansion { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpReward = parser.ReadOffset< uint >( 0 );
        GilReward = parser.ReadOffset< ushort >( 4 );
        CurrencyReward = parser.ReadOffset< ushort >( 6 );
        Expansion = new LazyRow< ExVersion >( gameData, parser.ReadOffset< byte >( 8 ), language );
        

    }
}
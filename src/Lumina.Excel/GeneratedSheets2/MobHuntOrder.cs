// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MobHuntOrder", columnHash: 0xa9aa9ab5 )]
public partial class MobHuntOrder : ExcelRow
{
    
    public LazyRow< MobHuntTarget > Target { get; private set; }
    public byte NeededKills { get; private set; }
    public byte Type { get; private set; }
    public byte Rank { get; private set; }
    public LazyRow< MobHuntReward > MobHuntReward { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Target = new LazyRow< MobHuntTarget >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        NeededKills = parser.ReadOffset< byte >( 2 );
        Type = parser.ReadOffset< byte >( 3 );
        Rank = parser.ReadOffset< byte >( 4 );
        MobHuntReward = new LazyRow< MobHuntReward >( gameData, parser.ReadOffset< byte >( 5 ), language );
        

    }
}
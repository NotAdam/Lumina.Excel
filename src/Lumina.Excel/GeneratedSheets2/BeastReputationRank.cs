// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BeastReputationRank", columnHash: 0x446d8bad )]
public partial class BeastReputationRank : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString AlliedNames { get; private set; }
    public LazyRow< UIColor > Color { get; private set; }
    public ushort RequiredReputation { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        AlliedNames = parser.ReadOffset< SeString >( 4 );
        Color = new LazyRow< UIColor >( gameData, parser.ReadOffset< uint >( 8 ), language );
        RequiredReputation = parser.ReadOffset< ushort >( 12 );
        

    }
}
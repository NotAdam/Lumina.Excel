// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SpearfishingItem", columnHash: 0x0d6bd3d9 )]
public partial class SpearfishingItem : ExcelRow
{
    
    public SeString Description { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public ushort Unknown6 { get; private set; }
    public LazyRow< FishingRecordType > FishingRecordType { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool IsVisible { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Description = parser.ReadOffset< SeString >( 0 );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        Unknown6 = parser.ReadOffset< ushort >( 12 );
        FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadOffset< byte >( 14 ), language );
        Unknown3 = parser.ReadOffset< bool >( 15 );
        IsVisible = parser.ReadOffset< bool >( 15, 2 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SpearfishingItem", columnHash: 0x644e0d6c )]
public partial class SpearfishingItem : ExcelRow
{
    
    public SeString Description { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; private set; }
    public ushort Unknown2 { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< FishingRecordType > FishingRecordType { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool IsVisible { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Description = parser.ReadOffset< SeString >( 0 );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Unknown2 = parser.ReadOffset< ushort >( 10 );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 14 );
        FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadOffset< byte >( 16 ), language );
        Unknown1 = parser.ReadOffset< bool >( 17 );
        IsVisible = parser.ReadOffset< bool >( 17, 2 );
        

    }
}
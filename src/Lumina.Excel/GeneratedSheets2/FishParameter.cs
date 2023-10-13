// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FishParameter", columnHash: 0x652cf81d )]
public partial class FishParameter : ExcelRow
{
    
    public SeString Text { get; private set; }
    public uint AchievementCredit { get; private set; }
    public ILazyRow Item { get; private set; }
    public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; private set; }
    public LazyRow< FishingSpot > FishingSpot { get; private set; }
    public LazyRow< GatheringSubCategory > GatheringSubCategory { get; private set; }
    public byte OceanStars { get; private set; }
    public LazyRow< FishingRecordType > FishingRecordType { get; private set; }
    public bool IsHidden { get; private set; }
    public bool IsInLog { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        AchievementCredit = parser.ReadOffset< uint >( 4 );
        Item = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 8 ), language, "EventItem", "Item" );
        GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        FishingSpot = new LazyRow< FishingSpot >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        GatheringSubCategory = new LazyRow< GatheringSubCategory >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        OceanStars = parser.ReadOffset< byte >( 18 );
        FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadOffset< byte >( 19 ), language );
        IsHidden = parser.ReadOffset< bool >( 20 );
        IsInLog = parser.ReadOffset< bool >( 20, 2 );
        

    }
}
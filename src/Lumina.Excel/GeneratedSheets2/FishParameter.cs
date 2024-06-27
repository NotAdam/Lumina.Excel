// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FishParameter", columnHash: 0x7c44029d )]
public partial class FishParameter : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString Unknown_70_1 { get; private set; }
    public SeString Unknown_70_2 { get; private set; }
    public SeString Unknown_70_3 { get; private set; }
    public uint AchievementCredit { get; private set; }
    public ILazyRow Item { get; private set; }
    public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; private set; }
    public ushort Unknown1 { get; private set; }
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
        Unknown_70_1 = parser.ReadOffset< SeString >( 4 );
        Unknown_70_2 = parser.ReadOffset< SeString >( 8 );
        Unknown_70_3 = parser.ReadOffset< SeString >( 12 );
        AchievementCredit = parser.ReadOffset< uint >( 16 );
        Item = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 20 ), language, "EventItem", "Item" );
        GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        Unknown1 = parser.ReadOffset< ushort >( 26 );
        FishingSpot = new LazyRow< FishingSpot >( gameData, parser.ReadOffset< ushort >( 28 ), language );
        GatheringSubCategory = new LazyRow< GatheringSubCategory >( gameData, parser.ReadOffset< ushort >( 30 ), language );
        OceanStars = parser.ReadOffset< byte >( 32 );
        FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadOffset< byte >( 33 ), language );
        IsHidden = parser.ReadOffset< bool >( 34 );
        IsInLog = parser.ReadOffset< bool >( 34, 2 );
        

    }
}
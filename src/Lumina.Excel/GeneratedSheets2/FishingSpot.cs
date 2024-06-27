// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FishingSpot", columnHash: 0x9e0d2a6c )]
public partial class FishingSpot : ExcelRow
{
    
    public SeString BigFishOnReach { get; private set; }
    public SeString BigFishOnEnd { get; private set; }
    public SeString Unknown_70_1 { get; private set; }
    public LazyRow< Item >[] Item { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public LazyRow< PlaceName > PlaceNameMain { get; private set; }
    public LazyRow< PlaceName > PlaceNameSub { get; private set; }
    public ushort Radius { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public ushort Order { get; private set; }
    public short X { get; private set; }
    public short Z { get; private set; }
    public byte GatheringLevel { get; private set; }
    public byte FishingSpotCategory { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool Rare { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BigFishOnReach = parser.ReadOffset< SeString >( 0 );
        BigFishOnEnd = parser.ReadOffset< SeString >( 4 );
        Unknown_70_1 = parser.ReadOffset< SeString >( 8 );
        Item = new LazyRow< Item >[10];
        for (int i = 0; i < 10; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) ( 12 + i * 4 ) ), language );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 52 ), language );
        PlaceNameMain = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 54 ), language );
        PlaceNameSub = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 56 ), language );
        Radius = parser.ReadOffset< ushort >( 58 );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 60 ), language );
        Order = parser.ReadOffset< ushort >( 62 );
        X = parser.ReadOffset< short >( 64 );
        Z = parser.ReadOffset< short >( 66 );
        GatheringLevel = parser.ReadOffset< byte >( 68 );
        FishingSpotCategory = parser.ReadOffset< byte >( 69 );
        Unknown0 = parser.ReadOffset< byte >( 70 );
        Rare = parser.ReadOffset< bool >( 71 );
        

    }
}
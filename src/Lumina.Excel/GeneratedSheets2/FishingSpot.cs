// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FishingSpot", columnHash: 0xb014a98d )]
public partial class FishingSpot : ExcelRow
{
    
    public SeString BigFishOnReach { get; private set; }
    public SeString BigFishOnEnd { get; private set; }
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
    public byte Unknown11 { get; private set; }
    public bool Rare { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BigFishOnReach = parser.ReadOffset< SeString >( 0 );
        BigFishOnEnd = parser.ReadOffset< SeString >( 4 );
        Item = new LazyRow< Item >[10];
        for (int i = 0; i < 10; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 8 + i * 4 ) ), language );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 48 ), language );
        PlaceNameMain = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 50 ), language );
        PlaceNameSub = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 52 ), language );
        Radius = parser.ReadOffset< ushort >( 54 );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 56 ), language );
        Order = parser.ReadOffset< ushort >( 58 );
        X = parser.ReadOffset< short >( 60 );
        Z = parser.ReadOffset< short >( 62 );
        GatheringLevel = parser.ReadOffset< byte >( 64 );
        FishingSpotCategory = parser.ReadOffset< byte >( 65 );
        Unknown11 = parser.ReadOffset< byte >( 66 );
        Rare = parser.ReadOffset< bool >( 67 );
        

    }
}
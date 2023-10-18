// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Map", columnHash: 0x4a6baf49 )]
public partial class Map : ExcelRow
{
    
    public SeString Id { get; private set; }
    public uint DiscoveryFlag { get; private set; }
    public ushort MapMarkerRange { get; private set; }
    public ushort SizeFactor { get; private set; }
    public LazyRow< PlaceName > PlaceNameRegion { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public LazyRow< PlaceName > PlaceNameSub { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public short OffsetX { get; private set; }
    public short OffsetY { get; private set; }
    public short DiscoveryIndex { get; private set; }
    public LazyRow< MapCondition > MapCondition { get; private set; }
    public byte PriorityCategoryUI { get; private set; }
    public byte PriorityUI { get; private set; }
    public byte Hierarchy { get; private set; }
    public byte Unknown0 { get; private set; }
    public sbyte MapIndex { get; private set; }
    public bool DiscoveryArrayByte { get; private set; }
    public bool IsEvent { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Id = parser.ReadOffset< SeString >( 0 );
        DiscoveryFlag = parser.ReadOffset< uint >( 4 );
        MapMarkerRange = parser.ReadOffset< ushort >( 8 );
        SizeFactor = parser.ReadOffset< ushort >( 10 );
        PlaceNameRegion = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        PlaceNameSub = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 18 ), language );
        OffsetX = parser.ReadOffset< short >( 20 );
        OffsetY = parser.ReadOffset< short >( 22 );
        DiscoveryIndex = parser.ReadOffset< short >( 24 );
        MapCondition = new LazyRow< MapCondition >( gameData, parser.ReadOffset< byte >( 26 ), language );
        PriorityCategoryUI = parser.ReadOffset< byte >( 27 );
        PriorityUI = parser.ReadOffset< byte >( 28 );
        Hierarchy = parser.ReadOffset< byte >( 29 );
        Unknown0 = parser.ReadOffset< byte >( 30 );
        MapIndex = parser.ReadOffset< sbyte >( 31 );
        DiscoveryArrayByte = parser.ReadOffset< bool >( 32 );
        IsEvent = parser.ReadOffset< bool >( 32, 2 );
        Unknown1 = parser.ReadOffset< bool >( 32, 4 );
        

    }
}
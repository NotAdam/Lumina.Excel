// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TerritoryType", columnHash: 0x5baa595e )]
public partial class TerritoryType : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Bg { get; private set; }
    public LazyRow< ArrayEventHandler > ArrayEventHandler { get; private set; }
    public int PlaceNameRegionIcon { get; private set; }
    public int PlaceNameIcon { get; private set; }
    public LazyRow< Aetheryte > Aetheryte { get; private set; }
    public int FixedTime { get; private set; }
    public LazyRow< PlaceName > PlaceNameRegion { get; private set; }
    public LazyRow< PlaceName > PlaceNameZone { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public LazyRow< Map > Map { get; private set; }
    public LazyRow< ContentFinderCondition > ContentFinderCondition { get; private set; }
    public ILazyRow BGM { get; private set; }
    public LazyRow< QuestBattle > QuestBattle { get; private set; }
    public ushort Resident { get; private set; }
    public LazyRow< NotoriousMonsterTerritory > NotoriousMonsterTerritory { get; private set; }
    public byte BattalionMode { get; private set; }
    public LazyRow< LoadingImage > LoadingImage { get; private set; }
    public byte ExclusiveType { get; private set; }
    public LazyRow< TerritoryIntendedUse > TerritoryIntendedUse { get; private set; }
    public byte WeatherRate { get; private set; }
    public byte Unknown1 { get; private set; }
    public LazyRow< ExVersion > ExVersion { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public LazyRow< MountSpeed > MountSpeed { get; private set; }
    public byte Unknown5 { get; private set; }
    public sbyte AchievementIndex { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool PCSearch { get; private set; }
    public bool Stealth { get; private set; }
    public bool Mount { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool IsPvpZone { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Bg = parser.ReadOffset< SeString >( 4 );
        ArrayEventHandler = new LazyRow< ArrayEventHandler >( gameData, parser.ReadOffset< uint >( 8 ), language );
        PlaceNameRegionIcon = parser.ReadOffset< int >( 12 );
        PlaceNameIcon = parser.ReadOffset< int >( 16 );
        Aetheryte = new LazyRow< Aetheryte >( gameData, parser.ReadOffset< int >( 20 ), language );
        FixedTime = parser.ReadOffset< int >( 24 );
        PlaceNameRegion = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 28 ), language );
        PlaceNameZone = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 30 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 32 ), language );
        Map = new LazyRow< Map >( gameData, parser.ReadOffset< ushort >( 34 ), language );
        ContentFinderCondition = new LazyRow< ContentFinderCondition >( gameData, parser.ReadOffset< ushort >( 36 ), language );
        BGM = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< ushort >( 38 ), language, "BGM", "BGMSituation" );
        QuestBattle = new LazyRow< QuestBattle >( gameData, parser.ReadOffset< ushort >( 40 ), language );
        Resident = parser.ReadOffset< ushort >( 42 );
        NotoriousMonsterTerritory = new LazyRow< NotoriousMonsterTerritory >( gameData, parser.ReadOffset< ushort >( 44 ), language );
        BattalionMode = parser.ReadOffset< byte >( 46 );
        LoadingImage = new LazyRow< LoadingImage >( gameData, parser.ReadOffset< byte >( 47 ), language );
        ExclusiveType = parser.ReadOffset< byte >( 48 );
        TerritoryIntendedUse = new LazyRow< TerritoryIntendedUse >( gameData, parser.ReadOffset< byte >( 49 ), language );
        WeatherRate = parser.ReadOffset< byte >( 50 );
        Unknown1 = parser.ReadOffset< byte >( 51 );
        ExVersion = new LazyRow< ExVersion >( gameData, parser.ReadOffset< byte >( 52 ), language );
        Unknown2 = parser.ReadOffset< byte >( 53 );
        Unknown3 = parser.ReadOffset< byte >( 54 );
        Unknown4 = parser.ReadOffset< byte >( 55 );
        MountSpeed = new LazyRow< MountSpeed >( gameData, parser.ReadOffset< byte >( 56 ), language );
        Unknown5 = parser.ReadOffset< byte >( 57 );
        AchievementIndex = parser.ReadOffset< sbyte >( 58 );
        Unknown6 = parser.ReadOffset< bool >( 59 );
        Unknown7 = parser.ReadOffset< bool >( 59, 2 );
        PCSearch = parser.ReadOffset< bool >( 59, 4 );
        Stealth = parser.ReadOffset< bool >( 59, 8 );
        Mount = parser.ReadOffset< bool >( 59, 16 );
        Unknown8 = parser.ReadOffset< bool >( 59, 32 );
        IsPvpZone = parser.ReadOffset< bool >( 59, 64 );
        Unknown9 = parser.ReadOffset< bool >( 59, 128 );
        Unknown10 = parser.ReadOffset< bool >( 60 );
        Unknown11 = parser.ReadOffset< bool >( 60, 2 );
        Unknown12 = parser.ReadOffset< bool >( 60, 4 );
        Unknown13 = parser.ReadOffset< bool >( 60, 8 );
        Unknown14 = parser.ReadOffset< bool >( 60, 16 );
        Unknown15 = parser.ReadOffset< bool >( 60, 32 );
        

    }
}
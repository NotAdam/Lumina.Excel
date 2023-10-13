// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SkyIsland2Mission", columnHash: 0xec50a29c )]
public partial class SkyIsland2Mission : ExcelRow
{
    
    public SeString Unknown21 { get; private set; }
    public SeString Unknown22 { get; private set; }
    public SeString Unknown23 { get; private set; }
    public SeString Unknown24 { get; private set; }
    public SeString Unknown25 { get; private set; }
    public LazyRow< EventItem > Item1 { get; private set; }
    public LazyRow< EventItem > Item2 { get; private set; }
    public uint PopRange0 { get; private set; }
    public uint PopRange1 { get; private set; }
    public uint PopRange2 { get; private set; }
    public uint Unknown7 { get; private set; }
    public uint Unknown12 { get; private set; }
    public uint Unknown17 { get; private set; }
    public uint Unknown19 { get; private set; }
    public uint Image { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public ushort Unknown3 { get; private set; }
    public LazyRow< SkyIsland2MissionDetail > Objective1 { get; private set; }
    public LazyRow< SkyIsland2MissionDetail > Objective2 { get; private set; }
    public LazyRow< SkyIsland2MissionDetail > Objective3 { get; private set; }
    public byte RequiredAmount1 { get; private set; }
    public byte RequiredAmount2 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown18 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown21 = parser.ReadOffset< SeString >( 0 );
        Unknown22 = parser.ReadOffset< SeString >( 4 );
        Unknown23 = parser.ReadOffset< SeString >( 8 );
        Unknown24 = parser.ReadOffset< SeString >( 12 );
        Unknown25 = parser.ReadOffset< SeString >( 16 );
        Item1 = new LazyRow< EventItem >( gameData, parser.ReadOffset< uint >( 20 ), language );
        Item2 = new LazyRow< EventItem >( gameData, parser.ReadOffset< uint >( 24 ), language );
        PopRange0 = parser.ReadOffset< uint >( 28 );
        PopRange1 = parser.ReadOffset< uint >( 32 );
        PopRange2 = parser.ReadOffset< uint >( 36 );
        Unknown7 = parser.ReadOffset< uint >( 40 );
        Unknown12 = parser.ReadOffset< uint >( 44 );
        Unknown17 = parser.ReadOffset< uint >( 48 );
        Unknown19 = parser.ReadOffset< uint >( 52 );
        Image = parser.ReadOffset< uint >( 56 );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 60 ), language );
        Unknown3 = parser.ReadOffset< ushort >( 62 );
        Objective1 = new LazyRow< SkyIsland2MissionDetail >( gameData, parser.ReadOffset< ushort >( 64 ), language );
        Objective2 = new LazyRow< SkyIsland2MissionDetail >( gameData, parser.ReadOffset< ushort >( 66 ), language );
        Objective3 = new LazyRow< SkyIsland2MissionDetail >( gameData, parser.ReadOffset< ushort >( 68 ), language );
        RequiredAmount1 = parser.ReadOffset< byte >( 70 );
        RequiredAmount2 = parser.ReadOffset< byte >( 71 );
        Unknown16 = parser.ReadOffset< byte >( 72 );
        Unknown8 = parser.ReadOffset< byte >( 73 );
        Unknown13 = parser.ReadOffset< byte >( 74 );
        Unknown18 = parser.ReadOffset< byte >( 75 );
        

    }
}
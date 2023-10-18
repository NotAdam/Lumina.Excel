// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Perform", columnHash: 0x7bf81fa9 )]
public partial class Perform : ExcelRow
{
    
    public LazyRow< ActionTimeline > AnimationPlay01 { get; private set; }
    public LazyRow< ActionTimeline > AnimationPlay02 { get; private set; }
    public SeString Instrument { get; private set; }
    public ulong ModelKey { get; private set; }
    public SeString Name { get; private set; }
    public LazyRow< ActionTimeline > StopAnimation { get; private set; }
    public int Order { get; private set; }
    public LazyRow< ActionTimeline > AnimationStart { get; private set; }
    public LazyRow< ActionTimeline > AnimationEnd { get; private set; }
    public LazyRow< ActionTimeline > AnimationIdle { get; private set; }
    public LazyRow< PerformTransient > Transient { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        AnimationPlay01 = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        AnimationPlay02 = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        Instrument = parser.ReadOffset< SeString >( 4 );
        ModelKey = parser.ReadOffset< ulong >( 8 );
        Name = parser.ReadOffset< SeString >( 16 );
        StopAnimation = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< int >( 20 ), language );
        Order = parser.ReadOffset< int >( 24 );
        AnimationStart = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 28 ), language );
        AnimationEnd = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 30 ), language );
        AnimationIdle = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 32 ), language );
        Transient = new LazyRow< PerformTransient >( gameData, parser.ReadOffset< byte >( 34 ), language );
        Unknown0 = parser.ReadOffset< byte >( 35 );
        Unknown1 = parser.ReadOffset< bool >( 36 );
        

    }
}
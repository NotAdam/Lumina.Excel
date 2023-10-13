// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EventAction", columnHash: 0x1c60d673 )]
public partial class EventAction : ExcelRow
{
    
    public SeString Name { get; private set; }
    public ushort Icon { get; private set; }
    public LazyRow< ActionTimeline > StartAnimation { get; private set; }
    public LazyRow< ActionTimeline > LoopAnimation { get; private set; }
    public LazyRow< ActionTimeline > EndAnimation { get; private set; }
    public byte CastTime { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< ushort >( 4 );
        StartAnimation = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        LoopAnimation = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        EndAnimation = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        CastTime = parser.ReadOffset< byte >( 12 );
        

    }
}
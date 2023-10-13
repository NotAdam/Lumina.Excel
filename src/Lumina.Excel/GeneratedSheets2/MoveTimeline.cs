// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MoveTimeline", columnHash: 0xf057da9c )]
public partial class MoveTimeline : ExcelRow
{
    
    public LazyRow< ActionTimeline > Idle { get; private set; }
    public LazyRow< ActionTimeline > MoveForward { get; private set; }
    public LazyRow< ActionTimeline > MoveBack { get; private set; }
    public LazyRow< ActionTimeline > MoveLeft { get; private set; }
    public LazyRow< ActionTimeline > MoveRight { get; private set; }
    public LazyRow< ActionTimeline > MoveUp { get; private set; }
    public LazyRow< ActionTimeline > MoveDown { get; private set; }
    public LazyRow< ActionTimeline > MoveTurnLeft { get; private set; }
    public LazyRow< ActionTimeline > MoveTurnRight { get; private set; }
    public LazyRow< ActionTimeline > Extra { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Idle = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        MoveForward = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        MoveBack = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        MoveLeft = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        MoveRight = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        MoveUp = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        MoveDown = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        MoveTurnLeft = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        MoveTurnRight = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        Extra = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 18 ), language );
        

    }
}
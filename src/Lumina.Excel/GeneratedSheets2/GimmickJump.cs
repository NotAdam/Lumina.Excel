// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GimmickJump", columnHash: 0x4858f2f1 )]
public partial class GimmickJump : ExcelRow
{
    
    public LazyRow< ActionTimeline > LoopMotion { get; private set; }
    public LazyRow< ActionTimeline > EndMotion { get; private set; }
    public ushort FallDamage { get; private set; }
    public sbyte Height { get; private set; }
    public bool StartClient { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LoopMotion = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< uint >( 0 ), language );
        EndMotion = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< uint >( 4 ), language );
        FallDamage = parser.ReadOffset< ushort >( 8 );
        Height = parser.ReadOffset< sbyte >( 10 );
        StartClient = parser.ReadOffset< bool >( 11 );
        Unknown5 = parser.ReadOffset< bool >( 11, 2 );
        

    }
}
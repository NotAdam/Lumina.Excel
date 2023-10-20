// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GimmickJump", columnHash: 0x914b082f )]
public partial class GimmickJump : ExcelRow
{
    
    public LazyRow< ActionTimeline > LoopMotion { get; private set; }
    public LazyRow< ActionTimeline > EndMotion { get; private set; }
    public ushort FallDamage { get; private set; }
    public ushort Height { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public bool StartClient { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LoopMotion = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< uint >( 0 ), language );
        EndMotion = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< uint >( 4 ), language );
        FallDamage = parser.ReadOffset< ushort >( 8 );
        Height = parser.ReadOffset< ushort >( 10 );
        Unknown1 = parser.ReadOffset< ushort >( 12 );
        Unknown2 = parser.ReadOffset< ushort >( 14 );
        StartClient = parser.ReadOffset< bool >( 16 );
        Unknown0 = parser.ReadOffset< bool >( 16, 2 );
        

    }
}
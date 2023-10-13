// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AOZReport", columnHash: 0x1a97b0af )]
public partial class AOZReport : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public LazyRow< AOZReportReward > Reward { get; private set; }
    public sbyte Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Reward = new LazyRow< AOZReportReward >( gameData, parser.ReadOffset< byte >( 4 ), language );
        Order = parser.ReadOffset< sbyte >( 5 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringPointTransient", columnHash: 0x7164626b )]
public partial class GatheringPointTransient : ExcelRow
{
    
    public LazyRow< GatheringRarePopTimeTable > GatheringRarePopTimeTable { get; private set; }
    public ushort EphemeralStartTime { get; private set; }
    public ushort EphemeralEndTime { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GatheringRarePopTimeTable = new LazyRow< GatheringRarePopTimeTable >( gameData, parser.ReadOffset< int >( 0 ), language );
        EphemeralStartTime = parser.ReadOffset< ushort >( 4 );
        EphemeralEndTime = parser.ReadOffset< ushort >( 6 );
        

    }
}
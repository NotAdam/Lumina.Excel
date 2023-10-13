// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringItemPoint", columnHash: 0xdbf43666 )]
public partial class GatheringItemPoint : ExcelRow
{
    
    public LazyRow< GatheringPoint > GatheringPoint { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GatheringPoint = new LazyRow< GatheringPoint >( gameData, parser.ReadOffset< uint >( 0 ), language );
        

    }
}
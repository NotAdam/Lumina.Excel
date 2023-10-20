// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringLeveRoute", columnHash: 0xf20ec1e1 )]
public partial class GatheringLeveRoute : ExcelRow
{
    
    public LazyRow< GatheringPoint >[] GatheringPoint { get; private set; }
    public LazyRow< Level >[] PopRange { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GatheringPoint = new LazyRow< GatheringPoint >[12];
        for (int i = 0; i < 12; i++)
        	GatheringPoint[i] = new LazyRow< GatheringPoint >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        PopRange = new LazyRow< Level >[12];
        for (int i = 0; i < 12; i++)
        	PopRange[i] = new LazyRow< Level >( gameData, parser.ReadOffset< int >( (ushort) ( 48 + i * 4 ) ), language );
        

    }
}
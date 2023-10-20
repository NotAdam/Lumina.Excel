// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HouseRetainerPose", columnHash: 0xd870e208 )]
public partial class HouseRetainerPose : ExcelRow
{
    
    public LazyRow< ActionTimeline > ActionTimeline { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ActionTimeline = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        

    }
}
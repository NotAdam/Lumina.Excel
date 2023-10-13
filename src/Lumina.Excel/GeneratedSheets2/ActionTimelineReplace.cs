// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionTimelineReplace", columnHash: 0x2020acf6 )]
public partial class ActionTimelineReplace : ExcelRow
{
    
    public LazyRow< ActionTimeline > Old { get; private set; }
    public LazyRow< ActionTimeline > New { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Old = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        New = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestEventAreaEntranceInfo", columnHash: 0xaeabafd3 )]
public partial class QuestEventAreaEntranceInfo : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< Level > Location { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Location = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Unknown0 = parser.ReadOffset< byte >( 8 );
        

    }
}
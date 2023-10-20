// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentTalk", columnHash: 0x5eb59ccb )]
public partial class ContentTalk : ExcelRow
{
    
    public SeString Text { get; private set; }
    public LazyRow< ContentTalkParam > ContentTalkParam { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        ContentTalkParam = new LazyRow< ContentTalkParam >( gameData, parser.ReadOffset< byte >( 4 ), language );
        

    }
}
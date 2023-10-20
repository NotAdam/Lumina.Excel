// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDInfoBoardArticle", columnHash: 0x76cb5660 )]
public partial class HWDInfoBoardArticle : ExcelRow
{
    
    public SeString Text { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< HWDInfoBoardArticleType > Type { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        Type = new LazyRow< HWDInfoBoardArticleType >( gameData, parser.ReadOffset< byte >( 6 ), language );
        Unknown1 = parser.ReadOffset< byte >( 7 );
        Unknown2 = parser.ReadOffset< bool >( 8 );
        

    }
}
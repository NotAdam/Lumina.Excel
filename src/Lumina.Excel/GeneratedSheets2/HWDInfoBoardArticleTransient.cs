// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDInfoBoardArticleTransient", columnHash: 0x11a44a12 )]
public partial class HWDInfoBoardArticleTransient : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString NpcName { get; private set; }
    public uint Image { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        NpcName = parser.ReadOffset< SeString >( 4 );
        Image = parser.ReadOffset< uint >( 8 );
        

    }
}
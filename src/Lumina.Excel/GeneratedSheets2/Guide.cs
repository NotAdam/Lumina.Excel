// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Guide", columnHash: 0x2020acf6 )]
public partial class Guide : ExcelRow
{
    
    public LazyRow< GuideTitle > GuideTitle { get; private set; }
    public LazyRow< GuidePage > GuidePage { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GuideTitle = new LazyRow< GuideTitle >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        GuidePage = new LazyRow< GuidePage >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        

    }
}
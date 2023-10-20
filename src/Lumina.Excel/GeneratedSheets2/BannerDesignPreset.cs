// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BannerDesignPreset", columnHash: 0xfccd960d )]
public partial class BannerDesignPreset : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< BannerBg > Background { get; private set; }
    public LazyRow< BannerFrame > Frame { get; private set; }
    public LazyRow< BannerDecoration > Decoration { get; private set; }
    public ushort SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Background = new LazyRow< BannerBg >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        Frame = new LazyRow< BannerFrame >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        Decoration = new LazyRow< BannerDecoration >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        SortKey = parser.ReadOffset< ushort >( 10 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BannerBg", columnHash: 0x1c6c81a1 )]
public partial class BannerBg : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Image { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Image = parser.ReadOffset< int >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        SortKey = parser.ReadOffset< ushort >( 14 );
        

    }
}
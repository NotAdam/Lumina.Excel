// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BannerFrame", columnHash: 0xdf1d09d9 )]
public partial class BannerFrame : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Image { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort Unknown_70_1 { get; private set; }
    public ushort Unknown_70_2 { get; private set; }
    public ushort SortKey { get; private set; }
    public byte Unknown_70_3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Image = parser.ReadOffset< int >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Unknown_70_1 = parser.ReadOffset< ushort >( 14 );
        Unknown_70_2 = parser.ReadOffset< ushort >( 16 );
        SortKey = parser.ReadOffset< ushort >( 18 );
        Unknown_70_3 = parser.ReadOffset< byte >( 20 );
        

    }
}
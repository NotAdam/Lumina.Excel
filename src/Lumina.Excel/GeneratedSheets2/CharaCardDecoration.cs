// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardDecoration", columnHash: 0x12d1b8be )]
public partial class CharaCardDecoration : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Image { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort SortKey { get; private set; }
    public byte Category { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Image = parser.ReadOffset< int >( 4 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        SortKey = parser.ReadOffset< ushort >( 10 );
        Category = parser.ReadOffset< byte >( 12 );
        Unknown1 = parser.ReadOffset< byte >( 13 );
        Unknown3 = parser.ReadOffset< byte >( 14 );
        

    }
}
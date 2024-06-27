// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardDecoration", columnHash: 0x33648d46 )]
public partial class CharaCardDecoration : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Image { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort Unknown_70_1 { get; private set; }
    public ushort Unknown_70_2 { get; private set; }
    public ushort SortKey { get; private set; }
    public byte Category { get; private set; }
    public byte Subtype { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Image = parser.ReadOffset< int >( 4 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Unknown_70_1 = parser.ReadOffset< ushort >( 10 );
        Unknown_70_2 = parser.ReadOffset< ushort >( 12 );
        SortKey = parser.ReadOffset< ushort >( 14 );
        Category = parser.ReadOffset< byte >( 16 );
        Subtype = parser.ReadOffset< byte >( 17 );
        Unknown1 = parser.ReadOffset< byte >( 18 );
        Unknown2 = parser.ReadOffset< byte >( 19 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardBase", columnHash: 0xa34815a3 )]
public partial class CharaCardBase : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Image { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort Unknown_70_1 { get; private set; }
    public ushort Unknown_70_2 { get; private set; }
    public ushort SortKey { get; private set; }
    public byte FontColor { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Image = parser.ReadOffset< int >( 4 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Unknown_70_1 = parser.ReadOffset< ushort >( 10 );
        Unknown_70_2 = parser.ReadOffset< ushort >( 12 );
        SortKey = parser.ReadOffset< ushort >( 14 );
        FontColor = parser.ReadOffset< byte >( 16 );
        Unknown3 = parser.ReadOffset< byte >( 17 );
        Unknown0 = parser.ReadOffset< byte >( 18 );
        Unknown1 = parser.ReadOffset< bool >( 19 );
        Unknown2 = parser.ReadOffset< bool >( 20 );
        

    }
}
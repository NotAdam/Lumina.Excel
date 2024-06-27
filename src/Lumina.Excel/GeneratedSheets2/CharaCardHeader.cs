// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardHeader", columnHash: 0xc2a2b3ab )]
public partial class CharaCardHeader : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int TopImage { get; private set; }
    public int BottomImage { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort Unknown_70_1 { get; private set; }
    public ushort Unknown_70_2 { get; private set; }
    public byte FontColor { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        TopImage = parser.ReadOffset< int >( 4 );
        BottomImage = parser.ReadOffset< int >( 8 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Unknown_70_1 = parser.ReadOffset< ushort >( 14 );
        Unknown_70_2 = parser.ReadOffset< ushort >( 16 );
        FontColor = parser.ReadOffset< byte >( 18 );
        Unknown0 = parser.ReadOffset< byte >( 19 );
        Unknown1 = parser.ReadOffset< byte >( 20 );
        Unknown2 = parser.ReadOffset< byte >( 21 );
        Unknown3 = parser.ReadOffset< byte >( 22 );
        SortKey = parser.ReadOffset< byte >( 23 );
        

    }
}
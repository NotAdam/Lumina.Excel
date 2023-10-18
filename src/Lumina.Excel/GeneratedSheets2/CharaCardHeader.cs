// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardHeader", columnHash: 0x738e3d77 )]
public partial class CharaCardHeader : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int TopImage { get; private set; }
    public int BottomImage { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
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
        FontColor = parser.ReadOffset< byte >( 14 );
        Unknown0 = parser.ReadOffset< byte >( 15 );
        Unknown1 = parser.ReadOffset< byte >( 16 );
        Unknown2 = parser.ReadOffset< byte >( 17 );
        Unknown3 = parser.ReadOffset< byte >( 18 );
        SortKey = parser.ReadOffset< byte >( 19 );
        

    }
}
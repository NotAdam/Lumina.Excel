// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardHeader", columnHash: 0xb42c2ccb )]
public partial class CharaCardHeader : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int TopImage { get; private set; }
    public int BottomImage { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public byte FontColor { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        TopImage = parser.ReadOffset< int >( 4 );
        BottomImage = parser.ReadOffset< int >( 8 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        FontColor = parser.ReadOffset< byte >( 14 );
        Unknown3 = parser.ReadOffset< byte >( 15 );
        Unknown4 = parser.ReadOffset< byte >( 16 );
        Unknown5 = parser.ReadOffset< byte >( 17 );
        SortKey = parser.ReadOffset< byte >( 18 );
        

    }
}
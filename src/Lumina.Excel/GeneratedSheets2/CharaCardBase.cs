// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardBase", columnHash: 0xa54aa43b )]
public partial class CharaCardBase : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Image { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort SortKey { get; private set; }
    public byte FontColor { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown4 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Image = parser.ReadOffset< int >( 4 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        SortKey = parser.ReadOffset< ushort >( 10 );
        FontColor = parser.ReadOffset< byte >( 12 );
        Unknown1 = parser.ReadOffset< byte >( 13 );
        Unknown4 = parser.ReadOffset< byte >( 14 );
        Unknown2 = parser.ReadOffset< bool >( 15 );
        Unknown3 = parser.ReadOffset< bool >( 16 );
        

    }
}
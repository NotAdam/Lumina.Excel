// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BannerFacial", columnHash: 0x6025f32a )]
public partial class BannerFacial : ExcelRow
{
    
    public LazyRow< Emote > Emote { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort Unknown_70_1 { get; private set; }
    public ushort Unknown_70_2 { get; private set; }
    public byte SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Emote = new LazyRow< Emote >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        Unknown_70_1 = parser.ReadOffset< ushort >( 4 );
        Unknown_70_2 = parser.ReadOffset< ushort >( 6 );
        SortKey = parser.ReadOffset< byte >( 8 );
        

    }
}
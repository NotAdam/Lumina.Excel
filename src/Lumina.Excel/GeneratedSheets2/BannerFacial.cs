// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BannerFacial", columnHash: 0xd8ae9355 )]
public partial class BannerFacial : ExcelRow
{
    
    public LazyRow< Emote > Emote { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public byte SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Emote = new LazyRow< Emote >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        SortKey = parser.ReadOffset< byte >( 4 );
        

    }
}
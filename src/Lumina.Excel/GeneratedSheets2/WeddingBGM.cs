// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeddingBGM", columnHash: 0x3d65a9f1 )]
public partial class WeddingBGM : ExcelRow
{
    
    public SeString SongName { get; private set; }
    public LazyRow< BGM > Song { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SongName = parser.ReadOffset< SeString >( 0 );
        Song = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FCAuthority", columnHash: 0x1ee79c01 )]
public partial class FCAuthority : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< FCAuthorityCategory > FCAuthorityCategory { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        FCAuthorityCategory = new LazyRow< FCAuthorityCategory >( gameData, parser.ReadOffset< int >( 4 ), language );
        Unknown0 = parser.ReadOffset< byte >( 8 );
        

    }
}
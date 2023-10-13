// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "JournalGenre", columnHash: 0x2c6b75bb )]
public partial class JournalGenre : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< JournalCategory > JournalCategory { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< int >( 4 );
        JournalCategory = new LazyRow< JournalCategory >( gameData, parser.ReadOffset< byte >( 8 ), language );
        Unknown2 = parser.ReadOffset< bool >( 9 );
        

    }
}
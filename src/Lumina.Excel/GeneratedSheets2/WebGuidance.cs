// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WebGuidance", columnHash: 0xa6cfe561 )]
public partial class WebGuidance : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Unknown3 { get; private set; }
    public SeString Description { get; private set; }
    public int Image { get; private set; }
    public LazyRow< WebURL > Url { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown3 = parser.ReadOffset< SeString >( 4 );
        Description = parser.ReadOffset< SeString >( 8 );
        Image = parser.ReadOffset< int >( 12 );
        Url = new LazyRow< WebURL >( gameData, parser.ReadOffset< byte >( 16 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HowTo", columnHash: 0xe4488448 )]
public partial class HowTo : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< HowToPage >[] HowToPagePC { get; private set; }
    public LazyRow< HowToPage >[] HowToPageController { get; private set; }
    public byte Sort { get; private set; }
    public LazyRow< HowToCategory > Category { get; private set; }
    public bool Announce { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        HowToPagePC = new LazyRow< HowToPage >[5];
        for (int i = 0; i < 5; i++)
        	HowToPagePC[i] = new LazyRow< HowToPage >( gameData, parser.ReadOffset< short >( (ushort) ( 4 + i * 2 ) ), language );
        HowToPageController = new LazyRow< HowToPage >[5];
        for (int i = 0; i < 5; i++)
        	HowToPageController[i] = new LazyRow< HowToPage >( gameData, parser.ReadOffset< short >( (ushort) ( 14 + i * 2 ) ), language );
        Sort = parser.ReadOffset< byte >( 24 );
        Category = new LazyRow< HowToCategory >( gameData, parser.ReadOffset< sbyte >( 25 ), language );
        Announce = parser.ReadOffset< bool >( 26 );
        

    }
}
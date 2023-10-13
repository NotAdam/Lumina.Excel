// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringSubCategory", columnHash: 0x6dac8145 )]
public partial class GatheringSubCategory : ExcelRow
{
    
    public SeString FolkloreBook { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public ushort Division { get; private set; }
    public LazyRow< GatheringType > GatheringType { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    public byte Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        FolkloreBook = parser.ReadOffset< SeString >( 0 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 8 ), language );
        Division = parser.ReadOffset< ushort >( 12 );
        GatheringType = new LazyRow< GatheringType >( gameData, parser.ReadOffset< byte >( 14 ), language );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 15 ), language );
        Unknown6 = parser.ReadOffset< byte >( 16 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FateProgressUI", columnHash: 0x23c37548 )]
public partial class FateProgressUI : ExcelRow
{
    
    public LazyRow< TerritoryType > Location { get; private set; }
    public LazyRow< Achievement > Achievement { get; private set; }
    public byte ReqFatesToRank2 { get; private set; }
    public byte ReqFatesToRank3 { get; private set; }
    public byte DisplayOrder { get; private set; }
    public sbyte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Location = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< int >( 0 ), language );
        Achievement = new LazyRow< Achievement >( gameData, parser.ReadOffset< int >( 4 ), language );
        ReqFatesToRank2 = parser.ReadOffset< byte >( 8 );
        ReqFatesToRank3 = parser.ReadOffset< byte >( 9 );
        DisplayOrder = parser.ReadOffset< byte >( 10 );
        Unknown0 = parser.ReadOffset< sbyte >( 11 );
        

    }
}
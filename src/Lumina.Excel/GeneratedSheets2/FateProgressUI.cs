// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FateProgressUI", columnHash: 0xbccd5130 )]
public partial class FateProgressUI : ExcelRow
{
    
    public LazyRow< TerritoryType > Location { get; private set; }
    public byte ReqFatesToRank2 { get; private set; }
    public byte ReqFatesToRank3 { get; private set; }
    public byte ReqFatesToRank4 { get; private set; }
    public byte DisplayOrder { get; private set; }
    public sbyte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Location = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< int >( 0 ), language );
        ReqFatesToRank2 = parser.ReadOffset< byte >( 4 );
        ReqFatesToRank3 = parser.ReadOffset< byte >( 5 );
        ReqFatesToRank4 = parser.ReadOffset< byte >( 6 );
        DisplayOrder = parser.ReadOffset< byte >( 7 );
        Unknown0 = parser.ReadOffset< sbyte >( 8 );
        

    }
}
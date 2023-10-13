// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingAethernet", columnHash: 0x751baa92 )]
public partial class HousingAethernet : ExcelRow
{
    
    public LazyRow< Level > Level { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public byte Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Level = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( 0 ), language );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        Order = parser.ReadOffset< byte >( 8 );
        

    }
}
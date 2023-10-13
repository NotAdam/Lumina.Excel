// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "IKDSpot", columnHash: 0x96a22aea )]
public partial class IKDSpot : ExcelRow
{
    
    public LazyRow< FishingSpot > SpotMain { get; private set; }
    public LazyRow< FishingSpot > SpotSub { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SpotMain = new LazyRow< FishingSpot >( gameData, parser.ReadOffset< uint >( 0 ), language );
        SpotSub = new LazyRow< FishingSpot >( gameData, parser.ReadOffset< uint >( 4 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< uint >( 8 ), language );
        

    }
}
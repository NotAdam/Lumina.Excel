// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MapMarker", columnHash: 0x58f22163 )]
public partial class MapMarker : ExcelRow
{
    
    public ushort Icon { get; private set; }
    public LazyRow< PlaceName > PlaceNameSubtext { get; private set; }
    public ILazyRow DataKey { get; private set; }
    public short X { get; private set; }
    public short Y { get; private set; }
    public byte SubtextOrientation { get; private set; }
    public LazyRow< MapMarkerRegion > MapMarkerRegion { get; private set; }
    public byte Type { get; private set; }
    public byte DataType { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< ushort >( 0 );
        PlaceNameSubtext = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        var DataKeyRowId = parser.ReadOffset< ushort >( 4 );
        X = parser.ReadOffset< short >( 6 );
        Y = parser.ReadOffset< short >( 8 );
        SubtextOrientation = parser.ReadOffset< byte >( 10 );
        MapMarkerRegion = new LazyRow< MapMarkerRegion >( gameData, parser.ReadOffset< byte >( 11 ), language );
        Type = parser.ReadOffset< byte >( 12 );
        DataType = parser.ReadOffset< byte >( 13 );
        Unknown9 = parser.ReadOffset< byte >( 14 );
        Unknown10 = parser.ReadOffset< byte >( 15 );
        
        DataKey = DataType switch
        {
        	1 => new LazyRow< Map >( gameData, DataKeyRowId, language ),
        	2 => new LazyRow< Map >( gameData, DataKeyRowId, language ),
        	3 => new LazyRow< Aetheryte >( gameData, DataKeyRowId, language ),
        	4 => new LazyRow< PlaceName >( gameData, DataKeyRowId, language ),
        	_ => new EmptyLazyRow( (uint) DataKeyRowId ),
        };
    }
}
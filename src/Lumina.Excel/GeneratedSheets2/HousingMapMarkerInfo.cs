// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingMapMarkerInfo", columnHash: 0x13236296 )]
public partial class HousingMapMarkerInfo : ExcelRow
{
    
    public float X { get; private set; }
    public float Y { get; private set; }
    public float Z { get; private set; }
    public float Unknown3 { get; private set; }
    public LazyRow< Map > Map { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        X = parser.ReadOffset< float >( 0 );
        Y = parser.ReadOffset< float >( 4 );
        Z = parser.ReadOffset< float >( 8 );
        Unknown3 = parser.ReadOffset< float >( 12 );
        Map = new LazyRow< Map >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        

    }
}
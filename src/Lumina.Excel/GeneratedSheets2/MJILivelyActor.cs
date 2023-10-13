// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJILivelyActor", columnHash: 0xc8ec8dc5 )]
public partial class MJILivelyActor : ExcelRow
{
    
    public float X { get; private set; }
    public float Y { get; private set; }
    public float Z { get; private set; }
    public float Rot { get; private set; }
    public LazyRow< ENpcResident > ENPC { get; private set; }
    public LazyRow< Behavior > Behavior { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        X = parser.ReadOffset< float >( 0 );
        Y = parser.ReadOffset< float >( 4 );
        Z = parser.ReadOffset< float >( 8 );
        Rot = parser.ReadOffset< float >( 12 );
        ENPC = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 16 ), language );
        Behavior = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 20 ), language );
        

    }
}
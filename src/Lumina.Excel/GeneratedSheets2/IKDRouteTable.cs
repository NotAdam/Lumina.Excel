// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "IKDRouteTable", columnHash: 0x5d58cc84 )]
public partial class IKDRouteTable : ExcelRow
{
    
    public LazyRow< IKDRoute > Route { get; private set; }
    public uint Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Route = new LazyRow< IKDRoute >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        

    }
}
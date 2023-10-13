// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TreasureSpot", columnHash: 0x4a63eb8e )]
public partial class TreasureSpot : ExcelRow
{
    
    public float MapOffsetX { get; private set; }
    public float MapOffsetY { get; private set; }
    public LazyRow< Level > Location { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        MapOffsetX = parser.ReadOffset< float >( 0 );
        MapOffsetY = parser.ReadOffset< float >( 4 );
        Location = new LazyRow< Level >( gameData, parser.ReadOffset< int >( 8 ), language );
        

    }
}
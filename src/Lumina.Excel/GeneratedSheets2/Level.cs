// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Level", columnHash: 0xd3d8d868 )]
public partial class Level : ExcelRow
{
    
    public float X { get; private set; }
    public float Y { get; private set; }
    public float Z { get; private set; }
    public float Yaw { get; private set; }
    public float Radius { get; private set; }
    public ILazyRow Object { get; private set; }
    public ILazyRow EventId { get; private set; }
    public LazyRow< Map > Map { get; private set; }
    public LazyRow< TerritoryType > Territory { get; private set; }
    public byte Type { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        X = parser.ReadOffset< float >( 0 );
        Y = parser.ReadOffset< float >( 4 );
        Z = parser.ReadOffset< float >( 8 );
        Yaw = parser.ReadOffset< float >( 12 );
        Radius = parser.ReadOffset< float >( 16 );
        var ObjectRowId = parser.ReadOffset< uint >( 20 );
        EventId = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 24 ), language, "TripleTriad", "Adventure", "Opening", "Quest" );
        Map = new LazyRow< Map >( gameData, parser.ReadOffset< ushort >( 28 ), language );
        Territory = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 30 ), language );
        Type = parser.ReadOffset< byte >( 32 );
        
        Object = Type switch
        {
        	8 => new LazyRow< ENpcBase >( gameData, ObjectRowId, language ),
        	9 => new LazyRow< BNpcBase >( gameData, ObjectRowId, language ),
        	12 => new LazyRow< Aetheryte >( gameData, ObjectRowId, language ),
        	14 => new LazyRow< GatheringPoint >( gameData, ObjectRowId, language ),
        	45 => new LazyRow< EObj >( gameData, ObjectRowId, language ),
        	_ => new EmptyLazyRow( (uint) ObjectRowId ),
        };
    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DeepDungeonLayer", columnHash: 0x832a5a83 )]
public partial class DeepDungeonLayer : ExcelRow
{
    
    public LazyRow< DeepDungeonMap5X > RoomA { get; private set; }
    public LazyRow< DeepDungeonMap5X > RoomB { get; private set; }
    public LazyRow< DeepDungeonMap5X > RoomC { get; private set; }
    public LazyRow< DeepDungeon > DeepDungeon { get; private set; }
    public byte FloorSet { get; private set; }
    public byte WepMinLv { get; private set; }
    public byte ArmourMinLv { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        RoomA = new LazyRow< DeepDungeonMap5X >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        RoomB = new LazyRow< DeepDungeonMap5X >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        RoomC = new LazyRow< DeepDungeonMap5X >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        DeepDungeon = new LazyRow< DeepDungeon >( gameData, parser.ReadOffset< byte >( 6 ), language );
        FloorSet = parser.ReadOffset< byte >( 7 );
        WepMinLv = parser.ReadOffset< byte >( 8 );
        ArmourMinLv = parser.ReadOffset< byte >( 9 );
        

    }
}
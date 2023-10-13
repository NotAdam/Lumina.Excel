// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DeepDungeon", columnHash: 0x2b582528 )]
public partial class DeepDungeon : ExcelRow
{
    
    public LazyRow< DeepDungeonItem >[] PomanderSlot { get; private set; }
    public LazyRow< DeepDungeonMagicStone >[] MagiciteSlot { get; private set; }
    public SeString Name { get; private set; }
    public LazyRow< ContentFinderCondition > ContentFinderConditionStart { get; private set; }
    public LazyRow< DeepDungeonEquipment > AetherpoolArm { get; private set; }
    public LazyRow< DeepDungeonEquipment > AetherpoolArmor { get; private set; }
    public byte Unknown18 { get; private set; }
    public bool Unknown25 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        PomanderSlot = new LazyRow< DeepDungeonItem >[16];
        for (int i = 0; i < 16; i++)
        	PomanderSlot[i] = new LazyRow< DeepDungeonItem >( gameData, parser.ReadOffset< byte >( (ushort) ( 0 + i * 1 ) ), language );
        MagiciteSlot = new LazyRow< DeepDungeonMagicStone >[4];
        for (int i = 0; i < 4; i++)
        	MagiciteSlot[i] = new LazyRow< DeepDungeonMagicStone >( gameData, parser.ReadOffset< byte >( (ushort) ( 16 + i * 1 ) ), language );
        Name = parser.ReadOffset< SeString >( 20 );
        ContentFinderConditionStart = new LazyRow< ContentFinderCondition >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        AetherpoolArm = new LazyRow< DeepDungeonEquipment >( gameData, parser.ReadOffset< byte >( 26 ), language );
        AetherpoolArmor = new LazyRow< DeepDungeonEquipment >( gameData, parser.ReadOffset< byte >( 27 ), language );
        Unknown18 = parser.ReadOffset< byte >( 28 );
        Unknown25 = parser.ReadOffset< bool >( 29 );
        

    }
}
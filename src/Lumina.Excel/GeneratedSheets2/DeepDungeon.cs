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
    public ILazyRow[] MagiciteSlot { get; private set; }
    public SeString Name { get; private set; }
    public LazyRow< ContentFinderCondition > ContentFinderConditionStart { get; private set; }
    public LazyRow< DeepDungeonEquipment > AetherpoolArm { get; private set; }
    public LazyRow< DeepDungeonEquipment > AetherpoolArmor { get; private set; }
    public byte DeepDungeonType { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        PomanderSlot = new LazyRow< DeepDungeonItem >[16];
        for (int i = 0; i < 16; i++)
        	PomanderSlot[i] = new LazyRow< DeepDungeonItem >( gameData, parser.ReadOffset< byte >( (ushort) ( 0 + i * 1 ) ), language );
        MagiciteSlot = new ILazyRow[ 4 ];
        UIntSpan MagiciteSlotRowId = stackalloc uint[ 4 ];
        for( int i = 0; i < 4; i++ )
        {
        	MagiciteSlotRowId[ i ] = (uint) parser.ReadOffset< int >( 16 + ( i * 4 ) );
        }
        Name = parser.ReadOffset< SeString >( 20 );
        ContentFinderConditionStart = new LazyRow< ContentFinderCondition >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        AetherpoolArm = new LazyRow< DeepDungeonEquipment >( gameData, parser.ReadOffset< byte >( 26 ), language );
        AetherpoolArmor = new LazyRow< DeepDungeonEquipment >( gameData, parser.ReadOffset< byte >( 27 ), language );
        DeepDungeonType = parser.ReadOffset< byte >( 28 );
        Unknown1 = parser.ReadOffset< bool >( 29 );
        
        for( int i = 0; i < 4; i++ )
        {
        	MagiciteSlot[ i ] = DeepDungeonType switch
        	{
        		1 => new LazyRow< DeepDungeonMagicStone >( gameData, MagiciteSlotRowId[i], language ),
        		2 => new LazyRow< DeepDungeonDemiclone >( gameData, MagiciteSlotRowId[i], language ),
        		_ => new EmptyLazyRow( (uint) MagiciteSlotRowId[i] ),
        	};
        }
    }
}
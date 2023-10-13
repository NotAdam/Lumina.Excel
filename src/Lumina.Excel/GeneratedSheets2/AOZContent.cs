// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AOZContent", columnHash: 0xb05ff0c9 )]
public partial class AOZContent : ExcelRow
{
    
    public ushort GilReward { get; private set; }
    public ushort AlliedSealsReward { get; private set; }
    public ushort TomestonesReward { get; private set; }
    public LazyRow< ContentEntry > ContentEntry { get; private set; }
    public ushort StandardFinishTime { get; private set; }
    public ushort IdealFinishTime { get; private set; }
    public ILazyRow Act1 { get; private set; }
    public ILazyRow Act2 { get; private set; }
    public ILazyRow Act3 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown9 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public byte Act1FightType { get; private set; }
    public byte Act2FightType { get; private set; }
    public byte Act3FightType { get; private set; }
    public byte ArenaType1 { get; private set; }
    public byte ArenaType2 { get; private set; }
    public byte ArenaType3 { get; private set; }
    public byte Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GilReward = parser.ReadOffset< ushort >( 0 );
        AlliedSealsReward = parser.ReadOffset< ushort >( 2 );
        TomestonesReward = parser.ReadOffset< ushort >( 4 );
        ContentEntry = new LazyRow< ContentEntry >( gameData, parser.ReadOffset< uint >( 8 ), language );
        StandardFinishTime = parser.ReadOffset< ushort >( 12 );
        IdealFinishTime = parser.ReadOffset< ushort >( 14 );
        var Act1RowId = parser.ReadOffset< ushort >( 16 );
        var Act2RowId = parser.ReadOffset< ushort >( 18 );
        var Act3RowId = parser.ReadOffset< ushort >( 20 );
        Unknown5 = parser.ReadOffset< ushort >( 22 );
        Unknown9 = parser.ReadOffset< ushort >( 24 );
        Unknown13 = parser.ReadOffset< ushort >( 26 );
        Act1FightType = parser.ReadOffset< byte >( 28 );
        Act2FightType = parser.ReadOffset< byte >( 29 );
        Act3FightType = parser.ReadOffset< byte >( 30 );
        ArenaType1 = parser.ReadOffset< byte >( 31 );
        ArenaType2 = parser.ReadOffset< byte >( 32 );
        ArenaType3 = parser.ReadOffset< byte >( 33 );
        Order = parser.ReadOffset< byte >( 34 );
        
        Act1 = Act1FightType switch
        {
        	1 => new LazyRow< AOZArrangement >( gameData, Act1RowId, language ),
        	2 => new LazyRow< AOZBoss >( gameData, Act1RowId, language ),
        	_ => new EmptyLazyRow( (uint) Act1RowId ),
        };
        Act2 = Act2FightType switch
        {
        	1 => new LazyRow< AOZArrangement >( gameData, Act2RowId, language ),
        	2 => new LazyRow< AOZBoss >( gameData, Act2RowId, language ),
        	_ => new EmptyLazyRow( (uint) Act2RowId ),
        };
        Act3 = Act3FightType switch
        {
        	1 => new LazyRow< AOZArrangement >( gameData, Act3RowId, language ),
        	2 => new LazyRow< AOZBoss >( gameData, Act3RowId, language ),
        	_ => new EmptyLazyRow( (uint) Act3RowId ),
        };
    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RetainerTask", columnHash: 0x99415e4e )]
public partial class RetainerTask : ExcelRow
{
    
    public int Experience { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< RetainerTaskParameter > RetainerTaskParameter { get; private set; }
    public ushort VentureCost { get; private set; }
    public ushort MaxTimemin { get; private set; }
    public ushort RequiredItemLevel { get; private set; }
    public ushort RequiredGathering { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ILazyRow Task { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte RetainerLevel { get; private set; }
    public byte ConditionParam0 { get; private set; }
    public byte ConditionParam1 { get; private set; }
    public bool IsRandom { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Experience = parser.ReadOffset< int >( 0 );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        RetainerTaskParameter = new LazyRow< RetainerTaskParameter >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        VentureCost = parser.ReadOffset< ushort >( 8 );
        MaxTimemin = parser.ReadOffset< ushort >( 10 );
        RequiredItemLevel = parser.ReadOffset< ushort >( 12 );
        RequiredGathering = parser.ReadOffset< ushort >( 14 );
        Unknown1 = parser.ReadOffset< ushort >( 16 );
        Task = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< ushort >( 18 ), language, "RetainerTaskNormal", "RetainerTaskRandom" );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 20 ), language );
        RetainerLevel = parser.ReadOffset< byte >( 21 );
        ConditionParam0 = parser.ReadOffset< byte >( 22 );
        ConditionParam1 = parser.ReadOffset< byte >( 23 );
        IsRandom = parser.ReadOffset< bool >( 24 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AozActionTransient", columnHash: 0x4921bb28 )]
public partial class AozActionTransient : ExcelRow
{
    
    public SeString Stats { get; private set; }
    public SeString Description { get; private set; }
    public uint Icon { get; private set; }
    public LazyRow< Quest > RequiredForQuest { get; private set; }
    public LazyRow< Quest > PreviousQuest { get; private set; }
    public ILazyRow Location { get; private set; }
    public byte Number { get; private set; }
    public byte LocationKey { get; private set; }
    public bool TargetsEnemy { get; private set; }
    public bool TargetsSelfOrAlly { get; private set; }
    public bool CauseSlow { get; private set; }
    public bool CausePetrify { get; private set; }
    public bool CauseParalysis { get; private set; }
    public bool CauseInterrupt { get; private set; }
    public bool CauseBlind { get; private set; }
    public bool CauseStun { get; private set; }
    public bool CauseSleep { get; private set; }
    public bool CauseBind { get; private set; }
    public bool CauseHeavy { get; private set; }
    public bool CauseDeath { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Stats = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        RequiredForQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 12 ), language );
        PreviousQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 16 ), language );
        var LocationRowId = parser.ReadOffset< ushort >( 20 );
        Number = parser.ReadOffset< byte >( 22 );
        LocationKey = parser.ReadOffset< byte >( 23 );
        TargetsEnemy = parser.ReadOffset< bool >( 24 );
        TargetsSelfOrAlly = parser.ReadOffset< bool >( 24, 2 );
        CauseSlow = parser.ReadOffset< bool >( 24, 4 );
        CausePetrify = parser.ReadOffset< bool >( 24, 8 );
        CauseParalysis = parser.ReadOffset< bool >( 24, 16 );
        CauseInterrupt = parser.ReadOffset< bool >( 24, 32 );
        CauseBlind = parser.ReadOffset< bool >( 24, 64 );
        CauseStun = parser.ReadOffset< bool >( 24, 128 );
        CauseSleep = parser.ReadOffset< bool >( 25 );
        CauseBind = parser.ReadOffset< bool >( 25, 2 );
        CauseHeavy = parser.ReadOffset< bool >( 25, 4 );
        CauseDeath = parser.ReadOffset< bool >( 25, 8 );
        
        Location = LocationKey switch
        {
        	1 => new LazyRow< PlaceName >( gameData, LocationRowId, language ),
        	4 => new LazyRow< ContentFinderCondition >( gameData, LocationRowId, language ),
        	_ => new EmptyLazyRow( (uint) LocationRowId ),
        };
    }
}
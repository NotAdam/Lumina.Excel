// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CraftAction", columnHash: 0x6057073b )]
public partial class CraftAction : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public LazyRow< Quest > QuestRequirement { get; private set; }
    public LazyRow< CraftAction > CRP { get; private set; }
    public LazyRow< CraftAction > BSM { get; private set; }
    public LazyRow< CraftAction > ARM { get; private set; }
    public LazyRow< CraftAction > GSM { get; private set; }
    public LazyRow< CraftAction > LTW { get; private set; }
    public LazyRow< CraftAction > WVR { get; private set; }
    public LazyRow< CraftAction > ALC { get; private set; }
    public LazyRow< CraftAction > CUL { get; private set; }
    public LazyRow< ActionTimeline > AnimationStart { get; private set; }
    public LazyRow< ActionTimeline > AnimationEnd { get; private set; }
    public ushort Icon { get; private set; }
    public ushort Unknown10 { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte ClassJobLevel { get; private set; }
    public byte Cost { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    public bool Specialist { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        QuestRequirement = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 8 ), language );
        CRP = new LazyRow< CraftAction >( gameData, parser.ReadOffset< int >( 12 ), language );
        BSM = new LazyRow< CraftAction >( gameData, parser.ReadOffset< int >( 16 ), language );
        ARM = new LazyRow< CraftAction >( gameData, parser.ReadOffset< int >( 20 ), language );
        GSM = new LazyRow< CraftAction >( gameData, parser.ReadOffset< int >( 24 ), language );
        LTW = new LazyRow< CraftAction >( gameData, parser.ReadOffset< int >( 28 ), language );
        WVR = new LazyRow< CraftAction >( gameData, parser.ReadOffset< int >( 32 ), language );
        ALC = new LazyRow< CraftAction >( gameData, parser.ReadOffset< int >( 36 ), language );
        CUL = new LazyRow< CraftAction >( gameData, parser.ReadOffset< int >( 40 ), language );
        AnimationStart = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 44 ), language );
        AnimationEnd = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 46 ), language );
        Icon = parser.ReadOffset< ushort >( 48 );
        Unknown10 = parser.ReadOffset< ushort >( 50 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 52 ), language );
        ClassJobLevel = parser.ReadOffset< byte >( 53 );
        Cost = parser.ReadOffset< byte >( 54 );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< sbyte >( 55 ), language );
        Specialist = parser.ReadOffset< bool >( 56 );
        

    }
}
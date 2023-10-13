// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentFinderCondition", columnHash: 0xc43e7247 )]
public partial class ContentFinderCondition : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString NameShort { get; private set; }
    public bool LevelingRoulette { get; private set; }
    public bool HighLevelRoulette { get; private set; }
    public bool MSQRoulette { get; private set; }
    public bool GuildHestRoulette { get; private set; }
    public bool ExpertRoulette { get; private set; }
    public bool TrialRoulette { get; private set; }
    public bool DailyFrontlineChallenge { get; private set; }
    public bool LevelCapRoulette { get; private set; }
    public bool MentorRoulette { get; private set; }
    public bool Unknown62 { get; private set; }
    public bool Unknown63 { get; private set; }
    public bool Unknown64 { get; private set; }
    public bool Unknown65 { get; private set; }
    public bool Unknown66 { get; private set; }
    public bool AllianceRoulette { get; private set; }
    public bool FeastTeamRoulette { get; private set; }
    public bool NormalRaidRoulette { get; private set; }
    public bool Unknown70 { get; private set; }
    public bool Unknown71 { get; private set; }
    public bool Unknown72 { get; private set; }
    public bool Unknown73 { get; private set; }
    public bool Unknown74 { get; private set; }
    public bool Unknown75 { get; private set; }
    public bool Unknown76 { get; private set; }
    public bool Unknown77 { get; private set; }
    public bool Unknown78 { get; private set; }
    public bool Unknown79 { get; private set; }
    public bool Unknown80 { get; private set; }
    public bool Unknown81 { get; private set; }
    public bool Unknown82 { get; private set; }
    public bool Unknown83 { get; private set; }
    public bool Unknown84 { get; private set; }
    public bool Unknown85 { get; private set; }
    public bool Unknown86 { get; private set; }
    public bool Unknown87 { get; private set; }
    public bool Unknown88 { get; private set; }
    public bool Unknown89 { get; private set; }
    public bool Unknown90 { get; private set; }
    public bool Unknown91 { get; private set; }
    public bool Unknown92 { get; private set; }
    public bool Unknown93 { get; private set; }
    public SeString ShortCode { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Unknown7 { get; private set; }
    public LazyRow< Quest > UnlockQuest { get; private set; }
    public uint Unknown15 { get; private set; }
    public ILazyRow Transient { get; private set; }
    public uint Image { get; private set; }
    public uint Icon { get; private set; }
    public int Unknown50 { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public ILazyRow Content { get; private set; }
    public ushort ItemLevelRequired { get; private set; }
    public ushort ItemLevelSync { get; private set; }
    public ushort SortKey { get; private set; }
    public byte ContentLinkType { get; private set; }
    public byte Unknown5 { get; private set; }
    public LazyRow< ClassJobCategory > AcceptClassJobCategory { get; private set; }
    public LazyRow< ContentMemberType > ContentMemberType { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte ClassJobLevelRequired { get; private set; }
    public byte ClassJobLevelSync { get; private set; }
    public byte Unknown28 { get; private set; }
    public byte Unknown33 { get; private set; }
    public LazyRow< ContentType > ContentType { get; private set; }
    public byte TransientKey { get; private set; }
    public byte Unknown52 { get; private set; }
    public sbyte Unknown49 { get; private set; }
    public bool PvP { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool AllowUndersized { get; private set; }
    public bool Unknown22 { get; private set; }
    public bool AllowReplacement { get; private set; }
    public bool Unknown24 { get; private set; }
    public bool AllowExplorerMode { get; private set; }
    public bool Unknown26 { get; private set; }
    public bool Unknown27 { get; private set; }
    public bool Unknown29 { get; private set; }
    public bool Unknown30 { get; private set; }
    public bool HighEndDuty { get; private set; }
    public bool Unknown32 { get; private set; }
    public bool Unknown34 { get; private set; }
    public bool Unknown35 { get; private set; }
    public bool DutyRecorderAllowed { get; private set; }
    public bool Unknown37 { get; private set; }
    public bool Unknown38 { get; private set; }
    public bool Unknown39 { get; private set; }
    public bool Unknown40 { get; private set; }
    public bool Unknown51 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        NameShort = parser.ReadOffset< SeString >( 4 );
        LevelingRoulette = parser.ReadOffset< bool >( 8 );
        HighLevelRoulette = parser.ReadOffset< bool >( 9 );
        MSQRoulette = parser.ReadOffset< bool >( 10 );
        GuildHestRoulette = parser.ReadOffset< bool >( 11 );
        ExpertRoulette = parser.ReadOffset< bool >( 12 );
        TrialRoulette = parser.ReadOffset< bool >( 13 );
        DailyFrontlineChallenge = parser.ReadOffset< bool >( 14 );
        LevelCapRoulette = parser.ReadOffset< bool >( 15 );
        MentorRoulette = parser.ReadOffset< bool >( 16 );
        Unknown62 = parser.ReadOffset< bool >( 17 );
        Unknown63 = parser.ReadOffset< bool >( 18 );
        Unknown64 = parser.ReadOffset< bool >( 19 );
        Unknown65 = parser.ReadOffset< bool >( 20 );
        Unknown66 = parser.ReadOffset< bool >( 21 );
        AllianceRoulette = parser.ReadOffset< bool >( 22 );
        FeastTeamRoulette = parser.ReadOffset< bool >( 23 );
        NormalRaidRoulette = parser.ReadOffset< bool >( 24 );
        Unknown70 = parser.ReadOffset< bool >( 25 );
        Unknown71 = parser.ReadOffset< bool >( 26 );
        Unknown72 = parser.ReadOffset< bool >( 27 );
        Unknown73 = parser.ReadOffset< bool >( 28 );
        Unknown74 = parser.ReadOffset< bool >( 29 );
        Unknown75 = parser.ReadOffset< bool >( 30 );
        Unknown76 = parser.ReadOffset< bool >( 31 );
        Unknown77 = parser.ReadOffset< bool >( 32 );
        Unknown78 = parser.ReadOffset< bool >( 33 );
        Unknown79 = parser.ReadOffset< bool >( 34 );
        Unknown80 = parser.ReadOffset< bool >( 35 );
        Unknown81 = parser.ReadOffset< bool >( 36 );
        Unknown82 = parser.ReadOffset< bool >( 37 );
        Unknown83 = parser.ReadOffset< bool >( 38 );
        Unknown84 = parser.ReadOffset< bool >( 39 );
        Unknown85 = parser.ReadOffset< bool >( 40 );
        Unknown86 = parser.ReadOffset< bool >( 41 );
        Unknown87 = parser.ReadOffset< bool >( 42 );
        Unknown88 = parser.ReadOffset< bool >( 43 );
        Unknown89 = parser.ReadOffset< bool >( 44 );
        Unknown90 = parser.ReadOffset< bool >( 45 );
        Unknown91 = parser.ReadOffset< bool >( 46 );
        Unknown92 = parser.ReadOffset< bool >( 47 );
        Unknown93 = parser.ReadOffset< bool >( 48 );
        ShortCode = parser.ReadOffset< SeString >( 52 );
        Unknown6 = parser.ReadOffset< uint >( 56 );
        Unknown7 = parser.ReadOffset< uint >( 60 );
        UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 64 ), language );
        Unknown15 = parser.ReadOffset< uint >( 68 );
        var TransientRowId = parser.ReadOffset< uint >( 72 );
        Image = parser.ReadOffset< uint >( 76 );
        Icon = parser.ReadOffset< uint >( 80 );
        Unknown50 = parser.ReadOffset< int >( 84 );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 88 ), language );
        var ContentRowId = parser.ReadOffset< ushort >( 90 );
        ItemLevelRequired = parser.ReadOffset< ushort >( 92 );
        ItemLevelSync = parser.ReadOffset< ushort >( 94 );
        SortKey = parser.ReadOffset< ushort >( 96 );
        ContentLinkType = parser.ReadOffset< byte >( 98 );
        Unknown5 = parser.ReadOffset< byte >( 99 );
        AcceptClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 100 ), language );
        ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadOffset< byte >( 101 ), language );
        Unknown10 = parser.ReadOffset< byte >( 102 );
        Unknown11 = parser.ReadOffset< byte >( 103 );
        Unknown12 = parser.ReadOffset< byte >( 104 );
        Unknown14 = parser.ReadOffset< byte >( 105 );
        ClassJobLevelRequired = parser.ReadOffset< byte >( 106 );
        ClassJobLevelSync = parser.ReadOffset< byte >( 107 );
        Unknown28 = parser.ReadOffset< byte >( 108 );
        Unknown33 = parser.ReadOffset< byte >( 109 );
        ContentType = new LazyRow< ContentType >( gameData, parser.ReadOffset< byte >( 110 ), language );
        TransientKey = parser.ReadOffset< byte >( 111 );
        Unknown52 = parser.ReadOffset< byte >( 112 );
        Unknown49 = parser.ReadOffset< sbyte >( 113 );
        PvP = parser.ReadOffset< bool >( 114 );
        Unknown20 = parser.ReadOffset< bool >( 114, 2 );
        AllowUndersized = parser.ReadOffset< bool >( 114, 4 );
        Unknown22 = parser.ReadOffset< bool >( 114, 8 );
        AllowReplacement = parser.ReadOffset< bool >( 114, 16 );
        Unknown24 = parser.ReadOffset< bool >( 114, 32 );
        AllowExplorerMode = parser.ReadOffset< bool >( 114, 64 );
        Unknown26 = parser.ReadOffset< bool >( 114, 128 );
        Unknown27 = parser.ReadOffset< bool >( 115 );
        Unknown29 = parser.ReadOffset< bool >( 115, 2 );
        Unknown30 = parser.ReadOffset< bool >( 115, 4 );
        HighEndDuty = parser.ReadOffset< bool >( 115, 8 );
        Unknown32 = parser.ReadOffset< bool >( 115, 16 );
        Unknown34 = parser.ReadOffset< bool >( 115, 32 );
        Unknown35 = parser.ReadOffset< bool >( 115, 64 );
        DutyRecorderAllowed = parser.ReadOffset< bool >( 115, 128 );
        Unknown37 = parser.ReadOffset< bool >( 116 );
        Unknown38 = parser.ReadOffset< bool >( 116, 2 );
        Unknown39 = parser.ReadOffset< bool >( 116, 4 );
        Unknown40 = parser.ReadOffset< bool >( 116, 8 );
        Unknown51 = parser.ReadOffset< bool >( 116, 16 );
        
        Transient = TransientKey switch
        {
        	6 => new LazyRow< ContentFinderConditionTransient >( gameData, TransientRowId, language ),
        	7 => new LazyRow< ContentFinderConditionTransient >( gameData, TransientRowId, language ),
        	_ => new EmptyLazyRow( (uint) TransientRowId ),
        };
        Content = ContentLinkType switch
        {
        	1 => new LazyRow< InstanceContent >( gameData, ContentRowId, language ),
        	2 => new LazyRow< PartyContent >( gameData, ContentRowId, language ),
        	3 => new LazyRow< PublicContent >( gameData, ContentRowId, language ),
        	4 => new LazyRow< GoldSaucerContent >( gameData, ContentRowId, language ),
        	5 => new LazyRow< QuestBattle >( gameData, ContentRowId, language ),
        	_ => new EmptyLazyRow( (uint) ContentRowId ),
        };
    }
}
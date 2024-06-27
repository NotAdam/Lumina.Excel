// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentFinderCondition", columnHash: 0x997006f9 )]
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
    public bool Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool AllianceRoulette { get; private set; }
    public bool FeastTeamRoulette { get; private set; }
    public bool NormalRaidRoulette { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    public bool Unknown18 { get; private set; }
    public bool Unknown19 { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool Unknown21 { get; private set; }
    public bool Unknown22 { get; private set; }
    public bool Unknown23 { get; private set; }
    public bool Unknown24 { get; private set; }
    public bool Unknown25 { get; private set; }
    public bool Unknown26 { get; private set; }
    public bool Unknown27 { get; private set; }
    public bool Unknown28 { get; private set; }
    public SeString ShortCode { get; private set; }
    public uint Unknown29 { get; private set; }
    public uint Unknown30 { get; private set; }
    public LazyRow< Quest > UnlockQuest { get; private set; }
    public uint Unknown31 { get; private set; }
    public uint Unknown_70_1 { get; private set; }
    public ILazyRow Transient { get; private set; }
    public uint Image { get; private set; }
    public uint Icon { get; private set; }
    public int Unknown32 { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public ILazyRow Content { get; private set; }
    public ushort ItemLevelRequired { get; private set; }
    public ushort ItemLevelSync { get; private set; }
    public ushort SortKey { get; private set; }
    public byte ContentLinkType { get; private set; }
    public byte Unknown33 { get; private set; }
    public LazyRow< ClassJobCategory > AcceptClassJobCategory { get; private set; }
    public LazyRow< ContentMemberType > ContentMemberType { get; private set; }
    public byte Unknown34 { get; private set; }
    public byte Unknown35 { get; private set; }
    public byte Unknown36 { get; private set; }
    public byte Unknown37 { get; private set; }
    public byte ClassJobLevelRequired { get; private set; }
    public byte ClassJobLevelSync { get; private set; }
    public byte Unknown38 { get; private set; }
    public byte Unknown39 { get; private set; }
    public LazyRow< ContentType > ContentType { get; private set; }
    public byte TransientKey { get; private set; }
    public byte Unknown40 { get; private set; }
    public sbyte Unknown41 { get; private set; }
    public bool PvP { get; private set; }
    public bool Unknown_70_2 { get; private set; }
    public bool Unknown42 { get; private set; }
    public bool AllowUndersized { get; private set; }
    public bool Unknown43 { get; private set; }
    public bool AllowReplacement { get; private set; }
    public bool Unknown44 { get; private set; }
    public bool AllowExplorerMode { get; private set; }
    public bool Unknown45 { get; private set; }
    public bool Unknown46 { get; private set; }
    public bool Unknown47 { get; private set; }
    public bool Unknown48 { get; private set; }
    public bool HighEndDuty { get; private set; }
    public bool Unknown49 { get; private set; }
    public bool Unknown50 { get; private set; }
    public bool Unknown51 { get; private set; }
    public bool DutyRecorderAllowed { get; private set; }
    public bool Unknown52 { get; private set; }
    public bool Unknown53 { get; private set; }
    public bool Unknown54 { get; private set; }
    public bool Unknown55 { get; private set; }
    public bool Unknown56 { get; private set; }
    
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
        Unknown0 = parser.ReadOffset< bool >( 17 );
        Unknown1 = parser.ReadOffset< bool >( 18 );
        Unknown2 = parser.ReadOffset< bool >( 19 );
        Unknown3 = parser.ReadOffset< bool >( 20 );
        Unknown4 = parser.ReadOffset< bool >( 21 );
        AllianceRoulette = parser.ReadOffset< bool >( 22 );
        FeastTeamRoulette = parser.ReadOffset< bool >( 23 );
        NormalRaidRoulette = parser.ReadOffset< bool >( 24 );
        Unknown5 = parser.ReadOffset< bool >( 25 );
        Unknown6 = parser.ReadOffset< bool >( 26 );
        Unknown7 = parser.ReadOffset< bool >( 27 );
        Unknown8 = parser.ReadOffset< bool >( 28 );
        Unknown9 = parser.ReadOffset< bool >( 29 );
        Unknown10 = parser.ReadOffset< bool >( 30 );
        Unknown11 = parser.ReadOffset< bool >( 31 );
        Unknown12 = parser.ReadOffset< bool >( 32 );
        Unknown13 = parser.ReadOffset< bool >( 33 );
        Unknown14 = parser.ReadOffset< bool >( 34 );
        Unknown15 = parser.ReadOffset< bool >( 35 );
        Unknown16 = parser.ReadOffset< bool >( 36 );
        Unknown17 = parser.ReadOffset< bool >( 37 );
        Unknown18 = parser.ReadOffset< bool >( 38 );
        Unknown19 = parser.ReadOffset< bool >( 39 );
        Unknown20 = parser.ReadOffset< bool >( 40 );
        Unknown21 = parser.ReadOffset< bool >( 41 );
        Unknown22 = parser.ReadOffset< bool >( 42 );
        Unknown23 = parser.ReadOffset< bool >( 43 );
        Unknown24 = parser.ReadOffset< bool >( 44 );
        Unknown25 = parser.ReadOffset< bool >( 45 );
        Unknown26 = parser.ReadOffset< bool >( 46 );
        Unknown27 = parser.ReadOffset< bool >( 47 );
        Unknown28 = parser.ReadOffset< bool >( 48 );
        ShortCode = parser.ReadOffset< SeString >( 52 );
        Unknown29 = parser.ReadOffset< uint >( 56 );
        Unknown30 = parser.ReadOffset< uint >( 60 );
        UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 64 ), language );
        Unknown31 = parser.ReadOffset< uint >( 68 );
        Unknown_70_1 = parser.ReadOffset< uint >( 72 );
        var TransientRowId = parser.ReadOffset< uint >( 76 );
        Image = parser.ReadOffset< uint >( 80 );
        Icon = parser.ReadOffset< uint >( 84 );
        Unknown32 = parser.ReadOffset< int >( 88 );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 92 ), language );
        var ContentRowId = parser.ReadOffset< ushort >( 94 );
        ItemLevelRequired = parser.ReadOffset< ushort >( 96 );
        ItemLevelSync = parser.ReadOffset< ushort >( 98 );
        SortKey = parser.ReadOffset< ushort >( 100 );
        ContentLinkType = parser.ReadOffset< byte >( 102 );
        Unknown33 = parser.ReadOffset< byte >( 103 );
        AcceptClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 104 ), language );
        ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadOffset< byte >( 105 ), language );
        Unknown34 = parser.ReadOffset< byte >( 106 );
        Unknown35 = parser.ReadOffset< byte >( 107 );
        Unknown36 = parser.ReadOffset< byte >( 108 );
        Unknown37 = parser.ReadOffset< byte >( 109 );
        ClassJobLevelRequired = parser.ReadOffset< byte >( 110 );
        ClassJobLevelSync = parser.ReadOffset< byte >( 111 );
        Unknown38 = parser.ReadOffset< byte >( 112 );
        Unknown39 = parser.ReadOffset< byte >( 113 );
        ContentType = new LazyRow< ContentType >( gameData, parser.ReadOffset< byte >( 114 ), language );
        TransientKey = parser.ReadOffset< byte >( 115 );
        Unknown40 = parser.ReadOffset< byte >( 116 );
        Unknown41 = parser.ReadOffset< sbyte >( 117 );
        PvP = parser.ReadOffset< bool >( 118 );
        Unknown_70_2 = parser.ReadOffset< bool >( 118, 2 );
        Unknown42 = parser.ReadOffset< bool >( 118, 4 );
        AllowUndersized = parser.ReadOffset< bool >( 118, 8 );
        Unknown43 = parser.ReadOffset< bool >( 118, 16 );
        AllowReplacement = parser.ReadOffset< bool >( 118, 32 );
        Unknown44 = parser.ReadOffset< bool >( 118, 64 );
        AllowExplorerMode = parser.ReadOffset< bool >( 118, 128 );
        Unknown45 = parser.ReadOffset< bool >( 119 );
        Unknown46 = parser.ReadOffset< bool >( 119, 2 );
        Unknown47 = parser.ReadOffset< bool >( 119, 4 );
        Unknown48 = parser.ReadOffset< bool >( 119, 8 );
        HighEndDuty = parser.ReadOffset< bool >( 119, 16 );
        Unknown49 = parser.ReadOffset< bool >( 119, 32 );
        Unknown50 = parser.ReadOffset< bool >( 119, 64 );
        Unknown51 = parser.ReadOffset< bool >( 119, 128 );
        DutyRecorderAllowed = parser.ReadOffset< bool >( 120 );
        Unknown52 = parser.ReadOffset< bool >( 120, 2 );
        Unknown53 = parser.ReadOffset< bool >( 120, 4 );
        Unknown54 = parser.ReadOffset< bool >( 120, 8 );
        Unknown55 = parser.ReadOffset< bool >( 120, 16 );
        Unknown56 = parser.ReadOffset< bool >( 120, 32 );
        
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
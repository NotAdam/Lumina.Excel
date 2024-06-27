// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentFinderCondition", columnHash: 0x997006f9 )]
    public partial class ContentFinderCondition : ExcelRow
    {
        
        public SeString ShortCode { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public byte ContentLinkType { get; set; }
        public ushort Content { get; set; }
        public bool PvP { get; set; }
        public bool Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public LazyRow< ClassJobCategory > AcceptClassJobCategory { get; set; }
        public LazyRow< ContentMemberType > ContentMemberType { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public LazyRow< Quest > UnlockQuest { get; set; }
        public byte Unknown15 { get; set; }
        public uint Unknown16 { get; set; }
        public byte ClassJobLevelRequired { get; set; }
        public byte ClassJobLevelSync { get; set; }
        public ushort ItemLevelRequired { get; set; }
        public ushort ItemLevelSync { get; set; }
        public bool Unknown21 { get; set; }
        public bool AllowUndersized { get; set; }
        public bool Unknown23 { get; set; }
        public bool AllowReplacement { get; set; }
        public bool Unknown25 { get; set; }
        public bool AllowExplorerMode { get; set; }
        public bool Unknown27 { get; set; }
        public bool Unknown28 { get; set; }
        public byte Unknown29 { get; set; }
        public bool Unknown30 { get; set; }
        public bool Unknown31 { get; set; }
        public bool HighEndDuty { get; set; }
        public bool Unknown33 { get; set; }
        public byte Unknown34 { get; set; }
        public bool Unknown35 { get; set; }
        public bool Unknown36 { get; set; }
        public bool DutyRecorderAllowed { get; set; }
        public bool Unknown38 { get; set; }
        public bool Unknown39 { get; set; }
        public bool Unknown40 { get; set; }
        public bool Unknown41 { get; set; }
        public SeString Name { get; set; }
        public SeString NameShort { get; set; }
        public LazyRow< ContentType > ContentType { get; set; }
        public byte TransientKey { get; set; }
        public uint Unknown46 { get; set; }
        public uint Transient { get; set; }
        public ushort SortKey { get; set; }
        public uint Image { get; set; }
        public uint Icon { get; set; }
        public sbyte Unknown51 { get; set; }
        public int Unknown52 { get; set; }
        public bool Unknown53 { get; set; }
        public byte Unknown54 { get; set; }
        public bool LevelingRoulette { get; set; }
        public bool HighLevelRoulette { get; set; }
        public bool MSQRoulette { get; set; }
        public bool GuildHestRoulette { get; set; }
        public bool ExpertRoulette { get; set; }
        public bool TrialRoulette { get; set; }
        public bool DailyFrontlineChallenge { get; set; }
        public bool LevelCapRoulette { get; set; }
        public bool MentorRoulette { get; set; }
        public bool Unknown64 { get; set; }
        public bool Unknown65 { get; set; }
        public bool Unknown66 { get; set; }
        public bool Unknown67 { get; set; }
        public bool Unknown68 { get; set; }
        public bool AllianceRoulette { get; set; }
        public bool FeastTeamRoulette { get; set; }
        public bool NormalRaidRoulette { get; set; }
        public bool Unknown72 { get; set; }
        public bool Unknown73 { get; set; }
        public bool Unknown74 { get; set; }
        public bool Unknown75 { get; set; }
        public bool Unknown76 { get; set; }
        public bool Unknown77 { get; set; }
        public bool Unknown78 { get; set; }
        public bool Unknown79 { get; set; }
        public bool Unknown80 { get; set; }
        public bool Unknown81 { get; set; }
        public bool Unknown82 { get; set; }
        public bool Unknown83 { get; set; }
        public bool Unknown84 { get; set; }
        public bool Unknown85 { get; set; }
        public bool Unknown86 { get; set; }
        public bool Unknown87 { get; set; }
        public bool Unknown88 { get; set; }
        public bool Unknown89 { get; set; }
        public bool Unknown90 { get; set; }
        public bool Unknown91 { get; set; }
        public bool Unknown92 { get; set; }
        public bool Unknown93 { get; set; }
        public bool Unknown94 { get; set; }
        public bool Unknown95 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ShortCode = parser.ReadColumn< SeString >( 0 );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            ContentLinkType = parser.ReadColumn< byte >( 2 );
            Content = parser.ReadColumn< ushort >( 3 );
            PvP = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            AcceptClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 9 ), language );
            ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadColumn< byte >( 10 ), language );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 14 ), language );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< uint >( 16 );
            ClassJobLevelRequired = parser.ReadColumn< byte >( 17 );
            ClassJobLevelSync = parser.ReadColumn< byte >( 18 );
            ItemLevelRequired = parser.ReadColumn< ushort >( 19 );
            ItemLevelSync = parser.ReadColumn< ushort >( 20 );
            Unknown21 = parser.ReadColumn< bool >( 21 );
            AllowUndersized = parser.ReadColumn< bool >( 22 );
            Unknown23 = parser.ReadColumn< bool >( 23 );
            AllowReplacement = parser.ReadColumn< bool >( 24 );
            Unknown25 = parser.ReadColumn< bool >( 25 );
            AllowExplorerMode = parser.ReadColumn< bool >( 26 );
            Unknown27 = parser.ReadColumn< bool >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< bool >( 30 );
            Unknown31 = parser.ReadColumn< bool >( 31 );
            HighEndDuty = parser.ReadColumn< bool >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            Unknown34 = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            Unknown36 = parser.ReadColumn< bool >( 36 );
            DutyRecorderAllowed = parser.ReadColumn< bool >( 37 );
            Unknown38 = parser.ReadColumn< bool >( 38 );
            Unknown39 = parser.ReadColumn< bool >( 39 );
            Unknown40 = parser.ReadColumn< bool >( 40 );
            Unknown41 = parser.ReadColumn< bool >( 41 );
            Name = parser.ReadColumn< SeString >( 42 );
            NameShort = parser.ReadColumn< SeString >( 43 );
            ContentType = new LazyRow< ContentType >( gameData, parser.ReadColumn< byte >( 44 ), language );
            TransientKey = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< uint >( 46 );
            Transient = parser.ReadColumn< uint >( 47 );
            SortKey = parser.ReadColumn< ushort >( 48 );
            Image = parser.ReadColumn< uint >( 49 );
            Icon = parser.ReadColumn< uint >( 50 );
            Unknown51 = parser.ReadColumn< sbyte >( 51 );
            Unknown52 = parser.ReadColumn< int >( 52 );
            Unknown53 = parser.ReadColumn< bool >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            LevelingRoulette = parser.ReadColumn< bool >( 55 );
            HighLevelRoulette = parser.ReadColumn< bool >( 56 );
            MSQRoulette = parser.ReadColumn< bool >( 57 );
            GuildHestRoulette = parser.ReadColumn< bool >( 58 );
            ExpertRoulette = parser.ReadColumn< bool >( 59 );
            TrialRoulette = parser.ReadColumn< bool >( 60 );
            DailyFrontlineChallenge = parser.ReadColumn< bool >( 61 );
            LevelCapRoulette = parser.ReadColumn< bool >( 62 );
            MentorRoulette = parser.ReadColumn< bool >( 63 );
            Unknown64 = parser.ReadColumn< bool >( 64 );
            Unknown65 = parser.ReadColumn< bool >( 65 );
            Unknown66 = parser.ReadColumn< bool >( 66 );
            Unknown67 = parser.ReadColumn< bool >( 67 );
            Unknown68 = parser.ReadColumn< bool >( 68 );
            AllianceRoulette = parser.ReadColumn< bool >( 69 );
            FeastTeamRoulette = parser.ReadColumn< bool >( 70 );
            NormalRaidRoulette = parser.ReadColumn< bool >( 71 );
            Unknown72 = parser.ReadColumn< bool >( 72 );
            Unknown73 = parser.ReadColumn< bool >( 73 );
            Unknown74 = parser.ReadColumn< bool >( 74 );
            Unknown75 = parser.ReadColumn< bool >( 75 );
            Unknown76 = parser.ReadColumn< bool >( 76 );
            Unknown77 = parser.ReadColumn< bool >( 77 );
            Unknown78 = parser.ReadColumn< bool >( 78 );
            Unknown79 = parser.ReadColumn< bool >( 79 );
            Unknown80 = parser.ReadColumn< bool >( 80 );
            Unknown81 = parser.ReadColumn< bool >( 81 );
            Unknown82 = parser.ReadColumn< bool >( 82 );
            Unknown83 = parser.ReadColumn< bool >( 83 );
            Unknown84 = parser.ReadColumn< bool >( 84 );
            Unknown85 = parser.ReadColumn< bool >( 85 );
            Unknown86 = parser.ReadColumn< bool >( 86 );
            Unknown87 = parser.ReadColumn< bool >( 87 );
            Unknown88 = parser.ReadColumn< bool >( 88 );
            Unknown89 = parser.ReadColumn< bool >( 89 );
            Unknown90 = parser.ReadColumn< bool >( 90 );
            Unknown91 = parser.ReadColumn< bool >( 91 );
            Unknown92 = parser.ReadColumn< bool >( 92 );
            Unknown93 = parser.ReadColumn< bool >( 93 );
            Unknown94 = parser.ReadColumn< bool >( 94 );
            Unknown95 = parser.ReadColumn< bool >( 95 );
        }
    }
}
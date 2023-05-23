// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRoulette", columnHash: 0xbca6bc72 )]
    public partial class ContentRoulette : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Category { get; set; }
        public SeString Unknown2 { get; set; }
        public SeString Description { get; set; }
        public SeString DutyType { get; set; }
        public byte Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public bool IsGoldSaucer { get; set; }
        public bool IsInDutyFinder { get; set; }
        public LazyRow< ContentRouletteOpenRule > OpenRule { get; set; }
        public bool IsPvP { get; set; }
        public byte RequiredLevel { get; set; }
        public byte Unknown12 { get; set; }
        public ushort ItemLevelRequired { get; set; }
        public ushort Unknown14 { get; set; }
        public uint Icon { get; set; }
        public LazyRow< ContentRouletteRoleBonus > ContentRouletteRoleBonus { get; set; }
        public ushort RewardTomeA { get; set; }
        public ushort RewardTomeB { get; set; }
        public ushort RewardTomeC { get; set; }
        public uint Unknown20 { get; set; }
        public ushort Unknown21 { get; set; }
        public uint Unknown22 { get; set; }
        public byte SortKey { get; set; }
        public byte Unknown24 { get; set; }
        public LazyRow< ContentMemberType > ContentMemberType { get; set; }
        public byte Unknown26 { get; set; }
        public byte Unknown27 { get; set; }
        public sbyte Unknown28 { get; set; }
        public bool Unknown29 { get; set; }
        public byte Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public byte Unknown32 { get; set; }
        public byte Unknown33 { get; set; }
        public bool Unknown34 { get; set; }
        public bool Unknown35 { get; set; }
        public bool RequireAllDuties { get; set; }
        public bool Unknown37 { get; set; }
        public byte ContentRouletteOpenRule { get; set; }
        public LazyRow< InstanceContent > InstanceContent { get; set; }
        public bool Unknown40 { get; set; }
        public byte Unknown41 { get; set; }
        public bool Unknown42 { get; set; }
        public bool Unknown43 { get; set; }
        public byte Unknown44 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Category = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Description = parser.ReadColumn< SeString >( 3 );
            DutyType = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            IsGoldSaucer = parser.ReadColumn< bool >( 7 );
            IsInDutyFinder = parser.ReadColumn< bool >( 8 );
            OpenRule = new LazyRow< ContentRouletteOpenRule >( gameData, parser.ReadColumn< byte >( 9 ), language );
            IsPvP = parser.ReadColumn< bool >( 10 );
            RequiredLevel = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            ItemLevelRequired = parser.ReadColumn< ushort >( 13 );
            Unknown14 = parser.ReadColumn< ushort >( 14 );
            Icon = parser.ReadColumn< uint >( 15 );
            ContentRouletteRoleBonus = new LazyRow< ContentRouletteRoleBonus >( gameData, parser.ReadColumn< byte >( 16 ), language );
            RewardTomeA = parser.ReadColumn< ushort >( 17 );
            RewardTomeB = parser.ReadColumn< ushort >( 18 );
            RewardTomeC = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< ushort >( 21 );
            Unknown22 = parser.ReadColumn< uint >( 22 );
            SortKey = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadColumn< byte >( 25 ), language );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< sbyte >( 28 );
            Unknown29 = parser.ReadColumn< bool >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            Unknown33 = parser.ReadColumn< byte >( 33 );
            Unknown34 = parser.ReadColumn< bool >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            RequireAllDuties = parser.ReadColumn< bool >( 36 );
            Unknown37 = parser.ReadColumn< bool >( 37 );
            ContentRouletteOpenRule = parser.ReadColumn< byte >( 38 );
            InstanceContent = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< ushort >( 39 ), language );
            Unknown40 = parser.ReadColumn< bool >( 40 );
            Unknown41 = parser.ReadColumn< byte >( 41 );
            Unknown42 = parser.ReadColumn< bool >( 42 );
            Unknown43 = parser.ReadColumn< bool >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
        }
    }
}
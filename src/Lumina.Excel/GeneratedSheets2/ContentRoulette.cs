// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentRoulette", columnHash: 0xbca6bc72 )]
public partial class ContentRoulette : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Category { get; private set; }
    public SeString Unknown2 { get; private set; }
    public SeString Description { get; private set; }
    public SeString DutyType { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Icon { get; private set; }
    public uint Unknown20 { get; private set; }
    public uint Unknown22 { get; private set; }
    public ushort ItemLevelRequired { get; private set; }
    public ushort Unknown14 { get; private set; }
    public ushort RewardTomeA { get; private set; }
    public ushort RewardTomeB { get; private set; }
    public ushort RewardTomeC { get; private set; }
    public ushort Unknown21 { get; private set; }
    public LazyRow< InstanceContent > InstanceContent { get; private set; }
    public byte Unknown5 { get; private set; }
    public LazyRow< ContentRouletteOpenRule > OpenRule { get; private set; }
    public byte RequiredLevel { get; private set; }
    public byte Unknown12 { get; private set; }
    public LazyRow< ContentRouletteRoleBonus > ContentRouletteRoleBonus { get; private set; }
    public byte SortKey { get; private set; }
    public byte Unknown24 { get; private set; }
    public LazyRow< ContentMemberType > ContentMemberType { get; private set; }
    public byte Unknown26 { get; private set; }
    public byte Unknown27 { get; private set; }
    public byte Unknown30 { get; private set; }
    public byte Unknown31 { get; private set; }
    public byte Unknown32 { get; private set; }
    public byte Unknown33 { get; private set; }
    public byte ContentRouletteOpenRule { get; private set; }
    public byte Unknown41 { get; private set; }
    public byte Unknown44 { get; private set; }
    public sbyte Unknown28 { get; private set; }
    public bool IsGoldSaucer { get; private set; }
    public bool IsInDutyFinder { get; private set; }
    public bool IsPvP { get; private set; }
    public bool Unknown29 { get; private set; }
    public bool Unknown34 { get; private set; }
    public bool Unknown35 { get; private set; }
    public bool RequireAllDuties { get; private set; }
    public bool Unknown37 { get; private set; }
    public bool Unknown40 { get; private set; }
    public bool Unknown42 { get; private set; }
    public bool Unknown43 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Category = parser.ReadOffset< SeString >( 4 );
        Unknown2 = parser.ReadOffset< SeString >( 8 );
        Description = parser.ReadOffset< SeString >( 12 );
        DutyType = parser.ReadOffset< SeString >( 16 );
        Unknown6 = parser.ReadOffset< uint >( 20 );
        Icon = parser.ReadOffset< uint >( 24 );
        Unknown20 = parser.ReadOffset< uint >( 28 );
        Unknown22 = parser.ReadOffset< uint >( 32 );
        ItemLevelRequired = parser.ReadOffset< ushort >( 36 );
        Unknown14 = parser.ReadOffset< ushort >( 38 );
        RewardTomeA = parser.ReadOffset< ushort >( 40 );
        RewardTomeB = parser.ReadOffset< ushort >( 42 );
        RewardTomeC = parser.ReadOffset< ushort >( 44 );
        Unknown21 = parser.ReadOffset< ushort >( 46 );
        InstanceContent = new LazyRow< InstanceContent >( gameData, parser.ReadOffset< ushort >( 48 ), language );
        Unknown5 = parser.ReadOffset< byte >( 50 );
        OpenRule = new LazyRow< ContentRouletteOpenRule >( gameData, parser.ReadOffset< byte >( 51 ), language );
        RequiredLevel = parser.ReadOffset< byte >( 52 );
        Unknown12 = parser.ReadOffset< byte >( 53 );
        ContentRouletteRoleBonus = new LazyRow< ContentRouletteRoleBonus >( gameData, parser.ReadOffset< byte >( 54 ), language );
        SortKey = parser.ReadOffset< byte >( 55 );
        Unknown24 = parser.ReadOffset< byte >( 56 );
        ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadOffset< byte >( 57 ), language );
        Unknown26 = parser.ReadOffset< byte >( 58 );
        Unknown27 = parser.ReadOffset< byte >( 59 );
        Unknown30 = parser.ReadOffset< byte >( 60 );
        Unknown31 = parser.ReadOffset< byte >( 61 );
        Unknown32 = parser.ReadOffset< byte >( 62 );
        Unknown33 = parser.ReadOffset< byte >( 63 );
        ContentRouletteOpenRule = parser.ReadOffset< byte >( 64 );
        Unknown41 = parser.ReadOffset< byte >( 65 );
        Unknown44 = parser.ReadOffset< byte >( 66 );
        Unknown28 = parser.ReadOffset< sbyte >( 67 );
        IsGoldSaucer = parser.ReadOffset< bool >( 68 );
        IsInDutyFinder = parser.ReadOffset< bool >( 68, 2 );
        IsPvP = parser.ReadOffset< bool >( 68, 4 );
        Unknown29 = parser.ReadOffset< bool >( 68, 8 );
        Unknown34 = parser.ReadOffset< bool >( 68, 16 );
        Unknown35 = parser.ReadOffset< bool >( 68, 32 );
        RequireAllDuties = parser.ReadOffset< bool >( 68, 64 );
        Unknown37 = parser.ReadOffset< bool >( 68, 128 );
        Unknown40 = parser.ReadOffset< bool >( 69 );
        Unknown42 = parser.ReadOffset< bool >( 69, 2 );
        Unknown43 = parser.ReadOffset< bool >( 69, 4 );
        

    }
}
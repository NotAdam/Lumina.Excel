// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentRoulette", columnHash: 0x9510a340 )]
public partial class ContentRoulette : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Category { get; private set; }
    public SeString Unknown0 { get; private set; }
    public SeString Description { get; private set; }
    public SeString DutyType { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Icon { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public ushort ItemLevelRequired { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort RewardTomeA { get; private set; }
    public ushort RewardTomeB { get; private set; }
    public ushort RewardTomeC { get; private set; }
    public ushort Unknown5 { get; private set; }
    public LazyRow< InstanceContent > InstanceContent { get; private set; }
    public byte Unknown6 { get; private set; }
    public LazyRow< ContentRouletteOpenRule > OpenRule { get; private set; }
    public byte RequiredLevel { get; private set; }
    public byte Unknown7 { get; private set; }
    public LazyRow< ContentRouletteRoleBonus > ContentRouletteRoleBonus { get; private set; }
    public byte SortKey { get; private set; }
    public byte Unknown8 { get; private set; }
    public LazyRow< ContentMemberType > ContentMemberType { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte ContentRouletteOpenRule { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public sbyte Unknown17 { get; private set; }
    public bool IsGoldSaucer { get; private set; }
    public bool IsInDutyFinder { get; private set; }
    public bool IsPvP { get; private set; }
    public bool Unknown25 { get; private set; }
    public bool Unknown18 { get; private set; }
    public bool Unknown19 { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool RequireAllDuties { get; private set; }
    public bool Unknown21 { get; private set; }
    public bool Unknown22 { get; private set; }
    public bool Unknown23 { get; private set; }
    public bool Unknown24 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Category = parser.ReadOffset< SeString >( 4 );
        Unknown0 = parser.ReadOffset< SeString >( 8 );
        Description = parser.ReadOffset< SeString >( 12 );
        DutyType = parser.ReadOffset< SeString >( 16 );
        Unknown1 = parser.ReadOffset< uint >( 20 );
        Icon = parser.ReadOffset< uint >( 24 );
        Unknown2 = parser.ReadOffset< uint >( 28 );
        Unknown3 = parser.ReadOffset< uint >( 32 );
        ItemLevelRequired = parser.ReadOffset< ushort >( 36 );
        Unknown4 = parser.ReadOffset< ushort >( 38 );
        RewardTomeA = parser.ReadOffset< ushort >( 40 );
        RewardTomeB = parser.ReadOffset< ushort >( 42 );
        RewardTomeC = parser.ReadOffset< ushort >( 44 );
        Unknown5 = parser.ReadOffset< ushort >( 46 );
        InstanceContent = new LazyRow< InstanceContent >( gameData, parser.ReadOffset< ushort >( 48 ), language );
        Unknown6 = parser.ReadOffset< byte >( 50 );
        OpenRule = new LazyRow< ContentRouletteOpenRule >( gameData, parser.ReadOffset< byte >( 51 ), language );
        RequiredLevel = parser.ReadOffset< byte >( 52 );
        Unknown7 = parser.ReadOffset< byte >( 53 );
        ContentRouletteRoleBonus = new LazyRow< ContentRouletteRoleBonus >( gameData, parser.ReadOffset< byte >( 54 ), language );
        SortKey = parser.ReadOffset< byte >( 55 );
        Unknown8 = parser.ReadOffset< byte >( 56 );
        ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadOffset< byte >( 57 ), language );
        Unknown9 = parser.ReadOffset< byte >( 58 );
        Unknown10 = parser.ReadOffset< byte >( 59 );
        Unknown11 = parser.ReadOffset< byte >( 60 );
        Unknown12 = parser.ReadOffset< byte >( 61 );
        Unknown13 = parser.ReadOffset< byte >( 62 );
        Unknown14 = parser.ReadOffset< byte >( 63 );
        ContentRouletteOpenRule = parser.ReadOffset< byte >( 64 );
        Unknown15 = parser.ReadOffset< byte >( 65 );
        Unknown16 = parser.ReadOffset< byte >( 66 );
        Unknown17 = parser.ReadOffset< sbyte >( 67 );
        IsGoldSaucer = parser.ReadOffset< bool >( 68 );
        IsInDutyFinder = parser.ReadOffset< bool >( 68, 2 );
        IsPvP = parser.ReadOffset< bool >( 68, 4 );
        Unknown25 = parser.ReadOffset< bool >( 68, 8 );
        Unknown18 = parser.ReadOffset< bool >( 68, 16 );
        Unknown19 = parser.ReadOffset< bool >( 68, 32 );
        Unknown20 = parser.ReadOffset< bool >( 68, 64 );
        RequireAllDuties = parser.ReadOffset< bool >( 68, 128 );
        Unknown21 = parser.ReadOffset< bool >( 69 );
        Unknown22 = parser.ReadOffset< bool >( 69, 2 );
        Unknown23 = parser.ReadOffset< bool >( 69, 4 );
        Unknown24 = parser.ReadOffset< bool >( 69, 8 );
        

    }
}
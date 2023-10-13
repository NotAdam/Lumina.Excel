// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Fate", columnHash: 0xc9fc38f1 )]
public partial class Fate : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public SeString Objective { get; private set; }
    public SeString[] StatusText { get; private set; }
    public LazyRow< EventItem > ReqEventItem { get; private set; }
    public LazyRow< EventItem > TurnInEventItem { get; private set; }
    public uint Unknown40 { get; private set; }
    public uint Unknown41 { get; private set; }
    public uint Unknown42 { get; private set; }
    public uint[] ObjectiveIcon { get; private set; }
    public ushort Unknown51 { get; private set; }
    public ushort Unknown52 { get; private set; }
    public uint Location { get; private set; }
    public LazyRow< EventItem > EventItem { get; private set; }
    public uint Icon { get; private set; }
    public uint MapIcon { get; private set; }
    public uint InactiveMapIcon { get; private set; }
    public uint LGBGuardNPCLocation { get; private set; }
    public LazyRow< Quest > RequiredQuest { get; private set; }
    public uint FATEChain { get; private set; }
    public LazyRow< ArrayEventHandler > ArrayIndex { get; private set; }
    public uint Unknown37 { get; private set; }
    public LazyRow< BGM > Music { get; private set; }
    public LazyRow< FateRuleEx > FateRuleEx { get; private set; }
    public LazyRow< ScreenImage > ScreenImageAccept { get; private set; }
    public LazyRow< ScreenImage > ScreenImageComplete { get; private set; }
    public LazyRow< ScreenImage > ScreenImageFailed { get; private set; }
    public LazyRow< Status > GivenStatus { get; private set; }
    public ushort Unknown29 { get; private set; }
    public ushort Unknown35 { get; private set; }
    public byte EurekaFate { get; private set; }
    public byte Rule { get; private set; }
    public byte ClassJobLevel { get; private set; }
    public byte ClassJobLevelMax { get; private set; }
    public byte[] StatusValue { get; private set; }
    public byte Unknown24 { get; private set; }
    public byte Unknown34 { get; private set; }
    public bool SpecialFate { get; private set; }
    public bool Unknown27 { get; private set; }
    public bool AdventEvent { get; private set; }
    public bool MoonFaireEvent { get; private set; }
    public bool Unknown32 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Objective = parser.ReadOffset< SeString >( 8 );
        StatusText = new SeString[3];
        for (int i = 0; i < 3; i++)
        	StatusText[i] = parser.ReadOffset< SeString >( 12 + i * 4 );
        ReqEventItem = new LazyRow< EventItem >( gameData, parser.ReadOffset< uint >( 24 ), language );
        TurnInEventItem = new LazyRow< EventItem >( gameData, parser.ReadOffset< uint >( 28 ), language );
        Unknown40 = parser.ReadOffset< uint >( 32 );
        Unknown41 = parser.ReadOffset< uint >( 36 );
        Unknown42 = parser.ReadOffset< uint >( 40 );
        ObjectiveIcon = new uint[8];
        for (int i = 0; i < 8; i++)
        	ObjectiveIcon[i] = parser.ReadOffset< uint >( 44 + i * 4 );
        Unknown51 = parser.ReadOffset< ushort >( 64 );
        Unknown52 = parser.ReadOffset< ushort >( 66 );
        Location = parser.ReadOffset< uint >( 68 );
        EventItem = new LazyRow< EventItem >( gameData, parser.ReadOffset< uint >( 72 ), language );
        Icon = parser.ReadOffset< uint >( 76 );
        MapIcon = parser.ReadOffset< uint >( 80 );
        InactiveMapIcon = parser.ReadOffset< uint >( 84 );
        LGBGuardNPCLocation = parser.ReadOffset< uint >( 88 );
        RequiredQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 92 ), language );
        FATEChain = parser.ReadOffset< uint >( 96 );
        ArrayIndex = new LazyRow< ArrayEventHandler >( gameData, parser.ReadOffset< uint >( 100 ), language );
        Unknown37 = parser.ReadOffset< uint >( 104 );
        Music = new LazyRow< BGM >( gameData, parser.ReadOffset< int >( 108 ), language );
        FateRuleEx = new LazyRow< FateRuleEx >( gameData, parser.ReadOffset< ushort >( 112 ), language );
        ScreenImageAccept = new LazyRow< ScreenImage >( gameData, parser.ReadOffset< ushort >( 114 ), language );
        ScreenImageComplete = new LazyRow< ScreenImage >( gameData, parser.ReadOffset< ushort >( 116 ), language );
        ScreenImageFailed = new LazyRow< ScreenImage >( gameData, parser.ReadOffset< ushort >( 118 ), language );
        GivenStatus = new LazyRow< Status >( gameData, parser.ReadOffset< ushort >( 120 ), language );
        Unknown29 = parser.ReadOffset< ushort >( 122 );
        Unknown35 = parser.ReadOffset< ushort >( 124 );
        EurekaFate = parser.ReadOffset< byte >( 126 );
        Rule = parser.ReadOffset< byte >( 127 );
        ClassJobLevel = parser.ReadOffset< byte >( 128 );
        ClassJobLevelMax = parser.ReadOffset< byte >( 129 );
        StatusValue = new byte[3];
        for (int i = 0; i < 3; i++)
        	StatusValue[i] = parser.ReadOffset< byte >( 130 + i * 1 );
        Unknown24 = parser.ReadOffset< byte >( 133 );
        Unknown34 = parser.ReadOffset< byte >( 134 );
        SpecialFate = parser.ReadOffset< bool >( 135 );
        Unknown27 = parser.ReadOffset< bool >( 135, 2 );
        AdventEvent = parser.ReadOffset< bool >( 135, 4 );
        MoonFaireEvent = parser.ReadOffset< bool >( 135, 8 );
        Unknown32 = parser.ReadOffset< bool >( 135, 16 );
        

    }
}
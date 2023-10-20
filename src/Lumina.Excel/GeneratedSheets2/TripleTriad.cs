// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TripleTriad", columnHash: 0x646dde20 )]
public partial class TripleTriad : ExcelRow
{
    
    public LazyRow< Item >[] ItemPossibleReward { get; private set; }
    public LazyRow< Quest >[] PreviousQuest { get; private set; }
    public LazyRow< DefaultTalk > DefaultTalkChallenge { get; private set; }
    public LazyRow< DefaultTalk > DefaultTalkUnavailable { get; private set; }
    public LazyRow< DefaultTalk > DefaultTalkNPCWin { get; private set; }
    public LazyRow< DefaultTalk > DefaultTalkDraw { get; private set; }
    public LazyRow< DefaultTalk > DefaultTalkPCWin { get; private set; }
    public LazyRow< TripleTriadCard >[] TripleTriadCardFixed { get; private set; }
    public LazyRow< TripleTriadCard >[] TripleTriadCardVariable { get; private set; }
    public ushort Fee { get; private set; }
    public ushort StartTime { get; private set; }
    public ushort EndTime { get; private set; }
    public LazyRow< TripleTriadRule >[] TripleTriadRule { get; private set; }
    public byte PreviousQuestJoin { get; private set; }
    public bool UsesRegionalRules { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ItemPossibleReward = new LazyRow< Item >[4];
        for (int i = 0; i < 4; i++)
        	ItemPossibleReward[i] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) ( 0 + i * 4 ) ), language );
        PreviousQuest = new LazyRow< Quest >[3];
        for (int i = 0; i < 3; i++)
        	PreviousQuest[i] = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( (ushort) ( 16 + i * 4 ) ), language );
        DefaultTalkChallenge = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 28 ), language );
        DefaultTalkUnavailable = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 32 ), language );
        DefaultTalkNPCWin = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 36 ), language );
        DefaultTalkDraw = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 40 ), language );
        DefaultTalkPCWin = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 44 ), language );
        TripleTriadCardFixed = new LazyRow< TripleTriadCard >[5];
        for (int i = 0; i < 5; i++)
        	TripleTriadCardFixed[i] = new LazyRow< TripleTriadCard >( gameData, parser.ReadOffset< ushort >( (ushort) ( 48 + i * 2 ) ), language );
        TripleTriadCardVariable = new LazyRow< TripleTriadCard >[5];
        for (int i = 0; i < 5; i++)
        	TripleTriadCardVariable[i] = new LazyRow< TripleTriadCard >( gameData, parser.ReadOffset< ushort >( (ushort) ( 58 + i * 2 ) ), language );
        Fee = parser.ReadOffset< ushort >( 68 );
        StartTime = parser.ReadOffset< ushort >( 70 );
        EndTime = parser.ReadOffset< ushort >( 72 );
        TripleTriadRule = new LazyRow< TripleTriadRule >[2];
        for (int i = 0; i < 2; i++)
        	TripleTriadRule[i] = new LazyRow< TripleTriadRule >( gameData, parser.ReadOffset< byte >( (ushort) ( 74 + i * 1 ) ), language );
        PreviousQuestJoin = parser.ReadOffset< byte >( 76 );
        UsesRegionalRules = parser.ReadOffset< bool >( 77 );
        Unknown0 = parser.ReadOffset< bool >( 77, 2 );
        

    }
}
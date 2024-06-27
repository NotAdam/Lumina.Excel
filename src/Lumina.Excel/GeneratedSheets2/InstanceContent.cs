// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "InstanceContent", columnHash: 0xd00494fa )]
public partial class InstanceContent : ExcelRow
{
    
    public uint NewPlayerBonusGil { get; private set; }
    public uint NewPlayerBonusExp { get; private set; }
    public uint FinalBossExp { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint[] BossExp { get; private set; }
    public uint InstanceClearExp { get; private set; }
    public uint InstanceClearGil { get; private set; }
    public LazyRow< InstanceContentRewardItem > InstanceContentRewardItem { get; private set; }
    public ushort NewPlayerBonusA { get; private set; }
    public ushort NewPlayerBonusB { get; private set; }
    public ushort FinalBossCurrencyA { get; private set; }
    public ushort FinalBossCurrencyB { get; private set; }
    public ushort FinalBossCurrencyC { get; private set; }
    public ushort[] BossCurrencyA { get; private set; }
    public ushort[] BossCurrencyB { get; private set; }
    public ushort[] BossCurrencyC { get; private set; }
    public ushort Unknown1 { get; private set; }
    public LazyRow< Cutscene > Cutscene { get; private set; }
    public uint LGBEventRange { get; private set; }
    public LazyRow< InstanceContentTextData > InstanceContentTextDataBossStart { get; private set; }
    public LazyRow< InstanceContentTextData > InstanceContentTextDataBossEnd { get; private set; }
    public LazyRow< BNpcBase > BNpcBaseBoss { get; private set; }
    public LazyRow< InstanceContentTextData > InstanceContentTextDataObjectiveStart { get; private set; }
    public LazyRow< InstanceContentTextData > InstanceContentTextDataObjectiveEnd { get; private set; }
    public uint Unknown2 { get; private set; }
    public LazyRow< InstanceContent > ReqInstance { get; private set; }
    public LazyRow< InstanceContentBuff > InstanceContentBuff { get; private set; }
    public ushort TimeLimitmin { get; private set; }
    public LazyRow< BGM > BGM { get; private set; }
    public LazyRow< BGM > WinBGM { get; private set; }
    public ushort Order { get; private set; }
    public ushort SortKey { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public ushort Unknown_70 { get; private set; }
    public short PartyCondition { get; private set; }
    public LazyRow< InstanceContentType > InstanceContentType { get; private set; }
    public byte WeekRestriction { get; private set; }
    public LazyRow< Colosseum > Colosseum { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    public bool Unknown18 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NewPlayerBonusGil = parser.ReadOffset< uint >( 0 );
        NewPlayerBonusExp = parser.ReadOffset< uint >( 4 );
        FinalBossExp = parser.ReadOffset< uint >( 8 );
        Unknown0 = parser.ReadOffset< uint >( 12 );
        BossExp = new uint[5];
        for (int i = 0; i < 5; i++)
        	BossExp[i] = parser.ReadOffset< uint >( 16 + i * 4 );
        InstanceClearExp = parser.ReadOffset< uint >( 36 );
        InstanceClearGil = parser.ReadOffset< uint >( 40 );
        InstanceContentRewardItem = new LazyRow< InstanceContentRewardItem >( gameData, parser.ReadOffset< uint >( 44 ), language );
        NewPlayerBonusA = parser.ReadOffset< ushort >( 48 );
        NewPlayerBonusB = parser.ReadOffset< ushort >( 50 );
        FinalBossCurrencyA = parser.ReadOffset< ushort >( 52 );
        FinalBossCurrencyB = parser.ReadOffset< ushort >( 54 );
        FinalBossCurrencyC = parser.ReadOffset< ushort >( 56 );
        BossCurrencyA = new ushort[5];
        for (int i = 0; i < 5; i++)
        	BossCurrencyA[i] = parser.ReadOffset< ushort >( 58 + i * 2 );
        BossCurrencyB = new ushort[5];
        for (int i = 0; i < 5; i++)
        	BossCurrencyB[i] = parser.ReadOffset< ushort >( 68 + i * 2 );
        BossCurrencyC = new ushort[5];
        for (int i = 0; i < 5; i++)
        	BossCurrencyC[i] = parser.ReadOffset< ushort >( 78 + i * 2 );
        Unknown1 = parser.ReadOffset< ushort >( 88 );
        Cutscene = new LazyRow< Cutscene >( gameData, parser.ReadOffset< uint >( 92 ), language );
        LGBEventRange = parser.ReadOffset< uint >( 96 );
        InstanceContentTextDataBossStart = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 100 ), language );
        InstanceContentTextDataBossEnd = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 104 ), language );
        BNpcBaseBoss = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< uint >( 108 ), language );
        InstanceContentTextDataObjectiveStart = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 112 ), language );
        InstanceContentTextDataObjectiveEnd = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 116 ), language );
        Unknown2 = parser.ReadOffset< uint >( 120 );
        ReqInstance = new LazyRow< InstanceContent >( gameData, parser.ReadOffset< uint >( 124 ), language );
        InstanceContentBuff = new LazyRow< InstanceContentBuff >( gameData, parser.ReadOffset< int >( 128 ), language );
        TimeLimitmin = parser.ReadOffset< ushort >( 132 );
        BGM = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 134 ), language );
        WinBGM = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 136 ), language );
        Order = parser.ReadOffset< ushort >( 138 );
        SortKey = parser.ReadOffset< ushort >( 140 );
        Unknown3 = parser.ReadOffset< ushort >( 142 );
        Unknown4 = parser.ReadOffset< ushort >( 144 );
        Unknown5 = parser.ReadOffset< ushort >( 146 );
        Unknown6 = parser.ReadOffset< ushort >( 148 );
        Unknown7 = parser.ReadOffset< ushort >( 150 );
        Unknown8 = parser.ReadOffset< ushort >( 152 );
        Unknown_70 = parser.ReadOffset< ushort >( 154 );
        PartyCondition = parser.ReadOffset< short >( 156 );
        InstanceContentType = new LazyRow< InstanceContentType >( gameData, parser.ReadOffset< byte >( 158 ), language );
        WeekRestriction = parser.ReadOffset< byte >( 159 );
        Colosseum = new LazyRow< Colosseum >( gameData, parser.ReadOffset< byte >( 160 ), language );
        Unknown9 = parser.ReadOffset< byte >( 161 );
        Unknown10 = parser.ReadOffset< byte >( 162 );
        Unknown11 = parser.ReadOffset< byte >( 163 );
        Unknown12 = parser.ReadOffset< byte >( 164 );
        Unknown19 = parser.ReadOffset< byte >( 165 );
        Unknown13 = parser.ReadOffset< byte >( 166 );
        Unknown14 = parser.ReadOffset< bool >( 167 );
        Unknown15 = parser.ReadOffset< bool >( 167, 2 );
        Unknown16 = parser.ReadOffset< bool >( 167, 4 );
        Unknown17 = parser.ReadOffset< bool >( 167, 8 );
        Unknown18 = parser.ReadOffset< bool >( 167, 16 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "InstanceContent", columnHash: 0xa1adecb4 )]
public partial class InstanceContent : ExcelRow
{
    
    public uint NewPlayerBonusGil { get; private set; }
    public uint NewPlayerBonusExp { get; private set; }
    public uint FinalBossExp { get; private set; }
    public uint Unknown22 { get; private set; }
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
    public ushort Unknown49 { get; private set; }
    public LazyRow< Cutscene > Cutscene { get; private set; }
    public uint LGBEventRange { get; private set; }
    public LazyRow< InstanceContentTextData > InstanceContentTextDataBossStart { get; private set; }
    public LazyRow< InstanceContentTextData > InstanceContentTextDataBossEnd { get; private set; }
    public LazyRow< BNpcBase > BNpcBaseBoss { get; private set; }
    public LazyRow< InstanceContentTextData > InstanceContentTextDataObjectiveStart { get; private set; }
    public LazyRow< InstanceContentTextData > InstanceContentTextDataObjectiveEnd { get; private set; }
    public uint Unknown50 { get; private set; }
    public LazyRow< InstanceContent > ReqInstance { get; private set; }
    public LazyRow< InstanceContentBuff > InstanceContentBuff { get; private set; }
    public ushort TimeLimitmin { get; private set; }
    public LazyRow< BGM > BGM { get; private set; }
    public LazyRow< BGM > WinBGM { get; private set; }
    public ushort Order { get; private set; }
    public ushort SortKey { get; private set; }
    public ushort Unknown60 { get; private set; }
    public ushort Unknown61 { get; private set; }
    public ushort Unknown62 { get; private set; }
    public ushort Unknown64 { get; private set; }
    public ushort Unknown65 { get; private set; }
    public ushort Unknown67 { get; private set; }
    public short PartyCondition { get; private set; }
    public LazyRow< InstanceContentType > InstanceContentType { get; private set; }
    public byte WeekRestriction { get; private set; }
    public LazyRow< Colosseum > Colosseum { get; private set; }
    public byte Unknown55 { get; private set; }
    public byte Unknown56 { get; private set; }
    public byte Unknown57 { get; private set; }
    public byte Unknown58 { get; private set; }
    public byte Unknown69 { get; private set; }
    public byte Unknown63 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown52 { get; private set; }
    public bool Unknown59 { get; private set; }
    public bool Unknown66 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NewPlayerBonusGil = parser.ReadOffset< uint >( 0 );
        NewPlayerBonusExp = parser.ReadOffset< uint >( 4 );
        FinalBossExp = parser.ReadOffset< uint >( 8 );
        Unknown22 = parser.ReadOffset< uint >( 12 );
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
        Unknown49 = parser.ReadOffset< ushort >( 88 );
        Cutscene = new LazyRow< Cutscene >( gameData, parser.ReadOffset< uint >( 92 ), language );
        LGBEventRange = parser.ReadOffset< uint >( 96 );
        InstanceContentTextDataBossStart = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 100 ), language );
        InstanceContentTextDataBossEnd = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 104 ), language );
        BNpcBaseBoss = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< uint >( 108 ), language );
        InstanceContentTextDataObjectiveStart = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 112 ), language );
        InstanceContentTextDataObjectiveEnd = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 116 ), language );
        Unknown50 = parser.ReadOffset< uint >( 120 );
        ReqInstance = new LazyRow< InstanceContent >( gameData, parser.ReadOffset< uint >( 124 ), language );
        InstanceContentBuff = new LazyRow< InstanceContentBuff >( gameData, parser.ReadOffset< int >( 128 ), language );
        TimeLimitmin = parser.ReadOffset< ushort >( 132 );
        BGM = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 134 ), language );
        WinBGM = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 136 ), language );
        Order = parser.ReadOffset< ushort >( 138 );
        SortKey = parser.ReadOffset< ushort >( 140 );
        Unknown60 = parser.ReadOffset< ushort >( 142 );
        Unknown61 = parser.ReadOffset< ushort >( 144 );
        Unknown62 = parser.ReadOffset< ushort >( 146 );
        Unknown64 = parser.ReadOffset< ushort >( 148 );
        Unknown65 = parser.ReadOffset< ushort >( 150 );
        Unknown67 = parser.ReadOffset< ushort >( 152 );
        PartyCondition = parser.ReadOffset< short >( 154 );
        InstanceContentType = new LazyRow< InstanceContentType >( gameData, parser.ReadOffset< byte >( 156 ), language );
        WeekRestriction = parser.ReadOffset< byte >( 157 );
        Colosseum = new LazyRow< Colosseum >( gameData, parser.ReadOffset< byte >( 158 ), language );
        Unknown55 = parser.ReadOffset< byte >( 159 );
        Unknown56 = parser.ReadOffset< byte >( 160 );
        Unknown57 = parser.ReadOffset< byte >( 161 );
        Unknown58 = parser.ReadOffset< byte >( 162 );
        Unknown69 = parser.ReadOffset< byte >( 163 );
        Unknown63 = parser.ReadOffset< byte >( 164 );
        Unknown3 = parser.ReadOffset< bool >( 165 );
        Unknown10 = parser.ReadOffset< bool >( 165, 2 );
        Unknown52 = parser.ReadOffset< bool >( 165, 4 );
        Unknown59 = parser.ReadOffset< bool >( 165, 8 );
        Unknown66 = parser.ReadOffset< bool >( 165, 16 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Quest", columnHash: 0x1f8c7430 )]
public partial class Quest : ExcelRow
{
    public struct QuestParamsStruct
    {
    	public SeString ScriptInstruction { get; internal set; }
    	public uint ScriptArg { get; internal set; }
    }
    public struct QuestListenerParamsStruct
    {
    	public uint Listener { get; internal set; }
    	public uint ConditionValue { get; internal set; }
    	public ushort Behavior { get; internal set; }
    	public byte ActorSpawnSeq { get; internal set; }
    	public byte ActorDespawnSeq { get; internal set; }
    	public byte QuestUInt8A { get; internal set; }
    	public byte ConditionType { get; internal set; }
    	public byte ConditionOperator { get; internal set; }
    	public bool VisibleBool { get; internal set; }
    	public bool ConditionBool { get; internal set; }
    	public bool ItemBool { get; internal set; }
    	public bool AnnounceBool { get; internal set; }
    	public bool BehaviorBool { get; internal set; }
    	public bool AcceptBool { get; internal set; }
    	public bool QualifiedBool { get; internal set; }
    	public bool CanTargetBool { get; internal set; }
    }
    public struct TodoParamsStruct
    {
    	public LazyRow< Level >[] ToDoLocation { get; internal set; }
    	public byte ToDoCompleteSeq { get; internal set; }
    	public byte ToDoQty { get; internal set; }
    	public byte CountableNum { get; internal set; }
    }
    
    public SeString Name { get; private set; }
    public QuestParamsStruct[] QuestParams { get; private set; }
    public QuestListenerParamsStruct[] QuestListenerParams { get; private set; }
    public TodoParamsStruct[] TodoParams { get; private set; }
    public uint GilReward { get; private set; }
    public LazyRow< Item > CurrencyReward { get; private set; }
    public uint CurrencyRewardCount { get; private set; }
    public ILazyRow[] Reward { get; private set; }
    public LazyRow< Item >[] OptionalItemReward { get; private set; }
    public LazyRow< InstanceContent > InstanceContentUnlock { get; private set; }
    public ushort ExpFactor { get; private set; }
    public LazyRow< Emote > EmoteReward { get; private set; }
    public LazyRow< Action > ActionReward { get; private set; }
    public ushort[] SystemReward { get; private set; }
    public ushort GCTypeReward { get; private set; }
    public LazyRow< Item >[] ItemCatalyst { get; private set; }
    public byte[] ItemCountCatalyst { get; private set; }
    public byte ItemRewardType { get; private set; }
    public byte[] ItemCountReward { get; private set; }
    public LazyRow< Stain >[] RewardStain { get; private set; }
    public byte[] OptionalItemCountReward { get; private set; }
    public LazyRow< Stain >[] OptionalItemStainReward { get; private set; }
    public LazyRow< GeneralAction >[] GeneralActionReward { get; private set; }
    public LazyRow< QuestRewardOther > OtherReward { get; private set; }
    public byte Tomestone { get; private set; }
    public byte TomestoneReward { get; private set; }
    public byte TomestoneCountReward { get; private set; }
    public byte ReputationReward { get; private set; }
    public bool Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool[] OptionalItemIsHQReward { get; private set; }
    public SeString Id { get; private set; }
    public LazyRow< Quest >[] PreviousQuest { get; private set; }
    public LazyRow< Quest >[] QuestLock { get; private set; }
    public LazyRow< InstanceContent >[] InstanceContent { get; private set; }
    public ILazyRow IssuerStart { get; private set; }
    public LazyRow< Level > IssuerLocation { get; private set; }
    public ILazyRow TargetEnd { get; private set; }
    public LazyRow< JournalGenre > JournalGenre { get; private set; }
    public uint Icon { get; private set; }
    public uint IconSpecial { get; private set; }
    public LazyRow< Mount > MountRequired { get; private set; }
    public ushort[] ClassJobLevel { get; private set; }
    public ushort Header { get; private set; }
    public ushort BellStart { get; private set; }
    public ushort BellEnd { get; private set; }
    public ushort BeastReputationValue { get; private set; }
    public LazyRow< Behavior > ClientBehavior { get; private set; }
    public LazyRow< QuestClassJobSupply > QuestClassJobSupply { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public ushort SortKey { get; private set; }
    public LazyRow< ExVersion > Expansion { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory0 { get; private set; }
    public byte QuestLevelOffset { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory1 { get; private set; }
    public byte PreviousQuestJoin { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte QuestLockJoin { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public LazyRow< ClassJob > ClassJobUnlock { get; private set; }
    public LazyRow< GrandCompany > GrandCompany { get; private set; }
    public LazyRow< GrandCompanyRank > GrandCompanyRank { get; private set; }
    public byte InstanceContentJoin { get; private set; }
    public LazyRow< Festival > Festival { get; private set; }
    public byte FestivalBegin { get; private set; }
    public byte FestivalEnd { get; private set; }
    public LazyRow< BeastTribe > BeastTribe { get; private set; }
    public LazyRow< BeastReputationRank > BeastReputationRank { get; private set; }
    public LazyRow< SatisfactionNpc > SatisfactionNpc { get; private set; }
    public byte SatisfactionLevel { get; private set; }
    public LazyRow< DeliveryQuest > DeliveryQuest { get; private set; }
    public byte RepeatIntervalType { get; private set; }
    public LazyRow< QuestRepeatFlag > QuestRepeatFlag { get; private set; }
    public byte Type { get; private set; }
    public byte Unknown_70 { get; private set; }
    public byte LevelMax { get; private set; }
    public LazyRow< ClassJob > ClassJobRequired { get; private set; }
    public LazyRow< QuestRewardOther > QuestRewardOtherDisplay { get; private set; }
    public byte Unknown10 { get; private set; }
    public LazyRow< EventIconType > EventIconType { get; private set; }
    public byte Unknown11 { get; private set; }
    public bool IsHouseRequired { get; private set; }
    public bool IsRepeatable { get; private set; }
    public bool CanCancel { get; private set; }
    public bool Introduction { get; private set; }
    public bool HideOfferIcon { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        QuestParams = new QuestParamsStruct[50];
        for (int i = 0; i < 50; i++)
        {
        	QuestParams[i].ScriptInstruction = parser.ReadOffset< SeString >( (ushort) (i * 8 + 4));
        	QuestParams[i].ScriptArg = parser.ReadOffset< uint >( (ushort) (i * 8 + 8));
        }
        QuestListenerParams = new QuestListenerParamsStruct[64];
        for (int i = 0; i < 64; i++)
        {
        	QuestListenerParams[i].Listener = parser.ReadOffset< uint >( (ushort) (i * 16 + 404));
        	QuestListenerParams[i].ConditionValue = parser.ReadOffset< uint >( (ushort) (i * 16 + 408));
        	QuestListenerParams[i].Behavior = parser.ReadOffset< ushort >( (ushort) (i * 16 + 412));
        	QuestListenerParams[i].ActorSpawnSeq = parser.ReadOffset< byte >( (ushort) (i * 16 + 414));
        	QuestListenerParams[i].ActorDespawnSeq = parser.ReadOffset< byte >( (ushort) (i * 16 + 415));
        	QuestListenerParams[i].QuestUInt8A = parser.ReadOffset< byte >( (ushort) (i * 16 + 416));
        	QuestListenerParams[i].ConditionType = parser.ReadOffset< byte >( (ushort) (i * 16 + 417));
        	QuestListenerParams[i].ConditionOperator = parser.ReadOffset< byte >( (ushort) (i * 16 + 418));
        	QuestListenerParams[i].VisibleBool = parser.ReadOffset< bool >( (ushort) (i * 16 + 419));
        	QuestListenerParams[i].ConditionBool = parser.ReadOffset< bool >( (ushort) (i * 16 + 419), 2);
        	QuestListenerParams[i].ItemBool = parser.ReadOffset< bool >( (ushort) (i * 16 + 419), 4);
        	QuestListenerParams[i].AnnounceBool = parser.ReadOffset< bool >( (ushort) (i * 16 + 419), 8);
        	QuestListenerParams[i].BehaviorBool = parser.ReadOffset< bool >( (ushort) (i * 16 + 419), 16);
        	QuestListenerParams[i].AcceptBool = parser.ReadOffset< bool >( (ushort) (i * 16 + 419), 32);
        	QuestListenerParams[i].QualifiedBool = parser.ReadOffset< bool >( (ushort) (i * 16 + 419), 64);
        	QuestListenerParams[i].CanTargetBool = parser.ReadOffset< bool >( (ushort) (i * 16 + 419), 128);
        }
        TodoParams = new TodoParamsStruct[24];
        for (int i = 0; i < 24; i++)
        {
        	TodoParams[i].ToDoLocation = new LazyRow< Level >[8];
        	for (int ToDoLocationIndexer = 0; ToDoLocationIndexer < 8; ToDoLocationIndexer++)
        		TodoParams[i].ToDoLocation[ToDoLocationIndexer] = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( i * 36 +  1428 + ToDoLocationIndexer * 4 ), language );
        	TodoParams[i].ToDoCompleteSeq = parser.ReadOffset< byte >( (ushort) (i * 36 + 1460));
        	TodoParams[i].ToDoQty = parser.ReadOffset< byte >( (ushort) (i * 36 + 1461));
        	TodoParams[i].CountableNum = parser.ReadOffset< byte >( (ushort) (i * 36 + 1462));
        }
        GilReward = parser.ReadOffset< uint >( 2292 );
        CurrencyReward = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 2296 ), language );
        CurrencyRewardCount = parser.ReadOffset< uint >( 2300 );
        Reward = new ILazyRow[ 7 ];
        UIntSpan RewardRowId = stackalloc uint[ 7 ];
        for( int i = 0; i < 7; i++ )
        {
        	RewardRowId[ i ] = (uint) parser.ReadOffset< int >( 2304 + ( i * 4 ) );
        }
        OptionalItemReward = new LazyRow< Item >[5];
        for (int i = 0; i < 5; i++)
        	OptionalItemReward[i] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) ( 2332 + i * 4 ) ), language );
        InstanceContentUnlock = new LazyRow< InstanceContent >( gameData, parser.ReadOffset< uint >( 2352 ), language );
        ExpFactor = parser.ReadOffset< ushort >( 2356 );
        EmoteReward = new LazyRow< Emote >( gameData, parser.ReadOffset< ushort >( 2358 ), language );
        ActionReward = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 2360 ), language );
        SystemReward = new ushort[2];
        for (int i = 0; i < 2; i++)
        	SystemReward[i] = parser.ReadOffset< ushort >( 2362 + i * 2 );
        GCTypeReward = parser.ReadOffset< ushort >( 2366 );
        ItemCatalyst = new LazyRow< Item >[3];
        for (int i = 0; i < 3; i++)
        	ItemCatalyst[i] = new LazyRow< Item >( gameData, parser.ReadOffset< byte >( (ushort) ( 2368 + i * 1 ) ), language );
        ItemCountCatalyst = new byte[3];
        for (int i = 0; i < 3; i++)
        	ItemCountCatalyst[i] = parser.ReadOffset< byte >( 2371 + i * 1 );
        ItemRewardType = parser.ReadOffset< byte >( 2374 );
        ItemCountReward = new byte[7];
        for (int i = 0; i < 7; i++)
        	ItemCountReward[i] = parser.ReadOffset< byte >( 2375 + i * 1 );
        RewardStain = new LazyRow< Stain >[7];
        for (int i = 0; i < 7; i++)
        	RewardStain[i] = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( (ushort) ( 2382 + i * 1 ) ), language );
        OptionalItemCountReward = new byte[5];
        for (int i = 0; i < 5; i++)
        	OptionalItemCountReward[i] = parser.ReadOffset< byte >( 2389 + i * 1 );
        OptionalItemStainReward = new LazyRow< Stain >[5];
        for (int i = 0; i < 5; i++)
        	OptionalItemStainReward[i] = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( (ushort) ( 2394 + i * 1 ) ), language );
        GeneralActionReward = new LazyRow< GeneralAction >[2];
        for (int i = 0; i < 2; i++)
        	GeneralActionReward[i] = new LazyRow< GeneralAction >( gameData, parser.ReadOffset< byte >( (ushort) ( 2399 + i * 1 ) ), language );
        OtherReward = new LazyRow< QuestRewardOther >( gameData, parser.ReadOffset< byte >( 2401 ), language );
        Tomestone = parser.ReadOffset< byte >( 2402 );
        TomestoneReward = parser.ReadOffset< byte >( 2403 );
        TomestoneCountReward = parser.ReadOffset< byte >( 2404 );
        ReputationReward = parser.ReadOffset< byte >( 2405 );
        Unknown0 = parser.ReadOffset< bool >( 2406 );
        Unknown1 = parser.ReadOffset< bool >( 2407 );
        Unknown2 = parser.ReadOffset< bool >( 2408 );
        Unknown3 = parser.ReadOffset< bool >( 2409 );
        Unknown4 = parser.ReadOffset< bool >( 2410 );
        Unknown5 = parser.ReadOffset< bool >( 2411 );
        Unknown6 = parser.ReadOffset< bool >( 2412 );
        OptionalItemIsHQReward = new bool[5];
        for (int i = 0; i < 5; i++)
        	OptionalItemIsHQReward[i] = parser.ReadOffset< bool >( 2413 + i * 1 );
        Id = parser.ReadOffset< SeString >( 2420 );
        PreviousQuest = new LazyRow< Quest >[3];
        for (int i = 0; i < 3; i++)
        	PreviousQuest[i] = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( (ushort) ( 2424 + i * 4 ) ), language );
        QuestLock = new LazyRow< Quest >[2];
        for (int i = 0; i < 2; i++)
        	QuestLock[i] = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( (ushort) ( 2436 + i * 4 ) ), language );
        InstanceContent = new LazyRow< InstanceContent >[3];
        for (int i = 0; i < 3; i++)
        	InstanceContent[i] = new LazyRow< InstanceContent >( gameData, parser.ReadOffset< uint >( (ushort) ( 2444 + i * 4 ) ), language );
        IssuerStart = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 2456 ), language, "EObjName", "ENpcResident" );
        IssuerLocation = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( 2460 ), language );
        TargetEnd = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 2464 ), language, "EObjName", "ENpcResident" );
        JournalGenre = new LazyRow< JournalGenre >( gameData, parser.ReadOffset< uint >( 2468 ), language );
        Icon = parser.ReadOffset< uint >( 2472 );
        IconSpecial = parser.ReadOffset< uint >( 2476 );
        MountRequired = new LazyRow< Mount >( gameData, parser.ReadOffset< int >( 2480 ), language );
        ClassJobLevel = new ushort[2];
        for (int i = 0; i < 2; i++)
        	ClassJobLevel[i] = parser.ReadOffset< ushort >( 2484 + i * 2 );
        Header = parser.ReadOffset< ushort >( 2488 );
        BellStart = parser.ReadOffset< ushort >( 2490 );
        BellEnd = parser.ReadOffset< ushort >( 2492 );
        BeastReputationValue = parser.ReadOffset< ushort >( 2494 );
        ClientBehavior = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 2496 ), language );
        QuestClassJobSupply = new LazyRow< QuestClassJobSupply >( gameData, parser.ReadOffset< ushort >( 2498 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 2500 ), language );
        SortKey = parser.ReadOffset< ushort >( 2502 );
        Expansion = new LazyRow< ExVersion >( gameData, parser.ReadOffset< byte >( 2504 ), language );
        ClassJobCategory0 = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 2505 ), language );
        QuestLevelOffset = parser.ReadOffset< byte >( 2506 );
        ClassJobCategory1 = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 2507 ), language );
        PreviousQuestJoin = parser.ReadOffset< byte >( 2508 );
        Unknown7 = parser.ReadOffset< byte >( 2509 );
        QuestLockJoin = parser.ReadOffset< byte >( 2510 );
        Unknown8 = parser.ReadOffset< byte >( 2511 );
        Unknown9 = parser.ReadOffset< byte >( 2512 );
        ClassJobUnlock = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 2513 ), language );
        GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadOffset< byte >( 2514 ), language );
        GrandCompanyRank = new LazyRow< GrandCompanyRank >( gameData, parser.ReadOffset< byte >( 2515 ), language );
        InstanceContentJoin = parser.ReadOffset< byte >( 2516 );
        Festival = new LazyRow< Festival >( gameData, parser.ReadOffset< byte >( 2517 ), language );
        FestivalBegin = parser.ReadOffset< byte >( 2518 );
        FestivalEnd = parser.ReadOffset< byte >( 2519 );
        BeastTribe = new LazyRow< BeastTribe >( gameData, parser.ReadOffset< byte >( 2520 ), language );
        BeastReputationRank = new LazyRow< BeastReputationRank >( gameData, parser.ReadOffset< byte >( 2521 ), language );
        SatisfactionNpc = new LazyRow< SatisfactionNpc >( gameData, parser.ReadOffset< byte >( 2522 ), language );
        SatisfactionLevel = parser.ReadOffset< byte >( 2523 );
        DeliveryQuest = new LazyRow< DeliveryQuest >( gameData, parser.ReadOffset< byte >( 2524 ), language );
        RepeatIntervalType = parser.ReadOffset< byte >( 2525 );
        QuestRepeatFlag = new LazyRow< QuestRepeatFlag >( gameData, parser.ReadOffset< byte >( 2526 ), language );
        Type = parser.ReadOffset< byte >( 2527 );
        Unknown_70 = parser.ReadOffset< byte >( 2528 );
        LevelMax = parser.ReadOffset< byte >( 2529 );
        ClassJobRequired = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 2530 ), language );
        QuestRewardOtherDisplay = new LazyRow< QuestRewardOther >( gameData, parser.ReadOffset< byte >( 2531 ), language );
        Unknown10 = parser.ReadOffset< byte >( 2532 );
        EventIconType = new LazyRow< EventIconType >( gameData, parser.ReadOffset< byte >( 2533 ), language );
        Unknown11 = parser.ReadOffset< byte >( 2534 );
        IsHouseRequired = parser.ReadOffset< bool >( 2535 );
        IsRepeatable = parser.ReadOffset< bool >( 2535, 2 );
        CanCancel = parser.ReadOffset< bool >( 2535, 4 );
        Introduction = parser.ReadOffset< bool >( 2535, 8 );
        HideOfferIcon = parser.ReadOffset< bool >( 2535, 16 );
        Unknown12 = parser.ReadOffset< bool >( 2535, 32 );
        Unknown13 = parser.ReadOffset< bool >( 2535, 64 );
        
        for( int i = 0; i < 7; i++ )
        {
        	Reward[ i ] = ItemRewardType switch
        	{
        		1 => new LazyRow< Item >( gameData, RewardRowId[i], language ),
        		3 => new LazyRow< Item >( gameData, RewardRowId[i], language ),
        		5 => new LazyRow< Item >( gameData, RewardRowId[i], language ),
        		6 => new LazyRow< QuestClassJobReward >( gameData, RewardRowId[i], language ),
        		7 => new LazyRow< BeastRankBonus >( gameData, RewardRowId[i], language ),
        		_ => new EmptyLazyRow( (uint) RewardRowId[i] ),
        	};
        }
    }
}
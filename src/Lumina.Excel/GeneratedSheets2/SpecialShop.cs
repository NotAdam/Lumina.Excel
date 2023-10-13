// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SpecialShop", columnHash: 0xd789c459 )]
public partial class SpecialShop : ExcelRow
{
    public struct ItemStruct
    {
    	public uint[] ReceiveCount { get; internal set; }
    	public uint[] CurrencyCost { get; internal set; }
    	public LazyRow< Item >[] Item { get; internal set; }
    	public LazyRow< SpecialShopItemCategory >[] Category { get; internal set; }
    	public int[] ItemCost { get; internal set; }
    	public LazyRow< Quest > Quest { get; internal set; }
    	public int Unknown { get; internal set; }
    	public LazyRow< Achievement > AchievementUnlock { get; internal set; }
    	public ushort[] CollectabilityCost { get; internal set; }
    	public ushort PatchNumber { get; internal set; }
    	public byte[] HqCost { get; internal set; }
    	public byte[] Unknown1 { get; internal set; }
    	public byte[] ReceiveHq { get; internal set; }
    }
    
    public SeString Name { get; private set; }
    public ItemStruct[] Item { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public int CompleteText { get; private set; }
    public int NotCompleteText { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte UseCurrencyType { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Item = new ItemStruct[60];
        for (int i = 0; i < 60; i++)
        {
        	Item[i].ReceiveCount = new uint[2];
        	for (int ReceiveCountIndexer = 0; ReceiveCountIndexer < 2; ReceiveCountIndexer++)
        		Item[i].ReceiveCount[ReceiveCountIndexer] = parser.ReadOffset< uint >( (ushort) ( i * 76 + 4 + ReceiveCountIndexer * 4 ) );
        	Item[i].CurrencyCost = new uint[3];
        	for (int CurrencyCostIndexer = 0; CurrencyCostIndexer < 3; CurrencyCostIndexer++)
        		Item[i].CurrencyCost[CurrencyCostIndexer] = parser.ReadOffset< uint >( (ushort) ( i * 76 + 12 + CurrencyCostIndexer * 4 ) );
        	Item[i].Item = new LazyRow< Item >[2];
        	for (int ItemIndexer = 0; ItemIndexer < 2; ItemIndexer++)
        		Item[i].Item[ItemIndexer] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( i * 76 +  24 + ItemIndexer * 4 ), language );
        	Item[i].Category = new LazyRow< SpecialShopItemCategory >[2];
        	for (int CategoryIndexer = 0; CategoryIndexer < 2; CategoryIndexer++)
        		Item[i].Category[CategoryIndexer] = new LazyRow< SpecialShopItemCategory >( gameData, parser.ReadOffset< int >( i * 76 +  32 + CategoryIndexer * 4 ), language );
        	Item[i].ItemCost = new int[3];
        	for (int ItemCostIndexer = 0; ItemCostIndexer < 3; ItemCostIndexer++)
        		Item[i].ItemCost[ItemCostIndexer] = parser.ReadOffset< int >( (ushort) ( i * 76 + 40 + ItemCostIndexer * 4 ) );
        	Item[i].Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( (ushort) (i * 76 + 52) ), language );
        	Item[i].Unknown = parser.ReadOffset< int >( (ushort) (i * 76 + 56));
        	Item[i].AchievementUnlock = new LazyRow< Achievement >( gameData, parser.ReadOffset< int >( (ushort) (i * 76 + 60) ), language );
        	Item[i].CollectabilityCost = new ushort[3];
        	for (int CollectabilityCostIndexer = 0; CollectabilityCostIndexer < 3; CollectabilityCostIndexer++)
        		Item[i].CollectabilityCost[CollectabilityCostIndexer] = parser.ReadOffset< ushort >( (ushort) ( i * 76 + 64 + CollectabilityCostIndexer * 2 ) );
        	Item[i].PatchNumber = parser.ReadOffset< ushort >( (ushort) (i * 76 + 70));
        	Item[i].HqCost = new byte[3];
        	for (int HqCostIndexer = 0; HqCostIndexer < 3; HqCostIndexer++)
        		Item[i].HqCost[HqCostIndexer] = parser.ReadOffset< byte >( (ushort) ( i * 76 + 72 + HqCostIndexer * 1 ) );
        	Item[i].Unknown1 = new byte[2];
        	for (int Unknown1Indexer = 0; Unknown1Indexer < 2; Unknown1Indexer++)
        		Item[i].Unknown1[Unknown1Indexer] = parser.ReadOffset< byte >( (ushort) ( i * 76 + 75 + Unknown1Indexer * 1 ) );
        	Item[i].ReceiveHq = new byte[3];
        	for (int ReceiveHqIndexer = 0; ReceiveHqIndexer < 3; ReceiveHqIndexer++)
        		Item[i].ReceiveHq[ReceiveHqIndexer] = parser.ReadOffset< byte >( (ushort) ( i * 76 + 77 + ReceiveHqIndexer * 1 ) );
        }
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4564 ), language );
        Unknown2 = parser.ReadOffset< uint >( 4568 );
        Unknown3 = parser.ReadOffset< uint >( 4572 );
        CompleteText = parser.ReadOffset< int >( 4576 );
        NotCompleteText = parser.ReadOffset< int >( 4580 );
        Unknown4 = parser.ReadOffset< ushort >( 4584 );
        UseCurrencyType = parser.ReadOffset< byte >( 4586 );
        Unknown5 = parser.ReadOffset< bool >( 4587 );
        Unknown6 = parser.ReadOffset< bool >( 4587, 2 );
        

    }
}
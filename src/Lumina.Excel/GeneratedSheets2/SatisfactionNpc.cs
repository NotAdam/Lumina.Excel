// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SatisfactionNpc", columnHash: 0xd50a940f )]
public partial class SatisfactionNpc : ExcelRow
{
    public struct SatisfactionNpcParamsStruct
    {
    	public int SupplyIndex { get; internal set; }
    	public LazyRow< Item >[] Item { get; internal set; }
    	public ushort SatisfactionRequired { get; internal set; }
    	public byte[] ItemCount { get; internal set; }
    	public bool[] IsHQ { get; internal set; }
    }
    
    public SatisfactionNpcParamsStruct[] SatisfactionNpcParams { get; private set; }
    public int Unknown70 { get; private set; }
    public int Unknown76 { get; private set; }
    public int Unknown82 { get; private set; }
    public int Unknown71 { get; private set; }
    public int Unknown77 { get; private set; }
    public int Unknown83 { get; private set; }
    public int Unknown72 { get; private set; }
    public int Unknown78 { get; private set; }
    public int Unknown84 { get; private set; }
    public int Unknown73 { get; private set; }
    public int Unknown79 { get; private set; }
    public int Unknown85 { get; private set; }
    public int Unknown74 { get; private set; }
    public int Unknown80 { get; private set; }
    public int Unknown86 { get; private set; }
    public int Unknown75 { get; private set; }
    public int Unknown81 { get; private set; }
    public int Unknown87 { get; private set; }
    public LazyRow< ENpcResident > Npc { get; private set; }
    public LazyRow< Quest > QuestRequired { get; private set; }
    public int Icon { get; private set; }
    public byte LevelUnlock { get; private set; }
    public byte DeliveriesPerWeek { get; private set; }
    public byte Unknown89 { get; private set; }
    public byte Unknown90 { get; private set; }
    public byte Unknown91 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SatisfactionNpcParams = new SatisfactionNpcParamsStruct[6];
        for (int i = 0; i < 6; i++)
        {
        	SatisfactionNpcParams[i].SupplyIndex = parser.ReadOffset< int >( (ushort) (i * 24 + 0));
        	SatisfactionNpcParams[i].Item = new LazyRow< Item >[3];
        	for (int ItemIndexer = 0; ItemIndexer < 3; ItemIndexer++)
        		SatisfactionNpcParams[i].Item[ItemIndexer] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( i * 24 +  4 + ItemIndexer * 4 ), language );
        	SatisfactionNpcParams[i].SatisfactionRequired = parser.ReadOffset< ushort >( (ushort) (i * 24 + 16));
        	SatisfactionNpcParams[i].ItemCount = new byte[3];
        	for (int ItemCountIndexer = 0; ItemCountIndexer < 3; ItemCountIndexer++)
        		SatisfactionNpcParams[i].ItemCount[ItemCountIndexer] = parser.ReadOffset< byte >( (ushort) ( i * 24 + 18 + ItemCountIndexer * 1 ) );
        	SatisfactionNpcParams[i].IsHQ = new bool[3];
        	for (int IsHQIndexer = 0; IsHQIndexer < 3; IsHQIndexer++)
        		SatisfactionNpcParams[i].IsHQ[IsHQIndexer] = parser.ReadOffset< bool >( (ushort) ( i * 24 + 21 + IsHQIndexer * 1 ) );
        }
        Unknown70 = parser.ReadOffset< int >( 144 );
        Unknown76 = parser.ReadOffset< int >( 148 );
        Unknown82 = parser.ReadOffset< int >( 152 );
        Unknown71 = parser.ReadOffset< int >( 156 );
        Unknown77 = parser.ReadOffset< int >( 160 );
        Unknown83 = parser.ReadOffset< int >( 164 );
        Unknown72 = parser.ReadOffset< int >( 168 );
        Unknown78 = parser.ReadOffset< int >( 172 );
        Unknown84 = parser.ReadOffset< int >( 176 );
        Unknown73 = parser.ReadOffset< int >( 180 );
        Unknown79 = parser.ReadOffset< int >( 184 );
        Unknown85 = parser.ReadOffset< int >( 188 );
        Unknown74 = parser.ReadOffset< int >( 192 );
        Unknown80 = parser.ReadOffset< int >( 196 );
        Unknown86 = parser.ReadOffset< int >( 200 );
        Unknown75 = parser.ReadOffset< int >( 204 );
        Unknown81 = parser.ReadOffset< int >( 208 );
        Unknown87 = parser.ReadOffset< int >( 212 );
        Npc = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< int >( 216 ), language );
        QuestRequired = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 220 ), language );
        Icon = parser.ReadOffset< int >( 224 );
        LevelUnlock = parser.ReadOffset< byte >( 228 );
        DeliveriesPerWeek = parser.ReadOffset< byte >( 229 );
        Unknown89 = parser.ReadOffset< byte >( 230 );
        Unknown90 = parser.ReadOffset< byte >( 231 );
        Unknown91 = parser.ReadOffset< byte >( 232 );
        

    }
}
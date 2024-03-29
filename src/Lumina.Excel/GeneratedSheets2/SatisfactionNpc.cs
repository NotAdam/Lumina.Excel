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
    public int Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown3 { get; private set; }
    public int Unknown4 { get; private set; }
    public int Unknown5 { get; private set; }
    public int Unknown6 { get; private set; }
    public int Unknown7 { get; private set; }
    public int Unknown8 { get; private set; }
    public int Unknown9 { get; private set; }
    public int Unknown10 { get; private set; }
    public int Unknown11 { get; private set; }
    public int Unknown12 { get; private set; }
    public int Unknown13 { get; private set; }
    public int Unknown14 { get; private set; }
    public int Unknown15 { get; private set; }
    public int Unknown16 { get; private set; }
    public int Unknown17 { get; private set; }
    public LazyRow< ENpcResident > Npc { get; private set; }
    public LazyRow< Quest > QuestRequired { get; private set; }
    public int Icon { get; private set; }
    public byte LevelUnlock { get; private set; }
    public byte DeliveriesPerWeek { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    
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
        Unknown0 = parser.ReadOffset< int >( 144 );
        Unknown1 = parser.ReadOffset< int >( 148 );
        Unknown2 = parser.ReadOffset< int >( 152 );
        Unknown3 = parser.ReadOffset< int >( 156 );
        Unknown4 = parser.ReadOffset< int >( 160 );
        Unknown5 = parser.ReadOffset< int >( 164 );
        Unknown6 = parser.ReadOffset< int >( 168 );
        Unknown7 = parser.ReadOffset< int >( 172 );
        Unknown8 = parser.ReadOffset< int >( 176 );
        Unknown9 = parser.ReadOffset< int >( 180 );
        Unknown10 = parser.ReadOffset< int >( 184 );
        Unknown11 = parser.ReadOffset< int >( 188 );
        Unknown12 = parser.ReadOffset< int >( 192 );
        Unknown13 = parser.ReadOffset< int >( 196 );
        Unknown14 = parser.ReadOffset< int >( 200 );
        Unknown15 = parser.ReadOffset< int >( 204 );
        Unknown16 = parser.ReadOffset< int >( 208 );
        Unknown17 = parser.ReadOffset< int >( 212 );
        Npc = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< int >( 216 ), language );
        QuestRequired = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 220 ), language );
        Icon = parser.ReadOffset< int >( 224 );
        LevelUnlock = parser.ReadOffset< byte >( 228 );
        DeliveriesPerWeek = parser.ReadOffset< byte >( 229 );
        Unknown18 = parser.ReadOffset< byte >( 230 );
        Unknown19 = parser.ReadOffset< byte >( 231 );
        Unknown20 = parser.ReadOffset< byte >( 232 );
        

    }
}
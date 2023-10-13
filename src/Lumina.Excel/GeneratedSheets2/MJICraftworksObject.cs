// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJICraftworksObject", columnHash: 0xca934bcc )]
public partial class MJICraftworksObject : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< MJICraftworksObjectTheme >[] Theme { get; private set; }
    public ushort Unknown3 { get; private set; }
    public LazyRow< MJIItemPouch >[] Material { get; private set; }
    public ushort[] Amount { get; private set; }
    public ushort LevelReq { get; private set; }
    public ushort CraftingTime { get; private set; }
    public ushort Value { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Theme = new LazyRow< MJICraftworksObjectTheme >[2];
        for (int i = 0; i < 2; i++)
        	Theme[i] = new LazyRow< MJICraftworksObjectTheme >( gameData, parser.ReadOffset< ushort >( (ushort) ( 2 + i * 2 ) ), language );
        Unknown3 = parser.ReadOffset< ushort >( 6 );
        Material = new LazyRow< MJIItemPouch >[4];
        for (int i = 0; i < 4; i++)
        	Material[i] = new LazyRow< MJIItemPouch >( gameData, parser.ReadOffset< ushort >( (ushort) ( 8 + i * 2 ) ), language );
        Amount = new ushort[4];
        for (int i = 0; i < 4; i++)
        	Amount[i] = parser.ReadOffset< ushort >( 16 + i * 2 );
        LevelReq = parser.ReadOffset< ushort >( 24 );
        CraftingTime = parser.ReadOffset< ushort >( 26 );
        Value = parser.ReadOffset< ushort >( 28 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AnimaWeapon5TradeItem", columnHash: 0x40f1e693 )]
public partial class AnimaWeapon5TradeItem : ExcelRow
{
    
    public LazyRow< Item > CrystalSand { get; private set; }
    public LazyRow< Item >[] Item { get; private set; }
    public byte Order { get; private set; }
    public byte ReceiveQuantity { get; private set; }
    public byte[] Quantity { get; private set; }
    public LazyRow< AnimaWeapon5PatternGroup > Category { get; private set; }
    public bool[] IsHQ { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        CrystalSand = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Item = new LazyRow< Item >[8];
        for (int i = 0; i < 8; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) ( 4 + i * 4 ) ), language );
        Order = parser.ReadOffset< byte >( 36 );
        ReceiveQuantity = parser.ReadOffset< byte >( 37 );
        Quantity = new byte[8];
        for (int i = 0; i < 8; i++)
        	Quantity[i] = parser.ReadOffset< byte >( 38 + i * 1 );
        Category = new LazyRow< AnimaWeapon5PatternGroup >( gameData, parser.ReadOffset< byte >( 46 ), language );
        IsHQ = new bool[8];
        for (int i = 0; i < 8; i++)
        	IsHQ[i] = parser.ReadOffset< bool >( 47 + i * 1 );
        

    }
}
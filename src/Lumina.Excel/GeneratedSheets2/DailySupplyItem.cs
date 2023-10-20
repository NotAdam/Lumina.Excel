// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DailySupplyItem", columnHash: 0x5e7b2507 )]
public partial class DailySupplyItem : ExcelRow
{
    
    public LazyRow< Item >[] Item { get; private set; }
    public byte[] Quantity { get; private set; }
    public byte[] RecipeLevel { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >[8];
        for (int i = 0; i < 8; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        Quantity = new byte[8];
        for (int i = 0; i < 8; i++)
        	Quantity[i] = parser.ReadOffset< byte >( 32 + i * 1 );
        RecipeLevel = new byte[8];
        for (int i = 0; i < 8; i++)
        	RecipeLevel[i] = parser.ReadOffset< byte >( 40 + i * 1 );
        

    }
}
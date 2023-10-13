// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIRecipe", columnHash: 0xcfeffbad )]
public partial class MJIRecipe : ExcelRow
{
    
    public LazyRow< LogMessage > LogMessage { get; private set; }
    public LazyRow< MJIKeyItem > KeyItem { get; private set; }
    public LazyRow< MJIItemPouch > ItemPouch { get; private set; }
    public byte Unknown3 { get; private set; }
    public LazyRow< MJIRecipeMaterial >[] Material { get; private set; }
    public byte[] Amount { get; private set; }
    public byte Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LogMessage = new LazyRow< LogMessage >( gameData, parser.ReadOffset< uint >( 0 ), language );
        KeyItem = new LazyRow< MJIKeyItem >( gameData, parser.ReadOffset< byte >( 4 ), language );
        ItemPouch = new LazyRow< MJIItemPouch >( gameData, parser.ReadOffset< byte >( 5 ), language );
        Unknown3 = parser.ReadOffset< byte >( 6 );
        Material = new LazyRow< MJIRecipeMaterial >[5];
        for (int i = 0; i < 5; i++)
        	Material[i] = new LazyRow< MJIRecipeMaterial >( gameData, parser.ReadOffset< byte >( (ushort) ( 7 + i * 1 ) ), language );
        Amount = new byte[5];
        for (int i = 0; i < 5; i++)
        	Amount[i] = parser.ReadOffset< byte >( 12 + i * 1 );
        Order = parser.ReadOffset< byte >( 17 );
        

    }
}
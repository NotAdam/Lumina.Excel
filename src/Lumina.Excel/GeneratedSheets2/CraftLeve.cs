// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CraftLeve", columnHash: 0x51a3acc3 )]
public partial class CraftLeve : ExcelRow
{
    
    public LazyRow< Leve > Leve { get; private set; }
    public LazyRow< CraftLeveTalk > CraftLeveTalk { get; private set; }
    public LazyRow< Item >[] Item { get; private set; }
    public ushort[] ItemCount { get; private set; }
    public byte Repeats { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Leve = new LazyRow< Leve >( gameData, parser.ReadOffset< int >( 0 ), language );
        CraftLeveTalk = new LazyRow< CraftLeveTalk >( gameData, parser.ReadOffset< int >( 4 ), language );
        Item = new LazyRow< Item >[4];
        for (int i = 0; i < 4; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 8 + i * 4 ) ), language );
        ItemCount = new ushort[4];
        for (int i = 0; i < 4; i++)
        	ItemCount[i] = parser.ReadOffset< ushort >( 24 + i * 2 );
        Repeats = parser.ReadOffset< byte >( 32 );
        

    }
}
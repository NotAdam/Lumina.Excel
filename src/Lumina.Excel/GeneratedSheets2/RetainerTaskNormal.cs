// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RetainerTaskNormal", columnHash: 0x644a4310 )]
public partial class RetainerTaskNormal : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< GatheringItem > GatheringLog { get; private set; }
    public ILazyRow FishingLog { get; private set; }
    public byte[] Quantity { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        GatheringLog = new LazyRow< GatheringItem >( gameData, parser.ReadOffset< short >( 4 ), language );
        FishingLog = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< short >( 6 ), language, "SpearfishingItem", "FishParameter" );
        Quantity = new byte[5];
        for (int i = 0; i < 5; i++)
        	Quantity[i] = parser.ReadOffset< byte >( 8 + i * 1 );
        

    }
}
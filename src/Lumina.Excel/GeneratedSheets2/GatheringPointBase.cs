// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringPointBase", columnHash: 0xb34093c0 )]
public partial class GatheringPointBase : ExcelRow
{
    
    public LazyRow< GatheringType > GatheringType { get; private set; }
    public ILazyRow[] Item { get; private set; }
    public byte GatheringLevel { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GatheringType = new LazyRow< GatheringType >( gameData, parser.ReadOffset< int >( 0 ), language );
        Item = new ILazyRow[8];
        for (int i = 0; i < 8; i++)
        	Item[i] = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 4 + i * 4 ), language, "GatheringItem", "SpearfishingItem" );
        GatheringLevel = parser.ReadOffset< byte >( 36 );
        

    }
}
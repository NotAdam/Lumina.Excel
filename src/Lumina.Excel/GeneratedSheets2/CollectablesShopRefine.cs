// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CollectablesShopRefine", columnHash: 0xdc23efe7 )]
public partial class CollectablesShopRefine : ExcelRow
{
    
    public ushort LowCollectability { get; private set; }
    public ushort MidCollectability { get; private set; }
    public ushort HighCollectability { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LowCollectability = parser.ReadOffset< ushort >( 0 );
        MidCollectability = parser.ReadOffset< ushort >( 2 );
        HighCollectability = parser.ReadOffset< ushort >( 4 );
        

    }
}
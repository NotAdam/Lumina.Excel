// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DisposalShopItem", columnHash: 0x1990ed53 )]
public partial class DisposalShopItem : ExcelRow
{
    
    public uint QuantityReceived { get; private set; }
    public LazyRow< Item > ItemDisposed { get; private set; }
    public LazyRow< Item > ItemReceived { get; private set; }
    public ushort Unknown5 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        QuantityReceived = parser.ReadOffset< uint >( 0 );
        ItemDisposed = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        ItemReceived = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 8 ), language );
        Unknown5 = parser.ReadOffset< ushort >( 12 );
        Unknown1 = parser.ReadOffset< bool >( 14 );
        Unknown3 = parser.ReadOffset< bool >( 14, 2 );
        

    }
}
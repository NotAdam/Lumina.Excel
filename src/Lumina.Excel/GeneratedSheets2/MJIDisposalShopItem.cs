// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIDisposalShopItem", columnHash: 0xece42e62 )]
public partial class MJIDisposalShopItem : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public LazyRow< MJIDisposalShopUICategory > Category { get; private set; }
    public byte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 2 );
        Unknown2 = parser.ReadOffset< byte >( 3 );
        Category = new LazyRow< MJIDisposalShopUICategory >( gameData, parser.ReadOffset< byte >( 4 ), language );
        Unknown3 = parser.ReadOffset< byte >( 5 );
        

    }
}
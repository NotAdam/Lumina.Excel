// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Cabinet", columnHash: 0x200261d8 )]
public partial class Cabinet : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public ushort Order { get; private set; }
    public LazyRow< CabinetCategory > Category { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        Order = parser.ReadOffset< ushort >( 4 );
        Category = new LazyRow< CabinetCategory >( gameData, parser.ReadOffset< byte >( 6 ), language );
        

    }
}
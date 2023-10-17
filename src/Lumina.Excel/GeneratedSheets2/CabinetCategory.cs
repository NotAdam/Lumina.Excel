// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CabinetCategory", columnHash: 0x0d4b5075 )]
public partial class CabinetCategory : ExcelRow
{
    
    public int Icon { get; private set; }
    public LazyRow< Addon > Category { get; private set; }
    public byte MenuOrder { get; private set; }
    public byte HideOrder { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< int >( 0 );
        Category = new LazyRow< Addon >( gameData, parser.ReadOffset< int >( 4 ), language );
        MenuOrder = parser.ReadOffset< byte >( 8 );
        HideOrder = parser.ReadOffset< byte >( 9 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemSortCategory", columnHash: 0xdcfd9eba )]
public partial class ItemSortCategory : ExcelRow
{
    
    public byte Param { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Param = parser.ReadOffset< byte >( 0 );
        

    }
}
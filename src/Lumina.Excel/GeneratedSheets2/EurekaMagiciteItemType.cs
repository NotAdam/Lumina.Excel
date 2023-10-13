// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EurekaMagiciteItemType", columnHash: 0xdebb20e3 )]
public partial class EurekaMagiciteItemType : ExcelRow
{
    
    public SeString Type { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Type = parser.ReadOffset< SeString >( 0 );
        

    }
}
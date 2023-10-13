// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FittingShopCategory", columnHash: 0x5eb59ccb )]
public partial class FittingShopCategory : ExcelRow
{
    
    public SeString Unknown1 { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown1 = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< byte >( 4 );
        

    }
}
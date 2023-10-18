// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MYCTemporaryItemUICategory", columnHash: 0x9db0e48f )]
public partial class MYCTemporaryItemUICategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< SeString >( 4 );
        

    }
}
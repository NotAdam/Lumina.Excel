// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RetainerTaskRandom", columnHash: 0x9ab94c53 )]
public partial class RetainerTaskRandom : ExcelRow
{
    
    public SeString Name { get; private set; }
    public short Requirement { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Requirement = parser.ReadOffset< short >( 4 );
        

    }
}
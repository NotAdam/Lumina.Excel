// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RacingChocoboNameCategory", columnHash: 0x5eb59ccb )]
public partial class RacingChocoboNameCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public byte SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        SortKey = parser.ReadOffset< byte >( 4 );
        

    }
}
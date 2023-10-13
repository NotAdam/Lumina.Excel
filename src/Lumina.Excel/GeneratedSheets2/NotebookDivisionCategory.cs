// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "NotebookDivisionCategory", columnHash: 0x9ff65ad6 )]
public partial class NotebookDivisionCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public byte Index { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Index = parser.ReadOffset< byte >( 4 );
        

    }
}
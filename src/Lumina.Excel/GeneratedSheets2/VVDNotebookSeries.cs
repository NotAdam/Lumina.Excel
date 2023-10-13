// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "VVDNotebookSeries", columnHash: 0x1b4af395 )]
public partial class VVDNotebookSeries : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< VVDNotebookContents >[] Contents { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Contents = new LazyRow< VVDNotebookContents >[12];
        for (int i = 0; i < 12; i++)
        	Contents[i] = new LazyRow< VVDNotebookContents >( gameData, parser.ReadOffset< int >( (ushort) ( 4 + i * 4 ) ), language );
        

    }
}
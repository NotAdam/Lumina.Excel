// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MovieSubtitleVoyage", columnHash: 0x07f99ad3 )]
public partial class MovieSubtitleVoyage : ExcelRow
{
    
    public float StartTime { get; private set; }
    public float EndTime { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        StartTime = parser.ReadOffset< float >( 0 );
        EndTime = parser.ReadOffset< float >( 4 );
        

    }
}
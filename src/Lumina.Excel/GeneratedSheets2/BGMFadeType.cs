// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BGMFadeType", columnHash: 0xe018b5fa )]
public partial class BGMFadeType : ExcelRow
{
    
    public float FadeOutTime { get; private set; }
    public float FadeInTime { get; private set; }
    public float FadeInStartTime { get; private set; }
    public float ResumeFadeInTime { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        FadeOutTime = parser.ReadOffset< float >( 0 );
        FadeInTime = parser.ReadOffset< float >( 4 );
        FadeInStartTime = parser.ReadOffset< float >( 8 );
        ResumeFadeInTime = parser.ReadOffset< float >( 12 );
        

    }
}
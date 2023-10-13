// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDDevProgress", columnHash: 0xcd4cb81c )]
public partial class HWDDevProgress : ExcelRow
{
    
    public bool CanGoNext { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        CanGoNext = parser.ReadOffset< bool >( 0 );
        

    }
}
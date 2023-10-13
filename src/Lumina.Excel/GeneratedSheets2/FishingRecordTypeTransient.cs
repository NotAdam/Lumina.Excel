// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FishingRecordTypeTransient", columnHash: 0xda365c51 )]
public partial class FishingRecordTypeTransient : ExcelRow
{
    
    public int Image { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Image = parser.ReadOffset< int >( 0 );
        

    }
}
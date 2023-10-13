// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemOnceHqMasterpiece", columnHash: 0x792adf2d )]
public partial class ItemOnceHqMasterpiece : ExcelRow
{
    
    public bool Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< bool >( 0 );
        Unknown1 = parser.ReadOffset< bool >( 0, 2 );
        

    }
}
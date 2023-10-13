// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDSharedGroupControlParam", columnHash: 0xde74b4c4 )]
public partial class HWDSharedGroupControlParam : ExcelRow
{
    
    public byte Unknown0 { get; private set; }
    public byte ParamValue { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< byte >( 0 );
        ParamValue = parser.ReadOffset< byte >( 1 );
        

    }
}
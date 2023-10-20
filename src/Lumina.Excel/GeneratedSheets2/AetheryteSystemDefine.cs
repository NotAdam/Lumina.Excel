// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AetheryteSystemDefine", columnHash: 0x98fff20a )]
public partial class AetheryteSystemDefine : ExcelRow
{
    
    public SeString Text { get; private set; }
    public uint DefineValue { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        DefineValue = parser.ReadOffset< uint >( 4 );
        

    }
}
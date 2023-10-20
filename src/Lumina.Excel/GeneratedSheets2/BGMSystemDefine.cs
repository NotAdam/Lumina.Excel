// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BGMSystemDefine", columnHash: 0xd16a1b6c )]
public partial class BGMSystemDefine : ExcelRow
{
    
    public float Define { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Define = parser.ReadOffset< float >( 0 );
        

    }
}
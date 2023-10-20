// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionParam", columnHash: 0x8795cd75 )]
public partial class ActionParam : ExcelRow
{
    
    public short Name { get; private set; }
    public short Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< short >( 0 );
        Unknown0 = parser.ReadOffset< short >( 2 );
        

    }
}
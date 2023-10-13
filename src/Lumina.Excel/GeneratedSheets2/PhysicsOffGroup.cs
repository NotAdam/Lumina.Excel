// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PhysicsOffGroup", columnHash: 0x79c1d547 )]
public partial class PhysicsOffGroup : ExcelRow
{
    
    public sbyte Unknown0 { get; private set; }
    public sbyte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< sbyte >( 0 );
        Unknown1 = parser.ReadOffset< sbyte >( 1 );
        

    }
}
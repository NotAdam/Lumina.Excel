// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ExtraCommand", columnHash: 0x173a0318 )]
public partial class ExtraCommand : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public int Icon { get; private set; }
    public sbyte Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        Order = parser.ReadOffset< sbyte >( 12 );
        

    }
}
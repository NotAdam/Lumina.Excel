// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CircleActivity", columnHash: 0x1a6ae0b3 )]
public partial class CircleActivity : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Icon { get; private set; }
    public ushort Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< int >( 4 );
        Order = parser.ReadOffset< ushort >( 8 );
        

    }
}
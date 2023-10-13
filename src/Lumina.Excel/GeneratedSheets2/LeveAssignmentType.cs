// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "LeveAssignmentType", columnHash: 0x7c19f23c )]
public partial class LeveAssignmentType : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Icon { get; private set; }
    public bool IsFaction { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< int >( 4 );
        IsFaction = parser.ReadOffset< bool >( 8 );
        

    }
}
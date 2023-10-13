// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Completion", columnHash: 0x2e6c55a3 )]
public partial class Completion : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString GroupTitle { get; private set; }
    public SeString LookupTable { get; private set; }
    public ushort Group { get; private set; }
    public ushort Key { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        GroupTitle = parser.ReadOffset< SeString >( 4 );
        LookupTable = parser.ReadOffset< SeString >( 8 );
        Group = parser.ReadOffset< ushort >( 12 );
        Key = parser.ReadOffset< ushort >( 14 );
        

    }
}
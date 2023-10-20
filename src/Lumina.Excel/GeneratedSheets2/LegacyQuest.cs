// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "LegacyQuest", columnHash: 0xe0c8dfe4 )]
public partial class LegacyQuest : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString String { get; private set; }
    public uint Genre { get; private set; }
    public ushort LegacyQuestID { get; private set; }
    public ushort SortKey { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        String = parser.ReadOffset< SeString >( 4 );
        Genre = parser.ReadOffset< uint >( 8 );
        LegacyQuestID = parser.ReadOffset< ushort >( 12 );
        SortKey = parser.ReadOffset< ushort >( 14 );
        

    }
}
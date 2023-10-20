// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestRedoChapterUITab", columnHash: 0x198356e8 )]
public partial class QuestRedoChapterUITab : ExcelRow
{
    
    public SeString Text { get; private set; }
    public uint Icon1 { get; private set; }
    public uint Icon2 { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        Icon1 = parser.ReadOffset< uint >( 4 );
        Icon2 = parser.ReadOffset< uint >( 8 );
        Unknown0 = parser.ReadOffset< byte >( 12 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestRedoChapterUI", columnHash: 0x15fc8e10 )]
public partial class QuestRedoChapterUI : ExcelRow
{
    
    public SeString ChapterName { get; private set; }
    public SeString ChapterPart { get; private set; }
    public SeString Transient { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint QuestRedoUISmall { get; private set; }
    public uint QuestRedoUILarge { get; private set; }
    public uint QuestRedoUIWide { get; private set; }
    public LazyRow< QuestRedoChapterUITab > UITab { get; private set; }
    public LazyRow< QuestRedoChapterUICategory > Category { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ChapterName = parser.ReadOffset< SeString >( 0 );
        ChapterPart = parser.ReadOffset< SeString >( 4 );
        Transient = parser.ReadOffset< SeString >( 8 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 12 ), language );
        Unknown0 = parser.ReadOffset< uint >( 16 );
        QuestRedoUISmall = parser.ReadOffset< uint >( 20 );
        QuestRedoUILarge = parser.ReadOffset< uint >( 24 );
        QuestRedoUIWide = parser.ReadOffset< uint >( 28 );
        UITab = new LazyRow< QuestRedoChapterUITab >( gameData, parser.ReadOffset< byte >( 32 ), language );
        Category = new LazyRow< QuestRedoChapterUICategory >( gameData, parser.ReadOffset< byte >( 33 ), language );
        Unknown1 = parser.ReadOffset< byte >( 34 );
        

    }
}
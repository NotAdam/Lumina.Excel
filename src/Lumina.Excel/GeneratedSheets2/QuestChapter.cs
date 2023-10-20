// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestChapter", columnHash: 0x5edc18ea )]
public partial class QuestChapter : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< QuestRedoChapter > Redo { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Redo = new LazyRow< QuestRedoChapter >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompleteJournalCategory", columnHash: 0x976040dd )]
public partial class CompleteJournalCategory : ExcelRow
{
    
    public LazyRow< CompleteJournal > FirstQuest { get; private set; }
    public LazyRow< CompleteJournal > LastQuest { get; private set; }
    public int Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        FirstQuest = new LazyRow< CompleteJournal >( gameData, parser.ReadOffset< uint >( 0 ), language );
        LastQuest = new LazyRow< CompleteJournal >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Unknown0 = parser.ReadOffset< int >( 8 );
        

    }
}
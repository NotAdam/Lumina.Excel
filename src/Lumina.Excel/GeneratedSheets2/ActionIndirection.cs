// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionIndirection", columnHash: 0xc8901190 )]
public partial class ActionIndirection : ExcelRow
{
    
    public LazyRow< Action > Name { get; private set; }
    public LazyRow< Action > PreviousComboAction { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = new LazyRow< Action >( gameData, parser.ReadOffset< int >( 0 ), language );
        PreviousComboAction = new LazyRow< Action >( gameData, parser.ReadOffset< int >( 4 ), language );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< sbyte >( 8 ), language );
        

    }
}
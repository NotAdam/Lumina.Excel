// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestDerivedClass", columnHash: 0xdcfd9eba )]
public partial class QuestDerivedClass : ExcelRow
{
    
    public LazyRow< ClassJob > ClassJob { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 0 ), language );
        

    }
}
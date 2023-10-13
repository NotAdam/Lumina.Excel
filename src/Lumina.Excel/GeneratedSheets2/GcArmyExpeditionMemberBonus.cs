// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GcArmyExpeditionMemberBonus", columnHash: 0xde74b4c4 )]
public partial class GcArmyExpeditionMemberBonus : ExcelRow
{
    
    public LazyRow< Race > Race { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Race = new LazyRow< Race >( gameData, parser.ReadOffset< byte >( 0 ), language );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 1 ), language );
        

    }
}
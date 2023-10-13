// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestAcceptAdditionCondition", columnHash: 0x13045ea4 )]
public partial class QuestAcceptAdditionCondition : ExcelRow
{
    
    public LazyRow< Quest > Requirement0 { get; private set; }
    public LazyRow< Quest > Requirement1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Requirement0 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Requirement1 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Unknown2 = parser.ReadOffset< uint >( 8 );
        Unknown3 = parser.ReadOffset< bool >( 12 );
        

    }
}
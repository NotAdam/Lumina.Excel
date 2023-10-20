// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestDefineClient", columnHash: 0x98fff20a )]
public partial class QuestDefineClient : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public ILazyRow Target { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Target = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 4 ), language, "Item", "Quest", "ENpcBase", "EObjName", "Level" );
        

    }
}
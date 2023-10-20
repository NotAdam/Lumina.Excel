// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestEffectDefine", columnHash: 0xd870e208 )]
public partial class QuestEffectDefine : ExcelRow
{
    
    public LazyRow< QuestEffect > Effect { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Effect = new LazyRow< QuestEffect >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        

    }
}
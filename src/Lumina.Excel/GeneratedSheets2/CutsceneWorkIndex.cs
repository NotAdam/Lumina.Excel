// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CutsceneWorkIndex", columnHash: 0xd870e208 )]
public partial class CutsceneWorkIndex : ExcelRow
{
    
    public ushort WorkIndex { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        WorkIndex = parser.ReadOffset< ushort >( 0 );
        

    }
}
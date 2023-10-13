// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EventIconPriority", columnHash: 0x3bcf5bd0 )]
public partial class EventIconPriority : ExcelRow
{
    
    public uint[] Icon { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = new uint[29];
        for (int i = 0; i < 29; i++)
        	Icon[i] = parser.ReadOffset< uint >( 0 + i * 4 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RetainerTaskParameter", columnHash: 0x4723e1b0 )]
public partial class RetainerTaskParameter : ExcelRow
{
    
    public short[] ItemLevelDoW { get; private set; }
    public short[] PerceptionDoL { get; private set; }
    public short[] PerceptionFSH { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ItemLevelDoW = new short[4];
        for (int i = 0; i < 4; i++)
        	ItemLevelDoW[i] = parser.ReadOffset< short >( 0 + i * 2 );
        PerceptionDoL = new short[4];
        for (int i = 0; i < 4; i++)
        	PerceptionDoL[i] = parser.ReadOffset< short >( 8 + i * 2 );
        PerceptionFSH = new short[4];
        for (int i = 0; i < 4; i++)
        	PerceptionFSH[i] = parser.ReadOffset< short >( 16 + i * 2 );
        

    }
}
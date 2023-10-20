// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringRarePopTimeTable", columnHash: 0x865de322 )]
public partial class GatheringRarePopTimeTable : ExcelRow
{
    
    public ushort[] StartTime { get; private set; }
    public ushort[] Duration { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        StartTime = new ushort[3];
        for (int i = 0; i < 3; i++)
        	StartTime[i] = parser.ReadOffset< ushort >( 0 + i * 2 );
        Duration = new ushort[3];
        for (int i = 0; i < 3; i++)
        	Duration[i] = parser.ReadOffset< ushort >( 6 + i * 2 );
        

    }
}
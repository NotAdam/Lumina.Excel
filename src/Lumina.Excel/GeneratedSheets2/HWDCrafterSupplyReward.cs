// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDCrafterSupplyReward", columnHash: 0x829e9d8e )]
public partial class HWDCrafterSupplyReward : ExcelRow
{
    
    public uint ExpReward { get; private set; }
    public ushort ScriptRewardAmount { get; private set; }
    public ushort Points { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpReward = parser.ReadOffset< uint >( 0 );
        ScriptRewardAmount = parser.ReadOffset< ushort >( 4 );
        Points = parser.ReadOffset< ushort >( 6 );
        

    }
}
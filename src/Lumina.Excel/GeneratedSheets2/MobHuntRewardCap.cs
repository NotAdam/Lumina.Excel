// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MobHuntRewardCap", columnHash: 0xdbf43666 )]
public partial class MobHuntRewardCap : ExcelRow
{
    
    public uint ExpCap { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpCap = parser.ReadOffset< uint >( 0 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RetainerFortuneRewardRange", columnHash: 0xd870e208 )]
public partial class RetainerFortuneRewardRange : ExcelRow
{
    
    public ushort PercentOfLevel { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        PercentOfLevel = parser.ReadOffset< ushort >( 0 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SkyIsland2MissionType", columnHash: 0xcd4cb81c )]
public partial class SkyIsland2MissionType : ExcelRow
{
    
    public bool Type { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Type = parser.ReadOffset< bool >( 0 );
        

    }
}
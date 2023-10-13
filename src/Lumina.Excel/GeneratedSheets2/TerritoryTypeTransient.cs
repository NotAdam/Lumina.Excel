// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TerritoryTypeTransient", columnHash: 0xd9b2883f )]
public partial class TerritoryTypeTransient : ExcelRow
{
    
    public short OffsetZ { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        OffsetZ = parser.ReadOffset< short >( 0 );
        

    }
}
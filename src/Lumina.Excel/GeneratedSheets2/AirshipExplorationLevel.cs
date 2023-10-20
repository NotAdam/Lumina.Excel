// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AirshipExplorationLevel", columnHash: 0x382abf74 )]
public partial class AirshipExplorationLevel : ExcelRow
{
    
    public uint ExpToNext { get; private set; }
    public ushort Capacity { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpToNext = parser.ReadOffset< uint >( 0 );
        Capacity = parser.ReadOffset< ushort >( 4 );
        

    }
}
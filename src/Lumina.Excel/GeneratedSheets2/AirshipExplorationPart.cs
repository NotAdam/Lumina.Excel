// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AirshipExplorationPart", columnHash: 0xc971f464 )]
public partial class AirshipExplorationPart : ExcelRow
{
    
    public ushort Class { get; private set; }
    public short Surveillance { get; private set; }
    public short Retrieval { get; private set; }
    public short Speed { get; private set; }
    public short Range { get; private set; }
    public short Favor { get; private set; }
    public byte Slot { get; private set; }
    public byte Rank { get; private set; }
    public byte Components { get; private set; }
    public byte RepairMaterials { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Class = parser.ReadOffset< ushort >( 0 );
        Surveillance = parser.ReadOffset< short >( 2 );
        Retrieval = parser.ReadOffset< short >( 4 );
        Speed = parser.ReadOffset< short >( 6 );
        Range = parser.ReadOffset< short >( 8 );
        Favor = parser.ReadOffset< short >( 10 );
        Slot = parser.ReadOffset< byte >( 12 );
        Rank = parser.ReadOffset< byte >( 13 );
        Components = parser.ReadOffset< byte >( 14 );
        RepairMaterials = parser.ReadOffset< byte >( 15 );
        

    }
}
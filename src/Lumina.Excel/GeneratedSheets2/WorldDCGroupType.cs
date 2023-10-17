// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WorldDCGroupType", columnHash: 0x23dfe9bd )]
public partial class WorldDCGroupType : ExcelRow
{
    
    public SeString Name { get; private set; }
    public byte Region { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Region = parser.ReadOffset< byte >( 4 );
        Unknown1 = parser.ReadOffset< bool >( 5 );
        

    }
}
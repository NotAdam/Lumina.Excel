// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringType", columnHash: 0x182c5eea )]
public partial class GatheringType : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int IconMain { get; private set; }
    public int IconOff { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        IconMain = parser.ReadOffset< int >( 4 );
        IconOff = parser.ReadOffset< int >( 8 );
        

    }
}
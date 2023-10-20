// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "World", columnHash: 0xae743815 )]
public partial class World : ExcelRow
{
    
    public SeString InternalName { get; private set; }
    public SeString Name { get; private set; }
    public byte Region { get; private set; }
    public byte UserType { get; private set; }
    public LazyRow< WorldDCGroupType > DataCenter { get; private set; }
    public bool IsPublic { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        InternalName = parser.ReadOffset< SeString >( 0 );
        Name = parser.ReadOffset< SeString >( 4 );
        Region = parser.ReadOffset< byte >( 8 );
        UserType = parser.ReadOffset< byte >( 9 );
        DataCenter = new LazyRow< WorldDCGroupType >( gameData, parser.ReadOffset< byte >( 10 ), language );
        IsPublic = parser.ReadOffset< bool >( 11 );
        

    }
}
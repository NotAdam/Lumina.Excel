// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DpsChallenge", columnHash: 0x2fdac054 )]
public partial class DpsChallenge : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public uint Icon { get; private set; }
    public ushort PlayerLevel { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public ushort Order { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        PlayerLevel = parser.ReadOffset< ushort >( 12 );
        Unknown0 = parser.ReadOffset< ushort >( 14 );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        Order = parser.ReadOffset< ushort >( 18 );
        Unknown1 = parser.ReadOffset< bool >( 20 );
        

    }
}
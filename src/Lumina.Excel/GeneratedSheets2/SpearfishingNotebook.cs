// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SpearfishingNotebook", columnHash: 0x0f196a4a )]
public partial class SpearfishingNotebook : ExcelRow
{
    
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public ushort Radius { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public LazyRow< GatheringPointBase > GatheringPointBase { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public short X { get; private set; }
    public short Y { get; private set; }
    public byte GatheringLevel { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool IsShadowNode { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< int >( 0 ), language );
        Radius = parser.ReadOffset< ushort >( 4 );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        GatheringPointBase = new LazyRow< GatheringPointBase >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 10 );
        Unknown1 = parser.ReadOffset< ushort >( 12 );
        X = parser.ReadOffset< short >( 14 );
        Y = parser.ReadOffset< short >( 16 );
        GatheringLevel = parser.ReadOffset< byte >( 18 );
        Unknown2 = parser.ReadOffset< byte >( 19 );
        Unknown3 = parser.ReadOffset< byte >( 20 );
        IsShadowNode = parser.ReadOffset< bool >( 21 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardDesignPreset", columnHash: 0x2c94b01f )]
public partial class CharaCardDesignPreset : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< CharaCardBase > BasePlate { get; private set; }
    public LazyRow< CharaCardDecoration > Backing { get; private set; }
    public LazyRow< CharaCardDecoration > PatternOverlay { get; private set; }
    public LazyRow< CharaCardDecoration > PortraitFrame { get; private set; }
    public LazyRow< CharaCardDecoration > PlateFrame { get; private set; }
    public LazyRow< CharaCardDecoration > Accent { get; private set; }
    public ushort SortKey { get; private set; }
    public LazyRow< CharaCardHeader > TopBorder { get; private set; }
    public LazyRow< CharaCardHeader > BottomBorder { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        BasePlate = new LazyRow< CharaCardBase >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        Backing = new LazyRow< CharaCardDecoration >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        PatternOverlay = new LazyRow< CharaCardDecoration >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        PortraitFrame = new LazyRow< CharaCardDecoration >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        PlateFrame = new LazyRow< CharaCardDecoration >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Accent = new LazyRow< CharaCardDecoration >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        SortKey = parser.ReadOffset< ushort >( 16 );
        TopBorder = new LazyRow< CharaCardHeader >( gameData, parser.ReadOffset< byte >( 18 ), language );
        BottomBorder = new LazyRow< CharaCardHeader >( gameData, parser.ReadOffset< byte >( 19 ), language );
        

    }
}
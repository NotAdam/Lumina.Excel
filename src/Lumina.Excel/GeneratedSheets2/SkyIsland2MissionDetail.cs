// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SkyIsland2MissionDetail", columnHash: 0x62246edb )]
public partial class SkyIsland2MissionDetail : ExcelRow
{
    
    public SeString Objective { get; private set; }
    public SeString Unknown8 { get; private set; }
    public SeString Unknown9 { get; private set; }
    public SeString Unknown10 { get; private set; }
    public LazyRow< EObjName > EObj { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public LazyRow< SkyIsland2MissionType > Type { get; private set; }
    public byte Unknown1 { get; private set; }
    public LazyRow< SkyIsland2RangeType > Range { get; private set; }
    public sbyte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Objective = parser.ReadOffset< SeString >( 0 );
        Unknown8 = parser.ReadOffset< SeString >( 4 );
        Unknown9 = parser.ReadOffset< SeString >( 8 );
        Unknown10 = parser.ReadOffset< SeString >( 12 );
        EObj = new LazyRow< EObjName >( gameData, parser.ReadOffset< uint >( 16 ), language );
        Unknown5 = parser.ReadOffset< uint >( 20 );
        Unknown6 = parser.ReadOffset< uint >( 24 );
        Type = new LazyRow< SkyIsland2MissionType >( gameData, parser.ReadOffset< byte >( 28 ), language );
        Unknown1 = parser.ReadOffset< byte >( 29 );
        Range = new LazyRow< SkyIsland2RangeType >( gameData, parser.ReadOffset< byte >( 30 ), language );
        Unknown3 = parser.ReadOffset< sbyte >( 31 );
        

    }
}
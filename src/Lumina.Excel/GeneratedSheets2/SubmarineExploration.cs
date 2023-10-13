// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SubmarineExploration", columnHash: 0xff922bb4 )]
public partial class SubmarineExploration : ExcelRow
{
    
    public SeString Destination { get; private set; }
    public SeString Location { get; private set; }
    public uint ExpReward { get; private set; }
    public ushort SurveyDurationmin { get; private set; }
    public short X { get; private set; }
    public short Y { get; private set; }
    public short Z { get; private set; }
    public LazyRow< SubmarineMap > Map { get; private set; }
    public byte Stars { get; private set; }
    public byte RankReq { get; private set; }
    public byte CeruleumTankReq { get; private set; }
    public byte SurveyDistance { get; private set; }
    public bool StartingPoint { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Destination = parser.ReadOffset< SeString >( 0 );
        Location = parser.ReadOffset< SeString >( 4 );
        ExpReward = parser.ReadOffset< uint >( 8 );
        SurveyDurationmin = parser.ReadOffset< ushort >( 12 );
        X = parser.ReadOffset< short >( 14 );
        Y = parser.ReadOffset< short >( 16 );
        Z = parser.ReadOffset< short >( 18 );
        Map = new LazyRow< SubmarineMap >( gameData, parser.ReadOffset< byte >( 20 ), language );
        Stars = parser.ReadOffset< byte >( 21 );
        RankReq = parser.ReadOffset< byte >( 22 );
        CeruleumTankReq = parser.ReadOffset< byte >( 23 );
        SurveyDistance = parser.ReadOffset< byte >( 24 );
        StartingPoint = parser.ReadOffset< bool >( 25 );
        

    }
}
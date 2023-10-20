// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AirshipExplorationPoint", columnHash: 0x307f38a2 )]
public partial class AirshipExplorationPoint : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString NameShort { get; private set; }
    public uint ExpReward { get; private set; }
    public ushort CeruleumTankReq { get; private set; }
    public ushort SurveyDurationmin { get; private set; }
    public ushort SurveyDistance { get; private set; }
    public short X { get; private set; }
    public short Y { get; private set; }
    public byte RankReq { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte SurveillanceReq { get; private set; }
    public byte Unknown2 { get; private set; }
    public bool Passengers { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        NameShort = parser.ReadOffset< SeString >( 4 );
        ExpReward = parser.ReadOffset< uint >( 8 );
        CeruleumTankReq = parser.ReadOffset< ushort >( 12 );
        SurveyDurationmin = parser.ReadOffset< ushort >( 14 );
        SurveyDistance = parser.ReadOffset< ushort >( 16 );
        X = parser.ReadOffset< short >( 18 );
        Y = parser.ReadOffset< short >( 20 );
        RankReq = parser.ReadOffset< byte >( 22 );
        Unknown0 = parser.ReadOffset< byte >( 23 );
        Unknown1 = parser.ReadOffset< byte >( 24 );
        SurveillanceReq = parser.ReadOffset< byte >( 25 );
        Unknown2 = parser.ReadOffset< byte >( 26 );
        Passengers = parser.ReadOffset< bool >( 27 );
        

    }
}
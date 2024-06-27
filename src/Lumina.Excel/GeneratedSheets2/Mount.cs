// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Mount", columnHash: 0x304b5115 )]
public partial class Mount : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown0 { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public SeString Unknown1 { get; private set; }
    public SeString Unknown2 { get; private set; }
    public SeString Unknown3 { get; private set; }
    public LazyRow< ModelChara > ModelChara { get; private set; }
    public int EquipHead { get; private set; }
    public int EquipBody { get; private set; }
    public int EquipLeg { get; private set; }
    public int EquipFoot { get; private set; }
    public ushort Unknown4 { get; private set; }
    public LazyRow< BGM > RideBGM { get; private set; }
    public ushort Icon { get; private set; }
    public ushort UIPriority { get; private set; }
    public LazyRow< MountAction > MountAction { get; private set; }
    public ushort Unknown_70_1 { get; private set; }
    public ushort Unknown_70_2 { get; private set; }
    public short Order { get; private set; }
    public LazyRow< MountFlyingCondition > FlyingCondition { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte IsFlying { get; private set; }
    public byte Unknown8 { get; private set; }
    public LazyRow< MountCustomize > MountCustomize { get; private set; }
    public byte ExitMoveDist { get; private set; }
    public byte ExitMoveSpeed { get; private set; }
    public byte RadiusRate { get; private set; }
    public byte BaseMotionSpeed_Run { get; private set; }
    public byte BaseMotionSpeed_Walk { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte ExtraSeats { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool IsEmote { get; private set; }
    public bool IsAirborne { get; private set; }
    public bool ExHotbarEnableConfig { get; private set; }
    public bool UseEP { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool IsImmobile { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        Adjective = parser.ReadOffset< sbyte >( 8 );
        PossessivePronoun = parser.ReadOffset< sbyte >( 9 );
        StartsWithVowel = parser.ReadOffset< sbyte >( 10 );
        Unknown0 = parser.ReadOffset< sbyte >( 11 );
        Pronoun = parser.ReadOffset< sbyte >( 12 );
        Article = parser.ReadOffset< sbyte >( 13 );
        Unknown1 = parser.ReadOffset< SeString >( 16 );
        Unknown2 = parser.ReadOffset< SeString >( 20 );
        Unknown3 = parser.ReadOffset< SeString >( 24 );
        ModelChara = new LazyRow< ModelChara >( gameData, parser.ReadOffset< int >( 28 ), language );
        EquipHead = parser.ReadOffset< int >( 32 );
        EquipBody = parser.ReadOffset< int >( 36 );
        EquipLeg = parser.ReadOffset< int >( 40 );
        EquipFoot = parser.ReadOffset< int >( 44 );
        Unknown4 = parser.ReadOffset< ushort >( 48 );
        RideBGM = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 50 ), language );
        Icon = parser.ReadOffset< ushort >( 52 );
        UIPriority = parser.ReadOffset< ushort >( 54 );
        MountAction = new LazyRow< MountAction >( gameData, parser.ReadOffset< ushort >( 56 ), language );
        Unknown_70_1 = parser.ReadOffset< ushort >( 58 );
        Unknown_70_2 = parser.ReadOffset< ushort >( 60 );
        Order = parser.ReadOffset< short >( 62 );
        FlyingCondition = new LazyRow< MountFlyingCondition >( gameData, parser.ReadOffset< byte >( 64 ), language );
        Unknown5 = parser.ReadOffset< byte >( 65 );
        Unknown6 = parser.ReadOffset< byte >( 66 );
        Unknown7 = parser.ReadOffset< byte >( 67 );
        IsFlying = parser.ReadOffset< byte >( 68 );
        Unknown8 = parser.ReadOffset< byte >( 69 );
        MountCustomize = new LazyRow< MountCustomize >( gameData, parser.ReadOffset< byte >( 70 ), language );
        ExitMoveDist = parser.ReadOffset< byte >( 71 );
        ExitMoveSpeed = parser.ReadOffset< byte >( 72 );
        RadiusRate = parser.ReadOffset< byte >( 73 );
        BaseMotionSpeed_Run = parser.ReadOffset< byte >( 74 );
        BaseMotionSpeed_Walk = parser.ReadOffset< byte >( 75 );
        Unknown9 = parser.ReadOffset< byte >( 76 );
        ExtraSeats = parser.ReadOffset< byte >( 77 );
        Unknown10 = parser.ReadOffset< byte >( 78 );
        Unknown11 = parser.ReadOffset< byte >( 79 );
        Unknown12 = parser.ReadOffset< bool >( 80 );
        IsEmote = parser.ReadOffset< bool >( 80, 2 );
        IsAirborne = parser.ReadOffset< bool >( 80, 4 );
        ExHotbarEnableConfig = parser.ReadOffset< bool >( 80, 8 );
        UseEP = parser.ReadOffset< bool >( 80, 16 );
        Unknown13 = parser.ReadOffset< bool >( 80, 32 );
        IsImmobile = parser.ReadOffset< bool >( 80, 64 );
        Unknown14 = parser.ReadOffset< bool >( 80, 128 );
        Unknown15 = parser.ReadOffset< bool >( 81 );
        

    }
}
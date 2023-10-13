// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Status", columnHash: 0x0dab68bb )]
public partial class Status : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public uint Icon { get; private set; }
    public LazyRow< StatusLoopVFX > VFX { get; private set; }
    public ushort Log { get; private set; }
    public short ParamModifier { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte MaxStacks { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte StatusCategory { get; private set; }
    public LazyRow< StatusHitEffect > HitEffect { get; private set; }
    public byte PartyListPriority { get; private set; }
    public byte CanIncreaseRewards { get; private set; }
    public byte ParamEffect { get; private set; }
    public byte TargetType { get; private set; }
    public byte Flags { get; private set; }
    public byte Unknown31 { get; private set; }
    public sbyte Unknown27 { get; private set; }
    public bool LockMovement { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool LockActions { get; private set; }
    public bool LockControl { get; private set; }
    public bool Transfiguration { get; private set; }
    public bool IsGaze { get; private set; }
    public bool CanDispel { get; private set; }
    public bool InflictedByActor { get; private set; }
    public bool IsPermanent { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool Unknown21 { get; private set; }
    public bool CanStatusOff { get; private set; }
    public bool IsFcBuff { get; private set; }
    public bool Invisibility { get; private set; }
    public bool Unknown32 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        VFX = new LazyRow< StatusLoopVFX >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Log = parser.ReadOffset< ushort >( 14 );
        ParamModifier = parser.ReadOffset< short >( 16 );
        Unknown3 = parser.ReadOffset< byte >( 18 );
        MaxStacks = parser.ReadOffset< byte >( 19 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 20 ), language );
        StatusCategory = parser.ReadOffset< byte >( 21 );
        HitEffect = new LazyRow< StatusHitEffect >( gameData, parser.ReadOffset< byte >( 22 ), language );
        PartyListPriority = parser.ReadOffset< byte >( 23 );
        CanIncreaseRewards = parser.ReadOffset< byte >( 24 );
        ParamEffect = parser.ReadOffset< byte >( 25 );
        TargetType = parser.ReadOffset< byte >( 26 );
        Flags = parser.ReadOffset< byte >( 27 );
        Unknown31 = parser.ReadOffset< byte >( 28 );
        Unknown27 = parser.ReadOffset< sbyte >( 29 );
        LockMovement = parser.ReadOffset< bool >( 30 );
        Unknown10 = parser.ReadOffset< bool >( 30, 2 );
        LockActions = parser.ReadOffset< bool >( 30, 4 );
        LockControl = parser.ReadOffset< bool >( 30, 8 );
        Transfiguration = parser.ReadOffset< bool >( 30, 16 );
        IsGaze = parser.ReadOffset< bool >( 30, 32 );
        CanDispel = parser.ReadOffset< bool >( 30, 64 );
        InflictedByActor = parser.ReadOffset< bool >( 30, 128 );
        IsPermanent = parser.ReadOffset< bool >( 31 );
        Unknown20 = parser.ReadOffset< bool >( 31, 2 );
        Unknown21 = parser.ReadOffset< bool >( 31, 4 );
        CanStatusOff = parser.ReadOffset< bool >( 31, 8 );
        IsFcBuff = parser.ReadOffset< bool >( 31, 16 );
        Invisibility = parser.ReadOffset< bool >( 31, 32 );
        Unknown32 = parser.ReadOffset< bool >( 31, 64 );
        

    }
}
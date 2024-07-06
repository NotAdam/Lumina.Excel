// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Status", columnHash: 0x23d71660 )]
public partial class Status : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public uint Icon { get; private set; }
    public int ParamModifier { get; private set; }
    public LazyRow< StatusLoopVFX > VFX { get; private set; }
    public ushort Log { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte MaxStacks { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte StatusCategory { get; private set; }
    public LazyRow< StatusHitEffect > HitEffect { get; private set; }
    public byte PartyListPriority { get; private set; }
    public byte CanIncreaseRewards { get; private set; }
    public byte ParamEffect { get; private set; }
    public byte TargetType { get; private set; }
    public byte Flags { get; private set; }
    public byte Flag2 { get; private set; }
    public byte Unknown_70_1 { get; private set; }
    public sbyte Unknown2 { get; private set; }
    public bool LockMovement { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool LockActions { get; private set; }
    public bool LockControl { get; private set; }
    public bool Transfiguration { get; private set; }
    public bool IsGaze { get; private set; }
    public bool CanDispel { get; private set; }
    public bool InflictedByActor { get; private set; }
    public bool IsPermanent { get; private set; }
    public bool NoLogVfx { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool CanStatusOff { get; private set; }
    public bool IsFcBuff { get; private set; }
    public bool Invisibility { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown_70_2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        ParamModifier = parser.ReadOffset< int >( 12 );
        VFX = new LazyRow< StatusLoopVFX >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        Log = parser.ReadOffset< ushort >( 18 );
        Unknown0 = parser.ReadOffset< byte >( 20 );
        MaxStacks = parser.ReadOffset< byte >( 21 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 22 ), language );
        StatusCategory = parser.ReadOffset< byte >( 23 );
        HitEffect = new LazyRow< StatusHitEffect >( gameData, parser.ReadOffset< byte >( 24 ), language );
        PartyListPriority = parser.ReadOffset< byte >( 25 );
        CanIncreaseRewards = parser.ReadOffset< byte >( 26 );
        ParamEffect = parser.ReadOffset< byte >( 27 );
        TargetType = parser.ReadOffset< byte >( 28 );
        Flags = parser.ReadOffset< byte >( 29 );
        Flag2 = parser.ReadOffset< byte >( 30 );
        Unknown_70_1 = parser.ReadOffset< byte >( 31 );
        Unknown2 = parser.ReadOffset< sbyte >( 32 );
        LockMovement = parser.ReadOffset< bool >( 33 );
        Unknown3 = parser.ReadOffset< bool >( 33, 2 );
        LockActions = parser.ReadOffset< bool >( 33, 4 );
        LockControl = parser.ReadOffset< bool >( 33, 8 );
        Transfiguration = parser.ReadOffset< bool >( 33, 16 );
        IsGaze = parser.ReadOffset< bool >( 33, 32 );
        CanDispel = parser.ReadOffset< bool >( 33, 64 );
        InflictedByActor = parser.ReadOffset< bool >( 33, 128 );
        IsPermanent = parser.ReadOffset< bool >( 34 );
        NoLogVfx = parser.ReadOffset< bool >( 34, 2 );
        Unknown5 = parser.ReadOffset< bool >( 34, 4 );
        CanStatusOff = parser.ReadOffset< bool >( 34, 8 );
        IsFcBuff = parser.ReadOffset< bool >( 34, 16 );
        Invisibility = parser.ReadOffset< bool >( 34, 32 );
        Unknown6 = parser.ReadOffset< bool >( 34, 64 );
        Unknown_70_2 = parser.ReadOffset< bool >( 34, 128 );
        

    }
}
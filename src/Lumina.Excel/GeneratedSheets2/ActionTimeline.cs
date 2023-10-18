// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionTimeline", columnHash: 0x55e1a16f )]
public partial class ActionTimeline : ExcelRow
{
    
    public SeString Key { get; private set; }
    public ushort KillUpper { get; private set; }
    public byte Type { get; private set; }
    public byte Priority { get; private set; }
    public byte Stance { get; private set; }
    public byte Slot { get; private set; }
    public byte LookAtMode { get; private set; }
    public byte ActionTimelineIDMode { get; private set; }
    public LazyRow< WeaponTimeline > WeaponTimeline { get; private set; }
    public byte LoadType { get; private set; }
    public byte StartAttach { get; private set; }
    public byte ResidentPap { get; private set; }
    public byte IsLoop { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Pause { get; private set; }
    public bool Resident { get; private set; }
    public bool IsMotionCanceledByMoving { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Key = parser.ReadOffset< SeString >( 0 );
        KillUpper = parser.ReadOffset< ushort >( 4 );
        Type = parser.ReadOffset< byte >( 6 );
        Priority = parser.ReadOffset< byte >( 7 );
        Stance = parser.ReadOffset< byte >( 8 );
        Slot = parser.ReadOffset< byte >( 9 );
        LookAtMode = parser.ReadOffset< byte >( 10 );
        ActionTimelineIDMode = parser.ReadOffset< byte >( 11 );
        WeaponTimeline = new LazyRow< WeaponTimeline >( gameData, parser.ReadOffset< byte >( 12 ), language );
        LoadType = parser.ReadOffset< byte >( 13 );
        StartAttach = parser.ReadOffset< byte >( 14 );
        ResidentPap = parser.ReadOffset< byte >( 15 );
        IsLoop = parser.ReadOffset< byte >( 16 );
        Unknown0 = parser.ReadOffset< byte >( 17 );
        Unknown1 = parser.ReadOffset< byte >( 18 );
        Pause = parser.ReadOffset< bool >( 19 );
        Resident = parser.ReadOffset< bool >( 19, 2 );
        IsMotionCanceledByMoving = parser.ReadOffset< bool >( 19, 4 );
        Unknown2 = parser.ReadOffset< bool >( 19, 8 );
        Unknown3 = parser.ReadOffset< bool >( 19, 16 );
        Unknown4 = parser.ReadOffset< bool >( 19, 32 );
        Unknown5 = parser.ReadOffset< bool >( 19, 64 );
        

    }
}
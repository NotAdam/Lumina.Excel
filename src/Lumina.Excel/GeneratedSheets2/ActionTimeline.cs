// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionTimeline", columnHash: 0xd803699f )]
public partial class ActionTimeline : ExcelRow
{
    
    public SeString Key { get; private set; }
    public LazyRow< WeaponTimeline > WeaponTimeline { get; private set; }
    public ushort KillUpper { get; private set; }
    public byte Unknown_70 { get; private set; }
    public byte Type { get; private set; }
    public byte Priority { get; private set; }
    public byte Stance { get; private set; }
    public byte Slot { get; private set; }
    public byte LookAtMode { get; private set; }
    public byte ActionTimelineIDMode { get; private set; }
    public byte LoadType { get; private set; }
    public byte StartAttach { get; private set; }
    public byte ResidentPap { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Pause { get; private set; }
    public bool Resident { get; private set; }
    public bool IsMotionCanceledByMoving { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool IsLoop { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Key = parser.ReadOffset< SeString >( 0 );
        WeaponTimeline = new LazyRow< WeaponTimeline >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        KillUpper = parser.ReadOffset< ushort >( 6 );
        Unknown_70 = parser.ReadOffset< byte >( 8 );
        Type = parser.ReadOffset< byte >( 9 );
        Priority = parser.ReadOffset< byte >( 10 );
        Stance = parser.ReadOffset< byte >( 11 );
        Slot = parser.ReadOffset< byte >( 12 );
        LookAtMode = parser.ReadOffset< byte >( 13 );
        ActionTimelineIDMode = parser.ReadOffset< byte >( 14 );
        LoadType = parser.ReadOffset< byte >( 15 );
        StartAttach = parser.ReadOffset< byte >( 16 );
        ResidentPap = parser.ReadOffset< byte >( 17 );
        Unknown6 = parser.ReadOffset< byte >( 18 );
        Unknown1 = parser.ReadOffset< byte >( 19 );
        Pause = parser.ReadOffset< bool >( 20 );
        Resident = parser.ReadOffset< bool >( 20, 2 );
        IsMotionCanceledByMoving = parser.ReadOffset< bool >( 20, 4 );
        Unknown2 = parser.ReadOffset< bool >( 20, 8 );
        Unknown3 = parser.ReadOffset< bool >( 20, 16 );
        IsLoop = parser.ReadOffset< bool >( 20, 32 );
        Unknown4 = parser.ReadOffset< bool >( 20, 64 );
        

    }
}
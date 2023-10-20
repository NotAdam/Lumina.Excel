// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BNpcState", columnHash: 0x439de63e )]
public partial class BNpcState : ExcelRow
{
    
    public float Scale { get; private set; }
    public int LoopTimeline { get; private set; }
    public ushort Idle { get; private set; }
    public byte Slot { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Attribute0 { get; private set; }
    public byte Attribute1 { get; private set; }
    public byte Attribute2 { get; private set; }
    public byte Unknown1 { get; private set; }
    public sbyte OverRay { get; private set; }
    public sbyte Unknown2 { get; private set; }
    public bool AttributeFlag0 { get; private set; }
    public bool AttributeFlag1 { get; private set; }
    public bool AttributeFlag2 { get; private set; }
    public bool Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Scale = parser.ReadOffset< float >( 0 );
        LoopTimeline = parser.ReadOffset< int >( 4 );
        Idle = parser.ReadOffset< ushort >( 8 );
        Slot = parser.ReadOffset< byte >( 10 );
        Unknown0 = parser.ReadOffset< byte >( 11 );
        Attribute0 = parser.ReadOffset< byte >( 12 );
        Attribute1 = parser.ReadOffset< byte >( 13 );
        Attribute2 = parser.ReadOffset< byte >( 14 );
        Unknown1 = parser.ReadOffset< byte >( 15 );
        OverRay = parser.ReadOffset< sbyte >( 16 );
        Unknown2 = parser.ReadOffset< sbyte >( 17 );
        AttributeFlag0 = parser.ReadOffset< bool >( 18 );
        AttributeFlag1 = parser.ReadOffset< bool >( 19 );
        AttributeFlag2 = parser.ReadOffset< bool >( 20 );
        Unknown3 = parser.ReadOffset< bool >( 21 );
        

    }
}
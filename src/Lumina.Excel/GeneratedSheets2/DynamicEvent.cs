// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DynamicEvent", columnHash: 0x4f7339e4 )]
public partial class DynamicEvent : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public uint LGBEventObject { get; private set; }
    public uint LGBMapRange { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< LogMessage > Announce { get; private set; }
    public short Unknown0 { get; private set; }
    public short Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public LazyRow< DynamicEventType > EventType { get; private set; }
    public LazyRow< DynamicEventEnemyType > EnemyType { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public LazyRow< DynamicEventSingleBattle > SingleBattle { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        LGBEventObject = parser.ReadOffset< uint >( 8 );
        LGBMapRange = parser.ReadOffset< uint >( 12 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 16 ), language );
        Announce = new LazyRow< LogMessage >( gameData, parser.ReadOffset< uint >( 20 ), language );
        Unknown0 = parser.ReadOffset< short >( 24 );
        Unknown1 = parser.ReadOffset< short >( 26 );
        Unknown2 = parser.ReadOffset< short >( 28 );
        EventType = new LazyRow< DynamicEventType >( gameData, parser.ReadOffset< byte >( 30 ), language );
        EnemyType = new LazyRow< DynamicEventEnemyType >( gameData, parser.ReadOffset< byte >( 31 ), language );
        Unknown3 = parser.ReadOffset< byte >( 32 );
        Unknown4 = parser.ReadOffset< byte >( 33 );
        Unknown5 = parser.ReadOffset< byte >( 34 );
        SingleBattle = new LazyRow< DynamicEventSingleBattle >( gameData, parser.ReadOffset< byte >( 35 ), language );
        

    }
}
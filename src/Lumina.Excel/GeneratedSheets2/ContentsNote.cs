// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentsNote", columnHash: 0x748963d8 )]
public partial class ContentsNote : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public LazyRow< Quest > ReqUnlock { get; private set; }
    public int Icon { get; private set; }
    public int RequiredAmount { get; private set; }
    public int ExpMultiplier { get; private set; }
    public int GilRward { get; private set; }
    public int ExpCap { get; private set; }
    public ushort LevelUnlock { get; private set; }
    public LazyRow< HowTo > HowTo { get; private set; }
    public LazyRow< ContentsNoteCategory > ContentType { get; private set; }
    public byte MenuOrder { get; private set; }
    public byte Reward0 { get; private set; }
    public byte Reward1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        ReqUnlock = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Icon = parser.ReadOffset< int >( 12 );
        RequiredAmount = parser.ReadOffset< int >( 16 );
        ExpMultiplier = parser.ReadOffset< int >( 20 );
        GilRward = parser.ReadOffset< int >( 24 );
        ExpCap = parser.ReadOffset< int >( 28 );
        LevelUnlock = parser.ReadOffset< ushort >( 32 );
        HowTo = new LazyRow< HowTo >( gameData, parser.ReadOffset< ushort >( 34 ), language );
        ContentType = new LazyRow< ContentsNoteCategory >( gameData, parser.ReadOffset< byte >( 36 ), language );
        MenuOrder = parser.ReadOffset< byte >( 37 );
        Reward0 = parser.ReadOffset< byte >( 38 );
        Reward1 = parser.ReadOffset< byte >( 39 );
        

    }
}
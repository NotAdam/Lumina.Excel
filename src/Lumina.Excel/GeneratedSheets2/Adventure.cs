// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Adventure", columnHash: 0xf6b785f8 )]
public partial class Adventure : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Impression { get; private set; }
    public SeString Description { get; private set; }
    public LazyRow< Level > Level { get; private set; }
    public int MinLevel { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public int IconList { get; private set; }
    public int IconDiscovered { get; private set; }
    public int IconUndiscovered { get; private set; }
    public LazyRow< Emote > Emote { get; private set; }
    public ushort MinTime { get; private set; }
    public ushort MaxTime { get; private set; }
    public byte MaxLevel { get; private set; }
    public bool IsInitial { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Impression = parser.ReadOffset< SeString >( 4 );
        Description = parser.ReadOffset< SeString >( 8 );
        Level = new LazyRow< Level >( gameData, parser.ReadOffset< int >( 12 ), language );
        MinLevel = parser.ReadOffset< int >( 16 );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 20 ), language );
        IconList = parser.ReadOffset< int >( 24 );
        IconDiscovered = parser.ReadOffset< int >( 28 );
        IconUndiscovered = parser.ReadOffset< int >( 32 );
        Emote = new LazyRow< Emote >( gameData, parser.ReadOffset< ushort >( 36 ), language );
        MinTime = parser.ReadOffset< ushort >( 38 );
        MaxTime = parser.ReadOffset< ushort >( 40 );
        MaxLevel = parser.ReadOffset< byte >( 42 );
        IsInitial = parser.ReadOffset< bool >( 43 );
        

    }
}
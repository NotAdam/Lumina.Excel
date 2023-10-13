// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingPreset", columnHash: 0x9184af18 )]
public partial class HousingPreset : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public LazyRow< Item > ExteriorRoof { get; private set; }
    public LazyRow< Item > ExteriorWall { get; private set; }
    public LazyRow< Item > ExteriorWindow { get; private set; }
    public LazyRow< Item > ExteriorDoor { get; private set; }
    public LazyRow< Item > InteriorWall { get; private set; }
    public LazyRow< Item > InteriorFlooring { get; private set; }
    public LazyRow< Item > InteriorLighting { get; private set; }
    public LazyRow< Item > OtherFloorWall { get; private set; }
    public LazyRow< Item > OtherFloorFlooring { get; private set; }
    public LazyRow< Item > OtherFloorLighting { get; private set; }
    public LazyRow< Item > BasementWall { get; private set; }
    public LazyRow< Item > BasementFlooring { get; private set; }
    public LazyRow< Item > BasementLighting { get; private set; }
    public LazyRow< Item > MansionLighting { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public byte HousingSize { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        Adjective = parser.ReadOffset< sbyte >( 8 );
        PossessivePronoun = parser.ReadOffset< sbyte >( 9 );
        StartsWithVowel = parser.ReadOffset< sbyte >( 10 );
        Unknown5 = parser.ReadOffset< sbyte >( 11 );
        Pronoun = parser.ReadOffset< sbyte >( 12 );
        Article = parser.ReadOffset< sbyte >( 13 );
        ExteriorRoof = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 16 ), language );
        ExteriorWall = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 20 ), language );
        ExteriorWindow = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 24 ), language );
        ExteriorDoor = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 28 ), language );
        InteriorWall = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 32 ), language );
        InteriorFlooring = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 36 ), language );
        InteriorLighting = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 40 ), language );
        OtherFloorWall = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 44 ), language );
        OtherFloorFlooring = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 48 ), language );
        OtherFloorLighting = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 52 ), language );
        BasementWall = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 56 ), language );
        BasementFlooring = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 60 ), language );
        BasementLighting = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 64 ), language );
        MansionLighting = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 68 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 72 ), language );
        HousingSize = parser.ReadOffset< byte >( 74 );
        

    }
}
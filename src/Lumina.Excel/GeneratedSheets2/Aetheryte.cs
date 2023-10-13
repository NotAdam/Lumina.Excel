// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Aetheryte", columnHash: 0xcd1e31a4 )]
public partial class Aetheryte : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public SeString Unknown16 { get; private set; }
    public LazyRow< Level >[] Level { get; private set; }
    public LazyRow< Quest > RequiredQuest { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public LazyRow< PlaceName > AethernetName { get; private set; }
    public LazyRow< TerritoryType > Territory { get; private set; }
    public LazyRow< Map > Map { get; private set; }
    public short AetherstreamX { get; private set; }
    public short AetherstreamY { get; private set; }
    public byte AethernetGroup { get; private set; }
    public byte Order { get; private set; }
    public bool IsAetheryte { get; private set; }
    public bool Invisible { get; private set; }
    
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
        Unknown16 = parser.ReadOffset< SeString >( 16 );
        Level = new LazyRow< Level >[4];
        for (int i = 0; i < 4; i++)
        	Level[i] = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( (ushort) ( 20 + i * 4 ) ), language );
        RequiredQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 36 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 40 ), language );
        AethernetName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 42 ), language );
        Territory = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 44 ), language );
        Map = new LazyRow< Map >( gameData, parser.ReadOffset< ushort >( 46 ), language );
        AetherstreamX = parser.ReadOffset< short >( 48 );
        AetherstreamY = parser.ReadOffset< short >( 50 );
        AethernetGroup = parser.ReadOffset< byte >( 52 );
        Order = parser.ReadOffset< byte >( 53 );
        IsAetheryte = parser.ReadOffset< bool >( 54 );
        Invisible = parser.ReadOffset< bool >( 54, 2 );
        

    }
}
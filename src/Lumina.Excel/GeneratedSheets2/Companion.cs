// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Companion", columnHash: 0x776048c3 )]
public partial class Companion : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public LazyRow< ModelChara > Model { get; private set; }
    public ushort Priority { get; private set; }
    public ushort Enemy { get; private set; }
    public ushort Icon { get; private set; }
    public ushort Order { get; private set; }
    public ushort HP { get; private set; }
    public ushort SkillAngle { get; private set; }
    public ushort Unknown36 { get; private set; }
    public byte Scale { get; private set; }
    public byte InactiveIdle0 { get; private set; }
    public byte InactiveIdle1 { get; private set; }
    public byte InactiveBattle { get; private set; }
    public byte InactiveWandering { get; private set; }
    public LazyRow< CompanionMove > Behavior { get; private set; }
    public byte Special { get; private set; }
    public byte WanderingWait { get; private set; }
    public byte Unknown29 { get; private set; }
    public byte Cost { get; private set; }
    public byte Unknown32 { get; private set; }
    public byte SkillCost { get; private set; }
    public byte Unknown35 { get; private set; }
    public LazyRow< MinionRace > MinionRace { get; private set; }
    public bool Unknown18 { get; private set; }
    public bool Unknown19 { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool Unknown21 { get; private set; }
    public bool Unknown22 { get; private set; }
    public bool Battle { get; private set; }
    public bool Roulette { get; private set; }
    public bool IdleAnimation { get; private set; }
    
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
        Model = new LazyRow< ModelChara >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        Priority = parser.ReadOffset< ushort >( 18 );
        Enemy = parser.ReadOffset< ushort >( 20 );
        Icon = parser.ReadOffset< ushort >( 22 );
        Order = parser.ReadOffset< ushort >( 24 );
        HP = parser.ReadOffset< ushort >( 26 );
        SkillAngle = parser.ReadOffset< ushort >( 28 );
        Unknown36 = parser.ReadOffset< ushort >( 30 );
        Scale = parser.ReadOffset< byte >( 32 );
        InactiveIdle0 = parser.ReadOffset< byte >( 33 );
        InactiveIdle1 = parser.ReadOffset< byte >( 34 );
        InactiveBattle = parser.ReadOffset< byte >( 35 );
        InactiveWandering = parser.ReadOffset< byte >( 36 );
        Behavior = new LazyRow< CompanionMove >( gameData, parser.ReadOffset< byte >( 37 ), language );
        Special = parser.ReadOffset< byte >( 38 );
        WanderingWait = parser.ReadOffset< byte >( 39 );
        Unknown29 = parser.ReadOffset< byte >( 40 );
        Cost = parser.ReadOffset< byte >( 41 );
        Unknown32 = parser.ReadOffset< byte >( 42 );
        SkillCost = parser.ReadOffset< byte >( 43 );
        Unknown35 = parser.ReadOffset< byte >( 44 );
        MinionRace = new LazyRow< MinionRace >( gameData, parser.ReadOffset< byte >( 45 ), language );
        Unknown18 = parser.ReadOffset< bool >( 46 );
        Unknown19 = parser.ReadOffset< bool >( 46, 2 );
        Unknown20 = parser.ReadOffset< bool >( 46, 4 );
        Unknown21 = parser.ReadOffset< bool >( 46, 8 );
        Unknown22 = parser.ReadOffset< bool >( 46, 16 );
        Battle = parser.ReadOffset< bool >( 46, 32 );
        Roulette = parser.ReadOffset< bool >( 46, 64 );
        IdleAnimation = parser.ReadOffset< bool >( 46, 128 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EventItem", columnHash: 0x2a1d4fb2 )]
public partial class EventItem : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public SeString Name { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public bool Unknown8 { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public ushort Icon { get; private set; }
    public LazyRow< Action > Action { get; private set; }
    public byte StackSize { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte CastTime { get; private set; }
    public LazyRow< EventItemCastTimeline > CastTimeline { get; private set; }
    public byte Timeline { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        Name = parser.ReadOffset< SeString >( 8 );
        Adjective = parser.ReadOffset< sbyte >( 12 );
        PossessivePronoun = parser.ReadOffset< sbyte >( 13 );
        StartsWithVowel = parser.ReadOffset< sbyte >( 14 );
        Unknown5 = parser.ReadOffset< sbyte >( 15 );
        Pronoun = parser.ReadOffset< sbyte >( 16 );
        Article = parser.ReadOffset< sbyte >( 17 );
        Unknown8 = parser.ReadOffset< bool >( 18 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 20 ), language );
        Icon = parser.ReadOffset< ushort >( 24 );
        Action = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 26 ), language );
        StackSize = parser.ReadOffset< byte >( 28 );
        Unknown13 = parser.ReadOffset< byte >( 29 );
        CastTime = parser.ReadOffset< byte >( 30 );
        CastTimeline = new LazyRow< EventItemCastTimeline >( gameData, parser.ReadOffset< byte >( 31 ), language );
        Timeline = parser.ReadOffset< byte >( 32 );
        

    }
}
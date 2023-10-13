// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DeepDungeonItem", columnHash: 0x878768c6 )]
public partial class DeepDungeonItem : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public SeString Name { get; private set; }
    public SeString Tooltip { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public uint Icon { get; private set; }
    public LazyRow< Action > Action { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        Name = parser.ReadOffset< SeString >( 8 );
        Tooltip = parser.ReadOffset< SeString >( 12 );
        Adjective = parser.ReadOffset< sbyte >( 16 );
        PossessivePronoun = parser.ReadOffset< sbyte >( 17 );
        StartsWithVowel = parser.ReadOffset< sbyte >( 18 );
        Unknown6 = parser.ReadOffset< sbyte >( 19 );
        Pronoun = parser.ReadOffset< sbyte >( 20 );
        Article = parser.ReadOffset< sbyte >( 21 );
        Icon = parser.ReadOffset< uint >( 24 );
        Action = new LazyRow< Action >( gameData, parser.ReadOffset< uint >( 28 ), language );
        

    }
}
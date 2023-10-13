// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EurekaAetherItem", columnHash: 0x45c06ae0 )]
public partial class EurekaAetherItem : ExcelRow
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
        

    }
}
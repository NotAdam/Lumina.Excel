// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BuddyEquip", columnHash: 0xb429792a )]
public partial class BuddyEquip : ExcelRow
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
    public int ModelTop { get; private set; }
    public int ModelBody { get; private set; }
    public int ModelLegs { get; private set; }
    public ushort IconHead { get; private set; }
    public ushort IconBody { get; private set; }
    public ushort IconLegs { get; private set; }
    public LazyRow< GrandCompany > GrandCompany { get; private set; }
    public byte Order { get; private set; }
    
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
        ModelTop = parser.ReadOffset< int >( 20 );
        ModelBody = parser.ReadOffset< int >( 24 );
        ModelLegs = parser.ReadOffset< int >( 28 );
        IconHead = parser.ReadOffset< ushort >( 32 );
        IconBody = parser.ReadOffset< ushort >( 34 );
        IconLegs = parser.ReadOffset< ushort >( 36 );
        GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadOffset< byte >( 38 ), language );
        Order = parser.ReadOffset< byte >( 39 );
        

    }
}
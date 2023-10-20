// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BeastTribe", columnHash: 0x2faf7b33 )]
public partial class BeastTribe : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Plural { get; private set; }
    public SeString NameRelation { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public sbyte DEF { get; private set; }
    public uint IconReputation { get; private set; }
    public uint Icon { get; private set; }
    public uint Unknown1 { get; private set; }
    public LazyRow< Item > CurrencyItem { get; private set; }
    public byte MinLevel { get; private set; }
    public LazyRow< BeastRankBonus > BeastRankBonus { get; private set; }
    public byte MaxRank { get; private set; }
    public LazyRow< ExVersion > Expansion { get; private set; }
    public byte DisplayOrder { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        NameRelation = parser.ReadOffset< SeString >( 8 );
        Adjective = parser.ReadOffset< sbyte >( 12 );
        PossessivePronoun = parser.ReadOffset< sbyte >( 13 );
        StartsWithVowel = parser.ReadOffset< sbyte >( 14 );
        Pronoun = parser.ReadOffset< sbyte >( 15 );
        Article = parser.ReadOffset< sbyte >( 16 );
        DEF = parser.ReadOffset< sbyte >( 17 );
        IconReputation = parser.ReadOffset< uint >( 20 );
        Icon = parser.ReadOffset< uint >( 24 );
        Unknown1 = parser.ReadOffset< uint >( 28 );
        CurrencyItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 32 ), language );
        MinLevel = parser.ReadOffset< byte >( 36 );
        BeastRankBonus = new LazyRow< BeastRankBonus >( gameData, parser.ReadOffset< byte >( 37 ), language );
        MaxRank = parser.ReadOffset< byte >( 38 );
        Expansion = new LazyRow< ExVersion >( gameData, parser.ReadOffset< byte >( 39 ), language );
        DisplayOrder = parser.ReadOffset< byte >( 40 );
        Unknown0 = parser.ReadOffset< bool >( 41 );
        

    }
}
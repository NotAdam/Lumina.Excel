// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastTribe", columnHash: 0x2faf7b33 )]
    public partial class BeastTribe : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public byte MinLevel { get; set; }
        public LazyRow< BeastRankBonus > BeastRankBonus { get; set; }
        public uint IconReputation { get; set; }
        public uint Icon { get; set; }
        public byte MaxRank { get; set; }
        public LazyRow< ExVersion > Expansion { get; set; }
        public uint Unknown7 { get; set; }
        public LazyRow< Item > CurrencyItem { get; set; }
        public byte DisplayOrder { get; set; }
        public SeString Name { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public sbyte DEF { get; set; }
        public SeString NameRelation { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            MinLevel = parser.ReadColumn< byte >( 1 );
            BeastRankBonus = new LazyRow< BeastRankBonus >( gameData, parser.ReadColumn< byte >( 2 ), language );
            IconReputation = parser.ReadColumn< uint >( 3 );
            Icon = parser.ReadColumn< uint >( 4 );
            MaxRank = parser.ReadColumn< byte >( 5 );
            Expansion = new LazyRow< ExVersion >( gameData, parser.ReadColumn< byte >( 6 ), language );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            CurrencyItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 8 ), language );
            DisplayOrder = parser.ReadColumn< byte >( 9 );
            Name = parser.ReadColumn< SeString >( 10 );
            Adjective = parser.ReadColumn< sbyte >( 11 );
            Plural = parser.ReadColumn< SeString >( 12 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 13 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 14 );
            Pronoun = parser.ReadColumn< sbyte >( 15 );
            Article = parser.ReadColumn< sbyte >( 16 );
            DEF = parser.ReadColumn< sbyte >( 17 );
            NameRelation = parser.ReadColumn< SeString >( 18 );
        }
    }
}
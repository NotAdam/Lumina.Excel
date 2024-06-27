// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeLevelTable", columnHash: 0x463c491f )]
    public partial class RecipeLevelTable : ExcelRow
    {
        
        public byte ClassJobLevel { get; set; }
        public byte Stars { get; set; }
        public ushort SuggestedCraftsmanship { get; set; }
        public ushort Difficulty { get; set; }
        public uint Quality { get; set; }
        public byte ProgressDivider { get; set; }
        public byte QualityDivider { get; set; }
        public byte ProgressModifier { get; set; }
        public byte QualityModifier { get; set; }
        public ushort Durability { get; set; }
        public ushort ConditionsFlag { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassJobLevel = parser.ReadColumn< byte >( 0 );
            Stars = parser.ReadColumn< byte >( 1 );
            SuggestedCraftsmanship = parser.ReadColumn< ushort >( 2 );
            Difficulty = parser.ReadColumn< ushort >( 3 );
            Quality = parser.ReadColumn< uint >( 4 );
            ProgressDivider = parser.ReadColumn< byte >( 5 );
            QualityDivider = parser.ReadColumn< byte >( 6 );
            ProgressModifier = parser.ReadColumn< byte >( 7 );
            QualityModifier = parser.ReadColumn< byte >( 8 );
            Durability = parser.ReadColumn< ushort >( 9 );
            ConditionsFlag = parser.ReadColumn< ushort >( 10 );
        }
    }
}
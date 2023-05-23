// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingNoteInfo", columnHash: 0xbe43ccf1 )]
    public partial class FishingNoteInfo : ExcelRow
    {
        
        public byte Size { get; set; }
        public LazyRow< AquariumWater > AquariumWater { get; set; }
        public byte WeatherRestriction { get; set; }
        public byte TimeRestriction { get; set; }
        public byte SpecialConditions { get; set; }
        public byte IsCollectable { get; set; }
        public int Item { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Size = parser.ReadColumn< byte >( 0 );
            AquariumWater = new LazyRow< AquariumWater >( gameData, parser.ReadColumn< byte >( 1 ), language );
            WeatherRestriction = parser.ReadColumn< byte >( 2 );
            TimeRestriction = parser.ReadColumn< byte >( 3 );
            SpecialConditions = parser.ReadColumn< byte >( 4 );
            IsCollectable = parser.ReadColumn< byte >( 5 );
            Item = parser.ReadColumn< int >( 6 );
        }
    }
}
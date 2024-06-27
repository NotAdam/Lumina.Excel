// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Trait", columnHash: 0xf7b40fdf )]
    public partial class Trait : ExcelRow
    {
        
        public SeString Name { get; set; }
        public int Icon { get; set; }
        public LazyRow< ClassJob > ClassJob { get; set; }
        public byte Unknown3 { get; set; }
        public byte Level { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public short Value { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public byte Unknown8 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Level = parser.ReadColumn< byte >( 4 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 5 ), language );
            Value = parser.ReadColumn< short >( 6 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 7 ), language );
            Unknown8 = parser.ReadColumn< byte >( 8 );
        }
    }
}
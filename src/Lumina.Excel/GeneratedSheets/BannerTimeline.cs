// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerTimeline", columnHash: 0xc47e00f1 )]
    public partial class BannerTimeline : ExcelRow
    {
        
        public byte Type { get; set; }
        public uint AdditionalData { get; set; }
        public LazyRow< ClassJobCategory > AcceptClassJobCategory { get; set; }
        public byte Category { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public ushort Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public ushort SortKey { get; set; }
        public int Icon { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            AdditionalData = parser.ReadColumn< uint >( 1 );
            AcceptClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Category = parser.ReadColumn< byte >( 3 );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            SortKey = parser.ReadColumn< ushort >( 7 );
            Icon = parser.ReadColumn< int >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
        }
    }
}
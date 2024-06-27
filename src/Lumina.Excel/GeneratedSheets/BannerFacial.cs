// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerFacial", columnHash: 0x6025f32a )]
    public partial class BannerFacial : ExcelRow
    {
        
        public LazyRow< Emote > Emote { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public ushort Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public byte SortKey { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Emote = new LazyRow< Emote >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            SortKey = parser.ReadColumn< byte >( 4 );
        }
    }
}
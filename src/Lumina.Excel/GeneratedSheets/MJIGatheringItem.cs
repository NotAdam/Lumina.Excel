// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIGatheringItem", columnHash: 0x0dd2ae8d )]
    public partial class MJIGatheringItem : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public byte Sort { get; set; }
        public LazyRow< MJIGatheringTool > Tool { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public ushort Radius { get; set; }
        public byte Map { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Sort = parser.ReadColumn< byte >( 1 );
            Tool = new LazyRow< MJIGatheringTool >( gameData, parser.ReadColumn< byte >( 2 ), language );
            X = parser.ReadColumn< short >( 3 );
            Y = parser.ReadColumn< short >( 4 );
            Radius = parser.ReadColumn< ushort >( 5 );
            Map = parser.ReadColumn< byte >( 6 );
        }
    }
}
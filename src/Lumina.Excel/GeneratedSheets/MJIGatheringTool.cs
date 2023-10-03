// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIGatheringTool", columnHash: 0xdcfd9eba )]
    public partial class MJIGatheringTool : ExcelRow
    {
        
        public LazyRow< MJIKeyItem > Item { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< MJIKeyItem >( gameData, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaDungeonPortal", columnHash: 0xdbf43666 )]
    public partial class EurekaDungeonPortal : ExcelRow
    {
        
        public LazyRow< Level > LevelId { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LevelId = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}
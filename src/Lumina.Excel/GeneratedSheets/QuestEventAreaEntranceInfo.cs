// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestEventAreaEntranceInfo", columnHash: 0xaeabafd3 )]
    public partial class QuestEventAreaEntranceInfo : ExcelRow
    {
        
        public LazyRow< Quest > Quest { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< Level > Location { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Location = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 2 ), language );
        }
    }
}
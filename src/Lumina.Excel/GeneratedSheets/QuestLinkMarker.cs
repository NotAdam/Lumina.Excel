// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestLinkMarker", columnHash: 0xea112ef0 )]
    public partial class QuestLinkMarker : ExcelRow
    {
        
        public LazyRow< Map > SourceMap { get; set; }
        public LazyRow< Level > Level { get; set; }
        public LazyRow< Map > TargetMap { get; set; }
        public byte Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SourceMap = new LazyRow< Map >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Level = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 1 ), language );
            TargetMap = new LazyRow< Map >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
        }
    }
}
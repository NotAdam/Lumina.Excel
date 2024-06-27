// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JobHudManualPriority", columnHash: 0xa1142ce7 )]
    public partial class JobHudManualPriority : ExcelRow
    {
        
        public LazyRow< JobHudManual >[] JobHudManual { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            JobHudManual = new LazyRow< JobHudManual >[ 8 ];
            for( var i = 0; i < 8; i++ )
                JobHudManual[ i ] = new LazyRow< JobHudManual >( gameData, parser.ReadColumn< byte >( 0 + i ), language );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconPriorityPair", columnHash: 0xdbf43666 )]
    public partial class EventIconPriorityPair : ExcelRow
    {
        
        public uint Icon1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon1 = parser.ReadColumn< uint >( 0 );
        }
    }
}
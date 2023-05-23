// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GathererReductionReward", columnHash: 0x351cf6e2 )]
    public partial class GathererReductionReward : ExcelRow
    {
        
        public ushort Unknown0 { get; set; }
        public bool Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
        }
    }
}
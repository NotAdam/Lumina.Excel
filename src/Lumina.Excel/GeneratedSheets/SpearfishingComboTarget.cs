// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingComboTarget", columnHash: 0x7f711762 )]
    public partial class SpearfishingComboTarget : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public SeString Unknown1 { get; set; }
        public SeString Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
        }
    }
}
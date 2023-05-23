// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TofuObjectCategory", columnHash: 0xce3428a1 )]
    public partial class TofuObjectCategory : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public SeString Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
        }
    }
}
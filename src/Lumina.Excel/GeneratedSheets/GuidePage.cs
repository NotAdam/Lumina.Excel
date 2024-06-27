// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuidePage", columnHash: 0x7fcd4e75 )]
    public partial class GuidePage : ExcelRow
    {
        
        public byte Key { get; set; }
        public bool Unknown1 { get; set; }
        public uint Output { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Key = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Output = parser.ReadColumn< uint >( 2 );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalkDefineClient", columnHash: 0x98fff20a )]
    public partial class CustomTalkDefineClient : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public uint Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< uint >( 1 );
        }
    }
}
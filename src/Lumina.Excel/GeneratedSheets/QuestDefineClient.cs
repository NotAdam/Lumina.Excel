// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestDefineClient", columnHash: 0x98fff20a )]
    public partial class QuestDefineClient : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public uint Target { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Target = parser.ReadColumn< uint >( 1 );
        }
    }
}
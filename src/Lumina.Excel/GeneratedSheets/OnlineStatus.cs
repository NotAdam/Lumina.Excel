// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OnlineStatus", columnHash: 0xbcffd5d8 )]
    public partial class OnlineStatus : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public bool List { get; set; }
        public bool Unknown2 { get; set; }
        public byte Priority { get; set; }
        public uint Icon { get; set; }
        public int Unknown5 { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            List = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Priority = parser.ReadColumn< byte >( 3 );
            Icon = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< int >( 5 );
            Name = parser.ReadColumn< SeString >( 6 );
        }
    }
}
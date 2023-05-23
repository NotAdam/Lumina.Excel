// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconPriority", columnHash: 0x3bcf5bd0 )]
    public partial class EventIconPriority : ExcelRow
    {
        
        public uint[] Icon { get; set; }
        public uint Unknown19 { get; set; }
        public uint Unknown20 { get; set; }
        public uint Unknown21 { get; set; }
        public uint Unknown22 { get; set; }
        public uint Unknown23 { get; set; }
        public uint Unknown24 { get; set; }
        public uint Unknown25 { get; set; }
        public uint Unknown26 { get; set; }
        public uint Unknown27 { get; set; }
        public uint Unknown28 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = new uint[ 19 ];
            for( var i = 0; i < 19; i++ )
                Icon[ i ] = parser.ReadColumn< uint >( 0 + i );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            Unknown20 = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< uint >( 21 );
            Unknown22 = parser.ReadColumn< uint >( 22 );
            Unknown23 = parser.ReadColumn< uint >( 23 );
            Unknown24 = parser.ReadColumn< uint >( 24 );
            Unknown25 = parser.ReadColumn< uint >( 25 );
            Unknown26 = parser.ReadColumn< uint >( 26 );
            Unknown27 = parser.ReadColumn< uint >( 27 );
            Unknown28 = parser.ReadColumn< uint >( 28 );
        }
    }
}
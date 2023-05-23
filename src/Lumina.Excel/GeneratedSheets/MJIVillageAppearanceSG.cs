// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIVillageAppearanceSG", columnHash: 0x98ef9486 )]
    public partial class MJIVillageAppearanceSG : ExcelRow
    {
        
        public LazyRow< ExportedSG >[] SGB { get; set; }
        public ushort Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SGB = new LazyRow< ExportedSG >[ 3 ];
            for( var i = 0; i < 3; i++ )
                SGB[ i ] = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
        }
    }
}
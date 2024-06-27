// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIVillageAppearanceSG", columnHash: 0xf8caa5cf )]
    public partial class MJIVillageAppearanceSG : ExcelRow
    {
        
        public LazyRow< ExportedSG >[] SGB { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SGB = new LazyRow< ExportedSG >[ 5 ];
            for( var i = 0; i < 5; i++ )
                SGB[ i ] = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
        }
    }
}
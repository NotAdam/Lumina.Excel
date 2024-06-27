// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TelepoRelay", columnHash: 0xcafd686e )]
    public partial class TelepoRelay : ExcelRow
    {
        
        public ushort[] TerritoryTypeEntry { get; set; }
        public ushort[] TerritoryTypeExit { get; set; }
        public ushort[] Cost { get; set; }
        public uint Unknown24 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            TerritoryTypeEntry = new ushort[ 8 ];
            for( var i = 0; i < 8; i++ )
                TerritoryTypeEntry[ i ] = parser.ReadColumn< ushort >( 0 + i );
            TerritoryTypeExit = new ushort[ 8 ];
            for( var i = 0; i < 8; i++ )
                TerritoryTypeExit[ i ] = parser.ReadColumn< ushort >( 8 + i );
            Cost = new ushort[ 8 ];
            for( var i = 0; i < 8; i++ )
                Cost[ i ] = parser.ReadColumn< ushort >( 16 + i );
            Unknown24 = parser.ReadColumn< uint >( 24 );
        }
    }
}
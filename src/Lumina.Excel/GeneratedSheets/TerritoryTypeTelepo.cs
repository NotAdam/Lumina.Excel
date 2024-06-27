// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TerritoryTypeTelepo", columnHash: 0x33ff1cee )]
    public partial class TerritoryTypeTelepo : ExcelRow
    {
        
        public ushort X { get; set; }
        public ushort Y { get; set; }
        public ushort Expansion { get; set; }
        public LazyRow< TelepoRelay > TelepoRelay { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            X = parser.ReadColumn< ushort >( 0 );
            Y = parser.ReadColumn< ushort >( 1 );
            Expansion = parser.ReadColumn< ushort >( 2 );
            TelepoRelay = new LazyRow< TelepoRelay >( gameData, parser.ReadColumn< byte >( 3 ), language );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CSBonusContentIdentifier", columnHash: 0xe981d72a )]
    public partial class CSBonusContentIdentifier : ExcelRow
    {
        
        public byte ContentLinkType { get; set; }
        public uint Content { get; set; }
        public bool Unknown2 { get; set; }
        public LazyRow< Quest >[] UnlockQuest { get; set; }
        public uint Unknown6 { get; set; }
        public uint Map { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ContentLinkType = parser.ReadColumn< byte >( 0 );
            Content = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            UnlockQuest = new LazyRow< Quest >[ 3 ];
            for( var i = 0; i < 3; i++ )
                UnlockQuest[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 3 + i ), language );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Map = parser.ReadColumn< uint >( 7 );
        }
    }
}
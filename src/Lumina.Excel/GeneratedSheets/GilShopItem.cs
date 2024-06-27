// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GilShopItem", columnHash: 0xb375f1d2 )]
    public partial class GilShopItem : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public bool Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public LazyRow< Quest >[] QuestRequired { get; set; }
        public LazyRow< Achievement > AchievementRequired { get; set; }
        public byte Unknown7 { get; set; }
        public ushort StateRequired { get; set; }
        public ushort Patch { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            QuestRequired = new LazyRow< Quest >[ 2 ];
            for( var i = 0; i < 2; i++ )
                QuestRequired[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 4 + i ), language );
            AchievementRequired = new LazyRow< Achievement >( gameData, parser.ReadColumn< int >( 6 ), language );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            StateRequired = parser.ReadColumn< ushort >( 8 );
            Patch = parser.ReadColumn< ushort >( 9 );
        }
    }
}
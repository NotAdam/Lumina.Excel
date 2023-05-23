// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerCondition", columnHash: 0x363466df )]
    public partial class BannerCondition : ExcelRow
    {
        
        public byte UnlockType1 { get; set; }
        public uint[] UnlockCriteria1 { get; set; }
        public byte UnlockType2 { get; set; }
        public uint UnlockCriteria2 { get; set; }
        public uint UnlockCriteria3 { get; set; }
        public uint UnlockCriteria4 { get; set; }
        public byte PrerequisiteType { get; set; }
        public uint Prerequisite { get; set; }
        public LazyRow< BannerObtainHintType > UnlockHint { get; set; }
        public bool Unknown14 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnlockType1 = parser.ReadColumn< byte >( 0 );
            UnlockCriteria1 = new uint[ 6 ];
            for( var i = 0; i < 6; i++ )
                UnlockCriteria1[ i ] = parser.ReadColumn< uint >( 1 + i );
            UnlockType2 = parser.ReadColumn< byte >( 7 );
            UnlockCriteria2 = parser.ReadColumn< uint >( 8 );
            UnlockCriteria3 = parser.ReadColumn< uint >( 9 );
            UnlockCriteria4 = parser.ReadColumn< uint >( 10 );
            PrerequisiteType = parser.ReadColumn< byte >( 11 );
            Prerequisite = parser.ReadColumn< uint >( 12 );
            UnlockHint = new LazyRow< BannerObtainHintType >( gameData, parser.ReadColumn< byte >( 13 ), language );
            Unknown14 = parser.ReadColumn< bool >( 14 );
        }
    }
}
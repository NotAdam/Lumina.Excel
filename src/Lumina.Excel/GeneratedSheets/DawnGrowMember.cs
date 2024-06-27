// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnGrowMember", columnHash: 0x83d96633 )]
    public partial class DawnGrowMember : ExcelRow
    {
        
        public uint[] SelectImage { get; set; }
        public uint[] PortraitImage { get; set; }
        public LazyRow< DawnMemberUIParam > Class { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SelectImage = new uint[ 4 ];
            for( var i = 0; i < 4; i++ )
                SelectImage[ i ] = parser.ReadColumn< uint >( 0 + i );
            PortraitImage = new uint[ 4 ];
            for( var i = 0; i < 4; i++ )
                PortraitImage[ i ] = parser.ReadColumn< uint >( 4 + i );
            Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadColumn< byte >( 8 ), language );
        }
    }
}
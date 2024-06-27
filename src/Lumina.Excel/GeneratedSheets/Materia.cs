// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Materia", columnHash: 0x690ce1c4 )]
    public partial class Materia : ExcelRow
    {
        
        public LazyRow< Item >[] Item { get; set; }
        public LazyRow< BaseParam > BaseParam { get; set; }
        public short[] Value { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >[ 16 ];
            for( var i = 0; i < 16; i++ )
                Item[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 + i ), language );
            BaseParam = new LazyRow< BaseParam >( gameData, parser.ReadColumn< byte >( 16 ), language );
            Value = new short[ 16 ];
            for( var i = 0; i < 16; i++ )
                Value[ i ] = parser.ReadColumn< short >( 17 + i );
        }
    }
}
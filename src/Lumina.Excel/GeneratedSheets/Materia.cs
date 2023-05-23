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
        public int Unknown10 { get; set; }
        public int Unknown11 { get; set; }
        public int Unknown12 { get; set; }
        public int Unknown13 { get; set; }
        public int Unknown14 { get; set; }
        public int Unknown15 { get; set; }
        public LazyRow< BaseParam > BaseParam { get; set; }
        public short[] Value { get; set; }
        public short Unknown27 { get; set; }
        public short Unknown28 { get; set; }
        public short Unknown29 { get; set; }
        public short Unknown30 { get; set; }
        public short Unknown31 { get; set; }
        public short Unknown32 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >[ 10 ];
            for( var i = 0; i < 10; i++ )
                Item[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 + i ), language );
            Unknown10 = parser.ReadColumn< int >( 10 );
            Unknown11 = parser.ReadColumn< int >( 11 );
            Unknown12 = parser.ReadColumn< int >( 12 );
            Unknown13 = parser.ReadColumn< int >( 13 );
            Unknown14 = parser.ReadColumn< int >( 14 );
            Unknown15 = parser.ReadColumn< int >( 15 );
            BaseParam = new LazyRow< BaseParam >( gameData, parser.ReadColumn< byte >( 16 ), language );
            Value = new short[ 10 ];
            for( var i = 0; i < 10; i++ )
                Value[ i ] = parser.ReadColumn< short >( 17 + i );
            Unknown27 = parser.ReadColumn< short >( 27 );
            Unknown28 = parser.ReadColumn< short >( 28 );
            Unknown29 = parser.ReadColumn< short >( 29 );
            Unknown30 = parser.ReadColumn< short >( 30 );
            Unknown31 = parser.ReadColumn< short >( 31 );
            Unknown32 = parser.ReadColumn< short >( 32 );
        }
    }
}
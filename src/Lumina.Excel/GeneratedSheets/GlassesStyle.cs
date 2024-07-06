// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GlassesStyle", columnHash: 0xc138bb6e )]
    public partial class GlassesStyle : ExcelRow
    {
        
        public short Unknown0 { get; set; }
        public int Icon { get; set; }
        public ushort Order { get; set; }
        public LazyRow< Glasses >[] Glasses { get; set; }
        public SeString Singular { get; set; }
        public sbyte Unknown16 { get; set; }
        public SeString Plural { get; set; }
        public sbyte Unknown18 { get; set; }
        public sbyte Unknown19 { get; set; }
        public sbyte Unknown20 { get; set; }
        public sbyte Unknown21 { get; set; }
        public sbyte Unknown22 { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< short >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Order = parser.ReadColumn< ushort >( 2 );
            Glasses = new LazyRow< Glasses >[ 12 ];
            for( var i = 0; i < 12; i++ )
                Glasses[ i ] = new LazyRow< Glasses >( gameData, parser.ReadColumn< ushort >( 3 + i ), language );
            Singular = parser.ReadColumn< SeString >( 15 );
            Unknown16 = parser.ReadColumn< sbyte >( 16 );
            Plural = parser.ReadColumn< SeString >( 17 );
            Unknown18 = parser.ReadColumn< sbyte >( 18 );
            Unknown19 = parser.ReadColumn< sbyte >( 19 );
            Unknown20 = parser.ReadColumn< sbyte >( 20 );
            Unknown21 = parser.ReadColumn< sbyte >( 21 );
            Unknown22 = parser.ReadColumn< sbyte >( 22 );
            Name = parser.ReadColumn< SeString >( 23 );
        }
    }
}
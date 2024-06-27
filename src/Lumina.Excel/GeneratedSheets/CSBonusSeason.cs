// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CSBonusSeason", columnHash: 0x05c5101f )]
    public partial class CSBonusSeason : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public LazyRow< Item > Item { get; set; }
        public ushort[] Category { get; set; }
        public LazyRow< CSBonusTextData >[] Text { get; set; }
        public byte Unknown12 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 5 ), language );
            Category = new ushort[ 4 ];
            for( var i = 0; i < 4; i++ )
                Category[ i ] = parser.ReadColumn< ushort >( 6 + i );
            Text = new LazyRow< CSBonusTextData >[ 2 ];
            for( var i = 0; i < 2; i++ )
                Text[ i ] = new LazyRow< CSBonusTextData >( gameData, parser.ReadColumn< byte >( 10 + i ), language );
            Unknown12 = parser.ReadColumn< byte >( 12 );
        }
    }
}
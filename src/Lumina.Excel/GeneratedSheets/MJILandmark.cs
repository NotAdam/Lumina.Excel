// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJILandmark", columnHash: 0x7b947615 )]
    public partial class MJILandmark : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public LazyRow< ExportedSG > SGB0 { get; set; }
        public LazyRow< ExportedSG > SGB1 { get; set; }
        public LazyRow< ExportedSG > SGB2 { get; set; }
        public byte Unknown6 { get; set; }
        public LazyRow< ExportedSG > SGB3 { get; set; }
        public byte Unknown8 { get; set; }
        public LazyRow< ExportedSG > SGB4 { get; set; }
        public byte Unknown10 { get; set; }
        public LazyRow< ExportedSG > SGB5 { get; set; }
        public byte Unknown12 { get; set; }
        public LazyRow< ExportedSG > SGB6 { get; set; }
        public byte Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public LazyRow< MJIItemPouch >[] Material { get; set; }
        public byte[] Amount { get; set; }
        public LazyRow< MJIText > Name { get; set; }
        public ushort Unknown31 { get; set; }
        public uint Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            SGB0 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            SGB1 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            SGB2 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            SGB3 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            SGB4 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            SGB5 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            SGB6 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 13 ), language );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Material = new LazyRow< MJIItemPouch >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Material[ i ] = new LazyRow< MJIItemPouch >( gameData, parser.ReadColumn< ushort >( 20 + i ), language );
            Amount = new byte[ 5 ];
            for( var i = 0; i < 5; i++ )
                Amount[ i ] = parser.ReadColumn< byte >( 25 + i );
            Name = new LazyRow< MJIText >( gameData, parser.ReadColumn< uint >( 30 ), language );
            Unknown31 = parser.ReadColumn< ushort >( 31 );
            Icon = parser.ReadColumn< uint >( 32 );
        }
    }
}
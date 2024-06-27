// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ReplaceAction", columnHash: 0x9575012c )]
    public partial class ReplaceAction : ExcelRow
    {
        
        public LazyRow< Action > Action { get; set; }
        public sbyte Type1 { get; set; }
        public short Param1 { get; set; }
        public LazyRow< Action > ReplaceAction1 { get; set; }
        public sbyte Type2 { get; set; }
        public short Param2 { get; set; }
        public LazyRow< Action > ReplaceAction2 { get; set; }
        public sbyte Type3 { get; set; }
        public short Param3 { get; set; }
        public LazyRow< Action > ReplaceAction3 { get; set; }
        public sbyte ReplaceSettable { get; set; }
        public bool Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Action = new LazyRow< Action >( gameData, parser.ReadColumn< int >( 0 ), language );
            Type1 = parser.ReadColumn< sbyte >( 1 );
            Param1 = parser.ReadColumn< short >( 2 );
            ReplaceAction1 = new LazyRow< Action >( gameData, parser.ReadColumn< int >( 3 ), language );
            Type2 = parser.ReadColumn< sbyte >( 4 );
            Param2 = parser.ReadColumn< short >( 5 );
            ReplaceAction2 = new LazyRow< Action >( gameData, parser.ReadColumn< int >( 6 ), language );
            Type3 = parser.ReadColumn< sbyte >( 7 );
            Param3 = parser.ReadColumn< short >( 8 );
            ReplaceAction3 = new LazyRow< Action >( gameData, parser.ReadColumn< int >( 9 ), language );
            ReplaceSettable = parser.ReadColumn< sbyte >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
        }
    }
}
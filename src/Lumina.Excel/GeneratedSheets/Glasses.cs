// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Glasses", columnHash: 0x2faac2c1 )]
    public partial class Glasses : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public short Unknown1 { get; set; }
        public int Icon { get; set; }
        public ushort Unknown3 { get; set; }
        public SeString Singular { get; set; }
        public sbyte Unknown5 { get; set; }
        public SeString Plural { get; set; }
        public sbyte Unknown7 { get; set; }
        public sbyte Unknown8 { get; set; }
        public sbyte Unknown9 { get; set; }
        public sbyte Unknown10 { get; set; }
        public sbyte Unknown11 { get; set; }
        public SeString Description { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< short >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Singular = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Plural = parser.ReadColumn< SeString >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< sbyte >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
            Unknown10 = parser.ReadColumn< sbyte >( 10 );
            Unknown11 = parser.ReadColumn< sbyte >( 11 );
            Description = parser.ReadColumn< SeString >( 12 );
            Name = parser.ReadColumn< SeString >( 13 );
        }
    }
}
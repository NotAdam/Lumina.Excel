// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonDemiclone", columnHash: 0xc638f2bf )]
    public partial class DeepDungeonDemiclone : ExcelRow
    {
        
        public uint Icon { get; set; }
        public SeString Singular { get; set; }
        public sbyte Unknown2 { get; set; }
        public SeString Plural { get; set; }
        public sbyte Unknown4 { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Unknown6 { get; set; }
        public sbyte Unknown7 { get; set; }
        public sbyte Unknown8 { get; set; }
        public SeString TitleCase { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< uint >( 0 );
            Singular = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< sbyte >( 2 );
            Plural = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< sbyte >( 8 );
            TitleCase = parser.ReadColumn< SeString >( 9 );
            Description = parser.ReadColumn< SeString >( 10 );
        }
    }
}
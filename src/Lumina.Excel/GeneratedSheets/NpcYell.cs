// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NpcYell", columnHash: 0x9cb5d770 )]
    public partial class NpcYell : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public bool Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public byte OutputType { get; set; }
        public byte Unknown5 { get; set; }
        public float BalloonTime { get; set; }
        public bool IsBalloonSlow { get; set; }
        public bool BattleTalkTime { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public SeString Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            OutputType = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            BalloonTime = parser.ReadColumn< float >( 6 );
            IsBalloonSlow = parser.ReadColumn< bool >( 7 );
            BattleTalkTime = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Text = parser.ReadColumn< SeString >( 11 );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MotionTimeline", columnHash: 0x53852bca )]
    public partial class MotionTimeline : ExcelRow
    {
        
        public SeString Filename { get; set; }
        public byte BlendGroup { get; set; }
        public bool IsLoop { get; set; }
        public bool IsBlinkEnable { get; set; }
        public bool IsLipEnable { get; set; }
        public byte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Filename = parser.ReadColumn< SeString >( 0 );
            BlendGroup = parser.ReadColumn< byte >( 1 );
            IsLoop = parser.ReadColumn< bool >( 2 );
            IsBlinkEnable = parser.ReadColumn< bool >( 3 );
            IsLipEnable = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}
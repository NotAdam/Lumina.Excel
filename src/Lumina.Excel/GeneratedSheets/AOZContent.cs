// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZContent", columnHash: 0xb05ff0c9 )]
    public partial class AOZContent : ExcelRow
    {
        
        public ushort StandardFinishTime { get; set; }
        public ushort IdealFinishTime { get; set; }
        public byte Act1FightType { get; set; }
        public ushort Act1 { get; set; }
        public byte ArenaType1 { get; set; }
        public ushort Unknown5 { get; set; }
        public byte Act2FightType { get; set; }
        public ushort Act2 { get; set; }
        public byte ArenaType2 { get; set; }
        public ushort Unknown9 { get; set; }
        public byte Act3FightType { get; set; }
        public ushort Act3 { get; set; }
        public byte ArenaType3 { get; set; }
        public ushort Unknown13 { get; set; }
        public uint ContentEntry { get; set; }
        public byte Order { get; set; }
        public ushort GilReward { get; set; }
        public ushort AlliedSealsReward { get; set; }
        public ushort TomestonesReward { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            StandardFinishTime = parser.ReadColumn< ushort >( 0 );
            IdealFinishTime = parser.ReadColumn< ushort >( 1 );
            Act1FightType = parser.ReadColumn< byte >( 2 );
            Act1 = parser.ReadColumn< ushort >( 3 );
            ArenaType1 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Act2FightType = parser.ReadColumn< byte >( 6 );
            Act2 = parser.ReadColumn< ushort >( 7 );
            ArenaType2 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            Act3FightType = parser.ReadColumn< byte >( 10 );
            Act3 = parser.ReadColumn< ushort >( 11 );
            ArenaType3 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< ushort >( 13 );
            ContentEntry = parser.ReadColumn< uint >( 14 );
            Order = parser.ReadColumn< byte >( 15 );
            GilReward = parser.ReadColumn< ushort >( 16 );
            AlliedSealsReward = parser.ReadColumn< ushort >( 17 );
            TomestonesReward = parser.ReadColumn< ushort >( 18 );
        }
    }
}
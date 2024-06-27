// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NpcEquip", columnHash: 0x4004f596 )]
    public partial class NpcEquip : ExcelRow
    {
        
        public ulong ModelMainHand { get; set; }
        public LazyRow< Stain > DyeMainHand { get; set; }
        public LazyRow< Stain > Dye2MainHand { get; set; }
        public ulong ModelOffHand { get; set; }
        public LazyRow< Stain > DyeOffHand { get; set; }
        public LazyRow< Stain > Dye2OffHand { get; set; }
        public uint ModelHead { get; set; }
        public LazyRow< Stain > DyeHead { get; set; }
        public LazyRow< Stain > Dye2Head { get; set; }
        public bool Visor { get; set; }
        public uint ModelBody { get; set; }
        public LazyRow< Stain > DyeBody { get; set; }
        public LazyRow< Stain > Dye2Body { get; set; }
        public uint ModelHands { get; set; }
        public LazyRow< Stain > DyeHands { get; set; }
        public LazyRow< Stain > Dye2Hands { get; set; }
        public uint ModelLegs { get; set; }
        public LazyRow< Stain > DyeLegs { get; set; }
        public LazyRow< Stain > Dye2Legs { get; set; }
        public uint ModelFeet { get; set; }
        public LazyRow< Stain > DyeFeet { get; set; }
        public LazyRow< Stain > Dye2Feet { get; set; }
        public uint ModelEars { get; set; }
        public LazyRow< Stain > DyeEars { get; set; }
        public LazyRow< Stain > Dye2Ears { get; set; }
        public uint ModelNeck { get; set; }
        public LazyRow< Stain > DyeNeck { get; set; }
        public LazyRow< Stain > Dye2Neck { get; set; }
        public uint ModelWrists { get; set; }
        public LazyRow< Stain > DyeWrists { get; set; }
        public LazyRow< Stain > Dye2Wrists { get; set; }
        public uint ModelLeftRing { get; set; }
        public LazyRow< Stain > DyeLeftRing { get; set; }
        public LazyRow< Stain > Dye2LeftRing { get; set; }
        public uint ModelRightRing { get; set; }
        public LazyRow< Stain > DyeRightRing { get; set; }
        public LazyRow< Stain > Dye2RightRing { get; set; }
        public ushort Unknown37 { get; set; }
        public ushort Unknown38 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ModelMainHand = parser.ReadColumn< ulong >( 0 );
            DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Dye2MainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 2 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 3 );
            DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 4 ), language );
            Dye2OffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 5 ), language );
            ModelHead = parser.ReadColumn< uint >( 6 );
            DyeHead = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 7 ), language );
            Dye2Head = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 8 ), language );
            Visor = parser.ReadColumn< bool >( 9 );
            ModelBody = parser.ReadColumn< uint >( 10 );
            DyeBody = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 11 ), language );
            Dye2Body = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 12 ), language );
            ModelHands = parser.ReadColumn< uint >( 13 );
            DyeHands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 14 ), language );
            Dye2Hands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 15 ), language );
            ModelLegs = parser.ReadColumn< uint >( 16 );
            DyeLegs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 17 ), language );
            Dye2Legs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 18 ), language );
            ModelFeet = parser.ReadColumn< uint >( 19 );
            DyeFeet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 20 ), language );
            Dye2Feet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 21 ), language );
            ModelEars = parser.ReadColumn< uint >( 22 );
            DyeEars = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 23 ), language );
            Dye2Ears = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 24 ), language );
            ModelNeck = parser.ReadColumn< uint >( 25 );
            DyeNeck = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 26 ), language );
            Dye2Neck = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 27 ), language );
            ModelWrists = parser.ReadColumn< uint >( 28 );
            DyeWrists = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 29 ), language );
            Dye2Wrists = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 30 ), language );
            ModelLeftRing = parser.ReadColumn< uint >( 31 );
            DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 32 ), language );
            Dye2LeftRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 33 ), language );
            ModelRightRing = parser.ReadColumn< uint >( 34 );
            DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 35 ), language );
            Dye2RightRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 36 ), language );
            Unknown37 = parser.ReadColumn< ushort >( 37 );
            Unknown38 = parser.ReadColumn< ushort >( 38 );
        }
    }
}
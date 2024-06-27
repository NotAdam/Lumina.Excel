// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcBase", columnHash: 0x464052cd )]
    public partial class ENpcBase : ExcelRow
    {
        
        public ushort EventHandler { get; set; }
        public bool Important { get; set; }
        public uint[] ENpcData { get; set; }
        public float Scale { get; set; }
        public LazyRow< ModelChara > ModelChara { get; set; }
        public LazyRow< Race > Race { get; set; }
        public byte Gender { get; set; }
        public byte BodyType { get; set; }
        public byte Height { get; set; }
        public LazyRow< Tribe > Tribe { get; set; }
        public byte Face { get; set; }
        public byte HairStyle { get; set; }
        public byte HairHighlight { get; set; }
        public byte SkinColor { get; set; }
        public byte EyeHeterochromia { get; set; }
        public byte HairColor { get; set; }
        public byte HairHighlightColor { get; set; }
        public byte FacialFeature { get; set; }
        public byte FacialFeatureColor { get; set; }
        public byte Eyebrows { get; set; }
        public byte EyeColor { get; set; }
        public byte EyeShape { get; set; }
        public byte Nose { get; set; }
        public byte Jaw { get; set; }
        public byte Mouth { get; set; }
        public byte LipColor { get; set; }
        public byte BustOrTone1 { get; set; }
        public byte ExtraFeature1 { get; set; }
        public byte ExtraFeature2OrBust { get; set; }
        public byte FacePaint { get; set; }
        public byte FacePaintColor { get; set; }
        public byte Unknown62 { get; set; }
        public LazyRow< NpcEquip > NpcEquip { get; set; }
        public LazyRow< Behavior > Behavior { get; set; }
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
        public ushort Unknown102 { get; set; }
        public ushort Unknown103 { get; set; }
        public byte Invisibility { get; set; }
        public LazyRow< Balloon > Balloon { get; set; }
        public bool NotRewriteHeight { get; set; }
        public byte DefaultBalloon { get; set; }
        public byte Unknown108 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EventHandler = parser.ReadColumn< ushort >( 0 );
            Important = parser.ReadColumn< bool >( 1 );
            ENpcData = new uint[ 32 ];
            for( var i = 0; i < 32; i++ )
                ENpcData[ i ] = parser.ReadColumn< uint >( 2 + i );
            Scale = parser.ReadColumn< float >( 34 );
            ModelChara = new LazyRow< ModelChara >( gameData, parser.ReadColumn< ushort >( 35 ), language );
            Race = new LazyRow< Race >( gameData, parser.ReadColumn< byte >( 36 ), language );
            Gender = parser.ReadColumn< byte >( 37 );
            BodyType = parser.ReadColumn< byte >( 38 );
            Height = parser.ReadColumn< byte >( 39 );
            Tribe = new LazyRow< Tribe >( gameData, parser.ReadColumn< byte >( 40 ), language );
            Face = parser.ReadColumn< byte >( 41 );
            HairStyle = parser.ReadColumn< byte >( 42 );
            HairHighlight = parser.ReadColumn< byte >( 43 );
            SkinColor = parser.ReadColumn< byte >( 44 );
            EyeHeterochromia = parser.ReadColumn< byte >( 45 );
            HairColor = parser.ReadColumn< byte >( 46 );
            HairHighlightColor = parser.ReadColumn< byte >( 47 );
            FacialFeature = parser.ReadColumn< byte >( 48 );
            FacialFeatureColor = parser.ReadColumn< byte >( 49 );
            Eyebrows = parser.ReadColumn< byte >( 50 );
            EyeColor = parser.ReadColumn< byte >( 51 );
            EyeShape = parser.ReadColumn< byte >( 52 );
            Nose = parser.ReadColumn< byte >( 53 );
            Jaw = parser.ReadColumn< byte >( 54 );
            Mouth = parser.ReadColumn< byte >( 55 );
            LipColor = parser.ReadColumn< byte >( 56 );
            BustOrTone1 = parser.ReadColumn< byte >( 57 );
            ExtraFeature1 = parser.ReadColumn< byte >( 58 );
            ExtraFeature2OrBust = parser.ReadColumn< byte >( 59 );
            FacePaint = parser.ReadColumn< byte >( 60 );
            FacePaintColor = parser.ReadColumn< byte >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            NpcEquip = new LazyRow< NpcEquip >( gameData, parser.ReadColumn< ushort >( 63 ), language );
            Behavior = new LazyRow< Behavior >( gameData, parser.ReadColumn< ushort >( 64 ), language );
            ModelMainHand = parser.ReadColumn< ulong >( 65 );
            DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 66 ), language );
            Dye2MainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 67 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 68 );
            DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 69 ), language );
            Dye2OffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 70 ), language );
            ModelHead = parser.ReadColumn< uint >( 71 );
            DyeHead = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 72 ), language );
            Dye2Head = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 73 ), language );
            Visor = parser.ReadColumn< bool >( 74 );
            ModelBody = parser.ReadColumn< uint >( 75 );
            DyeBody = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 76 ), language );
            Dye2Body = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 77 ), language );
            ModelHands = parser.ReadColumn< uint >( 78 );
            DyeHands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 79 ), language );
            Dye2Hands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 80 ), language );
            ModelLegs = parser.ReadColumn< uint >( 81 );
            DyeLegs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 82 ), language );
            Dye2Legs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 83 ), language );
            ModelFeet = parser.ReadColumn< uint >( 84 );
            DyeFeet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 85 ), language );
            Dye2Feet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 86 ), language );
            ModelEars = parser.ReadColumn< uint >( 87 );
            DyeEars = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 88 ), language );
            Dye2Ears = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 89 ), language );
            ModelNeck = parser.ReadColumn< uint >( 90 );
            DyeNeck = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 91 ), language );
            Dye2Neck = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 92 ), language );
            ModelWrists = parser.ReadColumn< uint >( 93 );
            DyeWrists = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 94 ), language );
            Dye2Wrists = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 95 ), language );
            ModelLeftRing = parser.ReadColumn< uint >( 96 );
            DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 97 ), language );
            Dye2LeftRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 98 ), language );
            ModelRightRing = parser.ReadColumn< uint >( 99 );
            DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 100 ), language );
            Dye2RightRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 101 ), language );
            Unknown102 = parser.ReadColumn< ushort >( 102 );
            Unknown103 = parser.ReadColumn< ushort >( 103 );
            Invisibility = parser.ReadColumn< byte >( 104 );
            Balloon = new LazyRow< Balloon >( gameData, parser.ReadColumn< ushort >( 105 ), language );
            NotRewriteHeight = parser.ReadColumn< bool >( 106 );
            DefaultBalloon = parser.ReadColumn< byte >( 107 );
            Unknown108 = parser.ReadColumn< byte >( 108 );
        }
    }
}
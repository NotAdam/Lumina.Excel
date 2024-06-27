// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcDressUpDress", columnHash: 0xb07c9caa )]
    public partial class ENpcDressUpDress : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public bool Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public LazyRow< ENpcResident > ENpc { get; set; }
        public ushort Unknown8 { get; set; }
        public LazyRow< Behavior > Behavior { get; set; }
        public ushort Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public byte Unknown27 { get; set; }
        public byte Unknown28 { get; set; }
        public byte Unknown29 { get; set; }
        public byte Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public byte Unknown32 { get; set; }
        public byte Unknown33 { get; set; }
        public byte Unknown34 { get; set; }
        public byte Unknown35 { get; set; }
        public byte Unknown36 { get; set; }
        public ulong ModelMainHand { get; set; }
        public LazyRow< Stain > DyeMainHand { get; set; }
        public LazyRow< Stain > Dye2MainHand { get; set; }
        public ulong ModelOffHand { get; set; }
        public LazyRow< Stain > DyeOffHand { get; set; }
        public LazyRow< Stain > Dye2OffHand { get; set; }
        public uint ModelHead { get; set; }
        public LazyRow< Stain > DyeHead { get; set; }
        public LazyRow< Stain > Dye2Head { get; set; }
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
        public uint Unknown58 { get; set; }
        public byte Unknown59 { get; set; }
        public byte Unknown60 { get; set; }
        public uint Unknown61 { get; set; }
        public byte Unknown62 { get; set; }
        public byte Unknown63 { get; set; }
        public uint Unknown64 { get; set; }
        public byte Unknown65 { get; set; }
        public byte Unknown66 { get; set; }
        public uint Unknown67 { get; set; }
        public byte Unknown68 { get; set; }
        public byte Unknown69 { get; set; }
        public uint Unknown70 { get; set; }
        public byte Unknown71 { get; set; }
        public byte Unknown72 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            ENpc = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 7 ), language );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Behavior = new LazyRow< Behavior >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            Unknown33 = parser.ReadColumn< byte >( 33 );
            Unknown34 = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< byte >( 36 );
            ModelMainHand = parser.ReadColumn< ulong >( 37 );
            DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 38 ), language );
            Dye2MainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 39 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 40 );
            DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 41 ), language );
            Dye2OffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 42 ), language );
            ModelHead = parser.ReadColumn< uint >( 43 );
            DyeHead = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 44 ), language );
            Dye2Head = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 45 ), language );
            ModelBody = parser.ReadColumn< uint >( 46 );
            DyeBody = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 47 ), language );
            Dye2Body = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 48 ), language );
            ModelHands = parser.ReadColumn< uint >( 49 );
            DyeHands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 50 ), language );
            Dye2Hands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 51 ), language );
            ModelLegs = parser.ReadColumn< uint >( 52 );
            DyeLegs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 53 ), language );
            Dye2Legs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 54 ), language );
            ModelFeet = parser.ReadColumn< uint >( 55 );
            DyeFeet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 56 ), language );
            Dye2Feet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 57 ), language );
            Unknown58 = parser.ReadColumn< uint >( 58 );
            Unknown59 = parser.ReadColumn< byte >( 59 );
            Unknown60 = parser.ReadColumn< byte >( 60 );
            Unknown61 = parser.ReadColumn< uint >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< uint >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< uint >( 67 );
            Unknown68 = parser.ReadColumn< byte >( 68 );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            Unknown70 = parser.ReadColumn< uint >( 70 );
            Unknown71 = parser.ReadColumn< byte >( 71 );
            Unknown72 = parser.ReadColumn< byte >( 72 );
        }
    }
}
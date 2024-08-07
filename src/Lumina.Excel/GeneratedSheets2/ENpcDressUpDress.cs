// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ENpcDressUpDress", columnHash: 0xb07c9caa )]
public partial class ENpcDressUpDress : ExcelRow
{
    
    public ulong ModelMainHand { get; private set; }
    public ulong ModelOffHand { get; private set; }
    public uint Unknown0 { get; private set; }
    public LazyRow< ENpcResident > ENpc { get; private set; }
    public uint ModelHead { get; private set; }
    public uint ModelBody { get; private set; }
    public uint ModelHands { get; private set; }
    public uint ModelLegs { get; private set; }
    public uint ModelFeet { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public LazyRow< Behavior > Behavior { get; private set; }
    public ushort Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    public byte Unknown21 { get; private set; }
    public byte Unknown22 { get; private set; }
    public byte Unknown23 { get; private set; }
    public byte Unknown24 { get; private set; }
    public byte Unknown25 { get; private set; }
    public byte Unknown26 { get; private set; }
    public byte Unknown27 { get; private set; }
    public byte Unknown28 { get; private set; }
    public byte Unknown29 { get; private set; }
    public byte Unknown30 { get; private set; }
    public byte Unknown31 { get; private set; }
    public byte Unknown32 { get; private set; }
    public byte Unknown33 { get; private set; }
    public byte Unknown34 { get; private set; }
    public LazyRow< Stain > DyeMainHand { get; private set; }
    public LazyRow< Stain > Dye2MainHand { get; private set; }
    public LazyRow< Stain > DyeOffHand { get; private set; }
    public LazyRow< Stain > Dye2OffHand { get; private set; }
    public LazyRow< Stain > DyeHead { get; private set; }
    public LazyRow< Stain > DyeBody { get; private set; }
    public LazyRow< Stain > DyeHands { get; private set; }
    public LazyRow< Stain > DyeLegs { get; private set; }
    public LazyRow< Stain > DyeFeet { get; private set; }
    public LazyRow< Stain > DyeEars { get; private set; }
    public LazyRow< Stain > DyeNeck { get; private set; }
    public LazyRow< Stain > DyeWrists { get; private set; }
    public LazyRow< Stain > DyeLeftRing { get; private set; }
    public LazyRow< Stain > DyeRightRing { get; private set; }
    public LazyRow< Stain > Dye2Head { get; private set; }
    public LazyRow< Stain > Dye2Body { get; private set; }
    public LazyRow< Stain > Dye2Hands { get; private set; }
    public LazyRow< Stain > Dye2Legs { get; private set; }
    public LazyRow< Stain > Dye2Feet { get; private set; }
    public LazyRow< Stain > Dye2Ears { get; private set; }
    public LazyRow< Stain > Dye2Neck { get; private set; }
    public LazyRow< Stain > Dye2Wrists { get; private set; }
    public LazyRow< Stain > Dye2LeftRing { get; private set; }
    public LazyRow< Stain > Dye2RightRing { get; private set; }
    public bool Unknown40 { get; private set; }
    public bool Unknown41 { get; private set; }
    public bool Unknown42 { get; private set; }
    public bool Unknown43 { get; private set; }
    public bool Unknown44 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ModelMainHand = parser.ReadOffset< ulong >( 0 );
        ModelOffHand = parser.ReadOffset< ulong >( 8 );
        Unknown0 = parser.ReadOffset< uint >( 16 );
        ENpc = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 20 ), language );
        ModelHead = parser.ReadOffset< uint >( 24 );
        ModelBody = parser.ReadOffset< uint >( 28 );
        ModelHands = parser.ReadOffset< uint >( 32 );
        ModelLegs = parser.ReadOffset< uint >( 36 );
        ModelFeet = parser.ReadOffset< uint >( 40 );
        Unknown1 = parser.ReadOffset< uint >( 44 );
        Unknown2 = parser.ReadOffset< uint >( 48 );
        Unknown3 = parser.ReadOffset< uint >( 52 );
        Unknown4 = parser.ReadOffset< uint >( 56 );
        Unknown5 = parser.ReadOffset< uint >( 60 );
        Unknown6 = parser.ReadOffset< ushort >( 64 );
        Behavior = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 66 ), language );
        Unknown7 = parser.ReadOffset< ushort >( 68 );
        Unknown8 = parser.ReadOffset< byte >( 70 );
        Unknown9 = parser.ReadOffset< byte >( 71 );
        Unknown10 = parser.ReadOffset< byte >( 72 );
        Unknown11 = parser.ReadOffset< byte >( 73 );
        Unknown12 = parser.ReadOffset< byte >( 74 );
        Unknown13 = parser.ReadOffset< byte >( 75 );
        Unknown14 = parser.ReadOffset< byte >( 76 );
        Unknown15 = parser.ReadOffset< byte >( 77 );
        Unknown16 = parser.ReadOffset< byte >( 78 );
        Unknown17 = parser.ReadOffset< byte >( 79 );
        Unknown18 = parser.ReadOffset< byte >( 80 );
        Unknown19 = parser.ReadOffset< byte >( 81 );
        Unknown20 = parser.ReadOffset< byte >( 82 );
        Unknown21 = parser.ReadOffset< byte >( 83 );
        Unknown22 = parser.ReadOffset< byte >( 84 );
        Unknown23 = parser.ReadOffset< byte >( 85 );
        Unknown24 = parser.ReadOffset< byte >( 86 );
        Unknown25 = parser.ReadOffset< byte >( 87 );
        Unknown26 = parser.ReadOffset< byte >( 88 );
        Unknown27 = parser.ReadOffset< byte >( 89 );
        Unknown28 = parser.ReadOffset< byte >( 90 );
        Unknown29 = parser.ReadOffset< byte >( 91 );
        Unknown30 = parser.ReadOffset< byte >( 92 );
        Unknown31 = parser.ReadOffset< byte >( 93 );
        Unknown32 = parser.ReadOffset< byte >( 94 );
        Unknown33 = parser.ReadOffset< byte >( 95 );
        Unknown34 = parser.ReadOffset< byte >( 96 );
        DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 97 ), language );
        Dye2MainHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 98 ), language );
        DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 99 ), language );
        Dye2OffHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 100 ), language );
        DyeHead = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 101 ), language );
        DyeBody = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 102 ), language );
        DyeHands = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 103 ), language );
        DyeLegs = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 104 ), language );
        DyeFeet = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 105 ), language );
        DyeEars = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 106 ), language );
        DyeNeck = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 107 ), language );
        DyeWrists = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 108 ), language );
        DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 109 ), language );
        DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 110 ), language );
        Dye2Head = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 111 ), language );
        Dye2Body = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 112 ), language );
        Dye2Hands = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 113 ), language );
        Dye2Legs = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 114 ), language );
        Dye2Feet = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 115 ), language );
        Dye2Ears = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 116 ), language );
        Dye2Neck = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 117 ), language );
        Dye2Wrists = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 118 ), language );
        Dye2LeftRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 119 ), language );
        Dye2RightRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 120 ), language );
        Unknown40 = parser.ReadOffset< bool >( 121 );
        Unknown41 = parser.ReadOffset< bool >( 121, 2 );
        Unknown42 = parser.ReadOffset< bool >( 121, 4 );
        Unknown43 = parser.ReadOffset< bool >( 121, 8 );
        Unknown44 = parser.ReadOffset< bool >( 121, 16 );
        

    }
}
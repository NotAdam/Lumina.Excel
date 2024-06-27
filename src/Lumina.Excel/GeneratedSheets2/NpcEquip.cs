// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "NpcEquip", columnHash: 0x4004f596 )]
public partial class NpcEquip : ExcelRow
{
    
    public ulong ModelMainHand { get; private set; }
    public ulong ModelOffHand { get; private set; }
    public uint ModelHead { get; private set; }
    public uint ModelBody { get; private set; }
    public uint ModelHands { get; private set; }
    public uint ModelLegs { get; private set; }
    public uint ModelFeet { get; private set; }
    public uint ModelEars { get; private set; }
    public uint ModelNeck { get; private set; }
    public uint ModelWrists { get; private set; }
    public uint ModelLeftRing { get; private set; }
    public uint ModelRightRing { get; private set; }
    public ushort Unknown_70_1 { get; private set; }
    public ushort Unknown_70_2 { get; private set; }
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
    public bool Visor { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ModelMainHand = parser.ReadOffset< ulong >( 0 );
        ModelOffHand = parser.ReadOffset< ulong >( 8 );
        ModelHead = parser.ReadOffset< uint >( 16 );
        ModelBody = parser.ReadOffset< uint >( 20 );
        ModelHands = parser.ReadOffset< uint >( 24 );
        ModelLegs = parser.ReadOffset< uint >( 28 );
        ModelFeet = parser.ReadOffset< uint >( 32 );
        ModelEars = parser.ReadOffset< uint >( 36 );
        ModelNeck = parser.ReadOffset< uint >( 40 );
        ModelWrists = parser.ReadOffset< uint >( 44 );
        ModelLeftRing = parser.ReadOffset< uint >( 48 );
        ModelRightRing = parser.ReadOffset< uint >( 52 );
        Unknown_70_1 = parser.ReadOffset< ushort >( 56 );
        Unknown_70_2 = parser.ReadOffset< ushort >( 58 );
        DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 60 ), language );
        Dye2MainHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 61 ), language );
        DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 62 ), language );
        Dye2OffHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 63 ), language );
        DyeHead = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 64 ), language );
        DyeBody = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 65 ), language );
        DyeHands = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 66 ), language );
        DyeLegs = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 67 ), language );
        DyeFeet = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 68 ), language );
        DyeEars = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 69 ), language );
        DyeNeck = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 70 ), language );
        DyeWrists = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 71 ), language );
        DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 72 ), language );
        DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 73 ), language );
        Dye2Head = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 74 ), language );
        Dye2Body = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 75 ), language );
        Dye2Hands = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 76 ), language );
        Dye2Legs = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 77 ), language );
        Dye2Feet = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 78 ), language );
        Dye2Ears = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 79 ), language );
        Dye2Neck = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 80 ), language );
        Dye2Wrists = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 81 ), language );
        Dye2LeftRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 82 ), language );
        Dye2RightRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 83 ), language );
        Visor = parser.ReadOffset< bool >( 84 );
        

    }
}
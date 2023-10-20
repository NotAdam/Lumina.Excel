// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BenchmarkOverrideEquipment", columnHash: 0xd0ed99de )]
public partial class BenchmarkOverrideEquipment : ExcelRow
{
    
    public ulong ModelMainHand { get; private set; }
    public ulong ModelOffHand { get; private set; }
    public ulong Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
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
    public byte Unknown3 { get; private set; }
    public LazyRow< Stain > DyeMainHand { get; private set; }
    public LazyRow< Stain > DyeOffHand { get; private set; }
    public byte Unknown4 { get; private set; }
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
    public sbyte Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ModelMainHand = parser.ReadOffset< ulong >( 0 );
        ModelOffHand = parser.ReadOffset< ulong >( 8 );
        Unknown0 = parser.ReadOffset< ulong >( 16 );
        Unknown1 = parser.ReadOffset< uint >( 24 );
        Unknown2 = parser.ReadOffset< uint >( 28 );
        ModelHead = parser.ReadOffset< uint >( 32 );
        ModelBody = parser.ReadOffset< uint >( 36 );
        ModelHands = parser.ReadOffset< uint >( 40 );
        ModelLegs = parser.ReadOffset< uint >( 44 );
        ModelFeet = parser.ReadOffset< uint >( 48 );
        ModelEars = parser.ReadOffset< uint >( 52 );
        ModelNeck = parser.ReadOffset< uint >( 56 );
        ModelWrists = parser.ReadOffset< uint >( 60 );
        ModelLeftRing = parser.ReadOffset< uint >( 64 );
        ModelRightRing = parser.ReadOffset< uint >( 68 );
        Unknown3 = parser.ReadOffset< byte >( 72 );
        DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 73 ), language );
        DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 74 ), language );
        Unknown4 = parser.ReadOffset< byte >( 75 );
        DyeHead = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 76 ), language );
        DyeBody = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 77 ), language );
        DyeHands = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 78 ), language );
        DyeLegs = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 79 ), language );
        DyeFeet = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 80 ), language );
        DyeEars = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 81 ), language );
        DyeNeck = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 82 ), language );
        DyeWrists = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 83 ), language );
        DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 84 ), language );
        DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 85 ), language );
        Unknown5 = parser.ReadOffset< sbyte >( 86 );
        

    }
}
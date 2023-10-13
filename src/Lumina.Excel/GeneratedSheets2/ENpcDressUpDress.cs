// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ENpcDressUpDress", columnHash: 0xd0267043 )]
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
    public uint Unknown51 { get; private set; }
    public uint Unknown53 { get; private set; }
    public uint Unknown55 { get; private set; }
    public uint Unknown57 { get; private set; }
    public uint Unknown59 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public LazyRow< Behavior > Behavior { get; private set; }
    public ushort Unknown10 { get; private set; }
    public byte Unknown6 { get; private set; }
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
    public byte Unknown35 { get; private set; }
    public byte Unknown36 { get; private set; }
    public LazyRow< Stain > DyeMainHand { get; private set; }
    public LazyRow< Stain > DyeOffHand { get; private set; }
    public LazyRow< Stain > DyeHead { get; private set; }
    public LazyRow< Stain > DyeBody { get; private set; }
    public LazyRow< Stain > DyeHands { get; private set; }
    public LazyRow< Stain > DyeLegs { get; private set; }
    public LazyRow< Stain > DyeFeet { get; private set; }
    public byte Unknown52 { get; private set; }
    public byte Unknown54 { get; private set; }
    public byte Unknown56 { get; private set; }
    public byte Unknown58 { get; private set; }
    public byte Unknown60 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    
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
        Unknown51 = parser.ReadOffset< uint >( 44 );
        Unknown53 = parser.ReadOffset< uint >( 48 );
        Unknown55 = parser.ReadOffset< uint >( 52 );
        Unknown57 = parser.ReadOffset< uint >( 56 );
        Unknown59 = parser.ReadOffset< uint >( 60 );
        Unknown8 = parser.ReadOffset< ushort >( 64 );
        Behavior = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 66 ), language );
        Unknown10 = parser.ReadOffset< ushort >( 68 );
        Unknown6 = parser.ReadOffset< byte >( 70 );
        Unknown11 = parser.ReadOffset< byte >( 71 );
        Unknown12 = parser.ReadOffset< byte >( 72 );
        Unknown13 = parser.ReadOffset< byte >( 73 );
        Unknown14 = parser.ReadOffset< byte >( 74 );
        Unknown15 = parser.ReadOffset< byte >( 75 );
        Unknown16 = parser.ReadOffset< byte >( 76 );
        Unknown17 = parser.ReadOffset< byte >( 77 );
        Unknown18 = parser.ReadOffset< byte >( 78 );
        Unknown19 = parser.ReadOffset< byte >( 79 );
        Unknown20 = parser.ReadOffset< byte >( 80 );
        Unknown21 = parser.ReadOffset< byte >( 81 );
        Unknown22 = parser.ReadOffset< byte >( 82 );
        Unknown23 = parser.ReadOffset< byte >( 83 );
        Unknown24 = parser.ReadOffset< byte >( 84 );
        Unknown25 = parser.ReadOffset< byte >( 85 );
        Unknown26 = parser.ReadOffset< byte >( 86 );
        Unknown27 = parser.ReadOffset< byte >( 87 );
        Unknown28 = parser.ReadOffset< byte >( 88 );
        Unknown29 = parser.ReadOffset< byte >( 89 );
        Unknown30 = parser.ReadOffset< byte >( 90 );
        Unknown31 = parser.ReadOffset< byte >( 91 );
        Unknown32 = parser.ReadOffset< byte >( 92 );
        Unknown33 = parser.ReadOffset< byte >( 93 );
        Unknown34 = parser.ReadOffset< byte >( 94 );
        Unknown35 = parser.ReadOffset< byte >( 95 );
        Unknown36 = parser.ReadOffset< byte >( 96 );
        DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 97 ), language );
        DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 98 ), language );
        DyeHead = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 99 ), language );
        DyeBody = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 100 ), language );
        DyeHands = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 101 ), language );
        DyeLegs = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 102 ), language );
        DyeFeet = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 103 ), language );
        Unknown52 = parser.ReadOffset< byte >( 104 );
        Unknown54 = parser.ReadOffset< byte >( 105 );
        Unknown56 = parser.ReadOffset< byte >( 106 );
        Unknown58 = parser.ReadOffset< byte >( 107 );
        Unknown60 = parser.ReadOffset< byte >( 108 );
        Unknown1 = parser.ReadOffset< bool >( 109 );
        Unknown2 = parser.ReadOffset< bool >( 109, 2 );
        Unknown3 = parser.ReadOffset< bool >( 109, 4 );
        Unknown4 = parser.ReadOffset< bool >( 109, 8 );
        Unknown5 = parser.ReadOffset< bool >( 109, 16 );
        

    }
}
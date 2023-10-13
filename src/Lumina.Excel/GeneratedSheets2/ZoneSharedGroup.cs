// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ZoneSharedGroup", columnHash: 0xfa71ca60 )]
public partial class ZoneSharedGroup : ExcelRow
{
    
    public uint LGBSharedGroup { get; private set; }
    public LazyRow< Quest > Quest0 { get; private set; }
    public LazyRow< Quest > Quest1 { get; private set; }
    public LazyRow< Quest > Quest2 { get; private set; }
    public LazyRow< Quest > Quest3 { get; private set; }
    public LazyRow< Quest > Quest4 { get; private set; }
    public LazyRow< Quest > Quest5 { get; private set; }
    public uint Unknown26 { get; private set; }
    public uint Seq0 { get; private set; }
    public uint Seq1 { get; private set; }
    public uint Seq2 { get; private set; }
    public uint Seq3 { get; private set; }
    public uint Seq4 { get; private set; }
    public uint Seq5 { get; private set; }
    public uint Unknown27 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown21 { get; private set; }
    public byte Unknown25 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool Unknown24 { get; private set; }
    public bool Unknown28 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LGBSharedGroup = parser.ReadOffset< uint >( 0 );
        Quest0 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Quest1 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Quest2 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 12 ), language );
        Quest3 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 16 ), language );
        Quest4 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 20 ), language );
        Quest5 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 24 ), language );
        Unknown26 = parser.ReadOffset< uint >( 28 );
        Seq0 = parser.ReadOffset< uint >( 32 );
        Seq1 = parser.ReadOffset< uint >( 36 );
        Seq2 = parser.ReadOffset< uint >( 40 );
        Seq3 = parser.ReadOffset< uint >( 44 );
        Seq4 = parser.ReadOffset< uint >( 48 );
        Seq5 = parser.ReadOffset< uint >( 52 );
        Unknown27 = parser.ReadOffset< uint >( 56 );
        Unknown1 = parser.ReadOffset< byte >( 60 );
        Unknown5 = parser.ReadOffset< byte >( 61 );
        Unknown9 = parser.ReadOffset< byte >( 62 );
        Unknown13 = parser.ReadOffset< byte >( 63 );
        Unknown17 = parser.ReadOffset< byte >( 64 );
        Unknown21 = parser.ReadOffset< byte >( 65 );
        Unknown25 = parser.ReadOffset< byte >( 66 );
        Unknown4 = parser.ReadOffset< bool >( 67 );
        Unknown8 = parser.ReadOffset< bool >( 68 );
        Unknown12 = parser.ReadOffset< bool >( 69 );
        Unknown16 = parser.ReadOffset< bool >( 70 );
        Unknown20 = parser.ReadOffset< bool >( 71 );
        Unknown24 = parser.ReadOffset< bool >( 72 );
        Unknown28 = parser.ReadOffset< bool >( 73 );
        

    }
}
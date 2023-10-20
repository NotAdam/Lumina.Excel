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
    public uint Unknown0 { get; private set; }
    public uint Seq0 { get; private set; }
    public uint Seq1 { get; private set; }
    public uint Seq2 { get; private set; }
    public uint Seq3 { get; private set; }
    public uint Seq4 { get; private set; }
    public uint Seq5 { get; private set; }
    public uint Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    
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
        Unknown0 = parser.ReadOffset< uint >( 28 );
        Seq0 = parser.ReadOffset< uint >( 32 );
        Seq1 = parser.ReadOffset< uint >( 36 );
        Seq2 = parser.ReadOffset< uint >( 40 );
        Seq3 = parser.ReadOffset< uint >( 44 );
        Seq4 = parser.ReadOffset< uint >( 48 );
        Seq5 = parser.ReadOffset< uint >( 52 );
        Unknown1 = parser.ReadOffset< uint >( 56 );
        Unknown2 = parser.ReadOffset< byte >( 60 );
        Unknown3 = parser.ReadOffset< byte >( 61 );
        Unknown4 = parser.ReadOffset< byte >( 62 );
        Unknown5 = parser.ReadOffset< byte >( 63 );
        Unknown6 = parser.ReadOffset< byte >( 64 );
        Unknown7 = parser.ReadOffset< byte >( 65 );
        Unknown8 = parser.ReadOffset< byte >( 66 );
        Unknown9 = parser.ReadOffset< bool >( 67 );
        Unknown10 = parser.ReadOffset< bool >( 68 );
        Unknown11 = parser.ReadOffset< bool >( 69 );
        Unknown12 = parser.ReadOffset< bool >( 70 );
        Unknown13 = parser.ReadOffset< bool >( 71 );
        Unknown14 = parser.ReadOffset< bool >( 72 );
        Unknown15 = parser.ReadOffset< bool >( 73 );
        

    }
}
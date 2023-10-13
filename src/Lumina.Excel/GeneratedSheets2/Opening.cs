// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Opening", columnHash: 0xfe684a57 )]
public partial class Opening : ExcelRow
{
    
    public SeString Unknown2 { get; private set; }
    public uint Unknown42 { get; private set; }
    public SeString Unknown3 { get; private set; }
    public uint Unknown43 { get; private set; }
    public SeString Unknown4 { get; private set; }
    public uint Unknown44 { get; private set; }
    public SeString Unknown5 { get; private set; }
    public uint Unknown45 { get; private set; }
    public SeString Unknown6 { get; private set; }
    public uint Unknown46 { get; private set; }
    public SeString Unknown7 { get; private set; }
    public uint Unknown47 { get; private set; }
    public SeString Unknown8 { get; private set; }
    public uint Unknown48 { get; private set; }
    public SeString Unknown9 { get; private set; }
    public uint Unknown49 { get; private set; }
    public SeString Unknown10 { get; private set; }
    public uint Unknown50 { get; private set; }
    public SeString Unknown11 { get; private set; }
    public uint Unknown51 { get; private set; }
    public SeString Unknown12 { get; private set; }
    public uint Unknown52 { get; private set; }
    public SeString Unknown13 { get; private set; }
    public uint Unknown53 { get; private set; }
    public SeString Unknown14 { get; private set; }
    public uint Unknown54 { get; private set; }
    public SeString Unknown15 { get; private set; }
    public uint Unknown55 { get; private set; }
    public SeString Unknown16 { get; private set; }
    public uint Unknown56 { get; private set; }
    public SeString Unknown17 { get; private set; }
    public uint Unknown57 { get; private set; }
    public SeString Unknown18 { get; private set; }
    public uint Unknown58 { get; private set; }
    public SeString Unknown19 { get; private set; }
    public uint Unknown59 { get; private set; }
    public SeString Unknown20 { get; private set; }
    public uint Unknown60 { get; private set; }
    public SeString Unknown21 { get; private set; }
    public uint Unknown61 { get; private set; }
    public SeString Unknown22 { get; private set; }
    public uint Unknown62 { get; private set; }
    public SeString Unknown23 { get; private set; }
    public uint Unknown63 { get; private set; }
    public SeString Unknown24 { get; private set; }
    public uint Unknown64 { get; private set; }
    public SeString Unknown25 { get; private set; }
    public uint Unknown65 { get; private set; }
    public SeString Unknown26 { get; private set; }
    public uint Unknown66 { get; private set; }
    public SeString Unknown27 { get; private set; }
    public uint Unknown67 { get; private set; }
    public SeString Unknown28 { get; private set; }
    public uint Unknown68 { get; private set; }
    public SeString Unknown29 { get; private set; }
    public uint Unknown69 { get; private set; }
    public SeString Unknown30 { get; private set; }
    public uint Unknown70 { get; private set; }
    public SeString Unknown31 { get; private set; }
    public uint Unknown71 { get; private set; }
    public SeString Unknown32 { get; private set; }
    public uint Unknown72 { get; private set; }
    public SeString Unknown33 { get; private set; }
    public uint Unknown73 { get; private set; }
    public SeString Unknown34 { get; private set; }
    public uint Unknown74 { get; private set; }
    public SeString Unknown35 { get; private set; }
    public uint Unknown75 { get; private set; }
    public SeString Unknown36 { get; private set; }
    public uint Unknown76 { get; private set; }
    public SeString Unknown37 { get; private set; }
    public uint Unknown77 { get; private set; }
    public SeString Unknown38 { get; private set; }
    public uint Unknown78 { get; private set; }
    public SeString Unknown39 { get; private set; }
    public uint Unknown79 { get; private set; }
    public SeString Unknown40 { get; private set; }
    public uint Unknown80 { get; private set; }
    public SeString Unknown41 { get; private set; }
    public uint Unknown81 { get; private set; }
    public SeString Name { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown2 = parser.ReadOffset< SeString >( 0 );
        Unknown42 = parser.ReadOffset< uint >( 4 );
        Unknown3 = parser.ReadOffset< SeString >( 8 );
        Unknown43 = parser.ReadOffset< uint >( 12 );
        Unknown4 = parser.ReadOffset< SeString >( 16 );
        Unknown44 = parser.ReadOffset< uint >( 20 );
        Unknown5 = parser.ReadOffset< SeString >( 24 );
        Unknown45 = parser.ReadOffset< uint >( 28 );
        Unknown6 = parser.ReadOffset< SeString >( 32 );
        Unknown46 = parser.ReadOffset< uint >( 36 );
        Unknown7 = parser.ReadOffset< SeString >( 40 );
        Unknown47 = parser.ReadOffset< uint >( 44 );
        Unknown8 = parser.ReadOffset< SeString >( 48 );
        Unknown48 = parser.ReadOffset< uint >( 52 );
        Unknown9 = parser.ReadOffset< SeString >( 56 );
        Unknown49 = parser.ReadOffset< uint >( 60 );
        Unknown10 = parser.ReadOffset< SeString >( 64 );
        Unknown50 = parser.ReadOffset< uint >( 68 );
        Unknown11 = parser.ReadOffset< SeString >( 72 );
        Unknown51 = parser.ReadOffset< uint >( 76 );
        Unknown12 = parser.ReadOffset< SeString >( 80 );
        Unknown52 = parser.ReadOffset< uint >( 84 );
        Unknown13 = parser.ReadOffset< SeString >( 88 );
        Unknown53 = parser.ReadOffset< uint >( 92 );
        Unknown14 = parser.ReadOffset< SeString >( 96 );
        Unknown54 = parser.ReadOffset< uint >( 100 );
        Unknown15 = parser.ReadOffset< SeString >( 104 );
        Unknown55 = parser.ReadOffset< uint >( 108 );
        Unknown16 = parser.ReadOffset< SeString >( 112 );
        Unknown56 = parser.ReadOffset< uint >( 116 );
        Unknown17 = parser.ReadOffset< SeString >( 120 );
        Unknown57 = parser.ReadOffset< uint >( 124 );
        Unknown18 = parser.ReadOffset< SeString >( 128 );
        Unknown58 = parser.ReadOffset< uint >( 132 );
        Unknown19 = parser.ReadOffset< SeString >( 136 );
        Unknown59 = parser.ReadOffset< uint >( 140 );
        Unknown20 = parser.ReadOffset< SeString >( 144 );
        Unknown60 = parser.ReadOffset< uint >( 148 );
        Unknown21 = parser.ReadOffset< SeString >( 152 );
        Unknown61 = parser.ReadOffset< uint >( 156 );
        Unknown22 = parser.ReadOffset< SeString >( 160 );
        Unknown62 = parser.ReadOffset< uint >( 164 );
        Unknown23 = parser.ReadOffset< SeString >( 168 );
        Unknown63 = parser.ReadOffset< uint >( 172 );
        Unknown24 = parser.ReadOffset< SeString >( 176 );
        Unknown64 = parser.ReadOffset< uint >( 180 );
        Unknown25 = parser.ReadOffset< SeString >( 184 );
        Unknown65 = parser.ReadOffset< uint >( 188 );
        Unknown26 = parser.ReadOffset< SeString >( 192 );
        Unknown66 = parser.ReadOffset< uint >( 196 );
        Unknown27 = parser.ReadOffset< SeString >( 200 );
        Unknown67 = parser.ReadOffset< uint >( 204 );
        Unknown28 = parser.ReadOffset< SeString >( 208 );
        Unknown68 = parser.ReadOffset< uint >( 212 );
        Unknown29 = parser.ReadOffset< SeString >( 216 );
        Unknown69 = parser.ReadOffset< uint >( 220 );
        Unknown30 = parser.ReadOffset< SeString >( 224 );
        Unknown70 = parser.ReadOffset< uint >( 228 );
        Unknown31 = parser.ReadOffset< SeString >( 232 );
        Unknown71 = parser.ReadOffset< uint >( 236 );
        Unknown32 = parser.ReadOffset< SeString >( 240 );
        Unknown72 = parser.ReadOffset< uint >( 244 );
        Unknown33 = parser.ReadOffset< SeString >( 248 );
        Unknown73 = parser.ReadOffset< uint >( 252 );
        Unknown34 = parser.ReadOffset< SeString >( 256 );
        Unknown74 = parser.ReadOffset< uint >( 260 );
        Unknown35 = parser.ReadOffset< SeString >( 264 );
        Unknown75 = parser.ReadOffset< uint >( 268 );
        Unknown36 = parser.ReadOffset< SeString >( 272 );
        Unknown76 = parser.ReadOffset< uint >( 276 );
        Unknown37 = parser.ReadOffset< SeString >( 280 );
        Unknown77 = parser.ReadOffset< uint >( 284 );
        Unknown38 = parser.ReadOffset< SeString >( 288 );
        Unknown78 = parser.ReadOffset< uint >( 292 );
        Unknown39 = parser.ReadOffset< SeString >( 296 );
        Unknown79 = parser.ReadOffset< uint >( 300 );
        Unknown40 = parser.ReadOffset< SeString >( 304 );
        Unknown80 = parser.ReadOffset< uint >( 308 );
        Unknown41 = parser.ReadOffset< SeString >( 312 );
        Unknown81 = parser.ReadOffset< uint >( 316 );
        Name = parser.ReadOffset< SeString >( 320 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 324 ), language );
        

    }
}
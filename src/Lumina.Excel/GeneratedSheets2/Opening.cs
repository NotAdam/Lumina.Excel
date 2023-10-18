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
    
    public SeString Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public SeString Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public SeString Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public SeString Unknown6 { get; private set; }
    public uint Unknown7 { get; private set; }
    public SeString Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    public SeString Unknown10 { get; private set; }
    public uint Unknown11 { get; private set; }
    public SeString Unknown12 { get; private set; }
    public uint Unknown13 { get; private set; }
    public SeString Unknown14 { get; private set; }
    public uint Unknown15 { get; private set; }
    public SeString Unknown16 { get; private set; }
    public uint Unknown17 { get; private set; }
    public SeString Unknown18 { get; private set; }
    public uint Unknown19 { get; private set; }
    public SeString Unknown20 { get; private set; }
    public uint Unknown21 { get; private set; }
    public SeString Unknown22 { get; private set; }
    public uint Unknown23 { get; private set; }
    public SeString Unknown24 { get; private set; }
    public uint Unknown25 { get; private set; }
    public SeString Unknown26 { get; private set; }
    public uint Unknown27 { get; private set; }
    public SeString Unknown28 { get; private set; }
    public uint Unknown29 { get; private set; }
    public SeString Unknown30 { get; private set; }
    public uint Unknown31 { get; private set; }
    public SeString Unknown32 { get; private set; }
    public uint Unknown33 { get; private set; }
    public SeString Unknown34 { get; private set; }
    public uint Unknown35 { get; private set; }
    public SeString Unknown36 { get; private set; }
    public uint Unknown37 { get; private set; }
    public SeString Unknown38 { get; private set; }
    public uint Unknown39 { get; private set; }
    public SeString Unknown40 { get; private set; }
    public uint Unknown41 { get; private set; }
    public SeString Unknown42 { get; private set; }
    public uint Unknown43 { get; private set; }
    public SeString Unknown44 { get; private set; }
    public uint Unknown45 { get; private set; }
    public SeString Unknown46 { get; private set; }
    public uint Unknown47 { get; private set; }
    public SeString Unknown48 { get; private set; }
    public uint Unknown49 { get; private set; }
    public SeString Unknown50 { get; private set; }
    public uint Unknown51 { get; private set; }
    public SeString Unknown52 { get; private set; }
    public uint Unknown53 { get; private set; }
    public SeString Unknown54 { get; private set; }
    public uint Unknown55 { get; private set; }
    public SeString Unknown56 { get; private set; }
    public uint Unknown57 { get; private set; }
    public SeString Unknown58 { get; private set; }
    public uint Unknown59 { get; private set; }
    public SeString Unknown60 { get; private set; }
    public uint Unknown61 { get; private set; }
    public SeString Unknown62 { get; private set; }
    public uint Unknown63 { get; private set; }
    public SeString Unknown64 { get; private set; }
    public uint Unknown65 { get; private set; }
    public SeString Unknown66 { get; private set; }
    public uint Unknown67 { get; private set; }
    public SeString Unknown68 { get; private set; }
    public uint Unknown69 { get; private set; }
    public SeString Unknown70 { get; private set; }
    public uint Unknown71 { get; private set; }
    public SeString Unknown72 { get; private set; }
    public uint Unknown73 { get; private set; }
    public SeString Unknown74 { get; private set; }
    public uint Unknown75 { get; private set; }
    public SeString Unknown76 { get; private set; }
    public uint Unknown77 { get; private set; }
    public SeString Unknown78 { get; private set; }
    public uint Unknown79 { get; private set; }
    public SeString Name { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< SeString >( 8 );
        Unknown3 = parser.ReadOffset< uint >( 12 );
        Unknown4 = parser.ReadOffset< SeString >( 16 );
        Unknown5 = parser.ReadOffset< uint >( 20 );
        Unknown6 = parser.ReadOffset< SeString >( 24 );
        Unknown7 = parser.ReadOffset< uint >( 28 );
        Unknown8 = parser.ReadOffset< SeString >( 32 );
        Unknown9 = parser.ReadOffset< uint >( 36 );
        Unknown10 = parser.ReadOffset< SeString >( 40 );
        Unknown11 = parser.ReadOffset< uint >( 44 );
        Unknown12 = parser.ReadOffset< SeString >( 48 );
        Unknown13 = parser.ReadOffset< uint >( 52 );
        Unknown14 = parser.ReadOffset< SeString >( 56 );
        Unknown15 = parser.ReadOffset< uint >( 60 );
        Unknown16 = parser.ReadOffset< SeString >( 64 );
        Unknown17 = parser.ReadOffset< uint >( 68 );
        Unknown18 = parser.ReadOffset< SeString >( 72 );
        Unknown19 = parser.ReadOffset< uint >( 76 );
        Unknown20 = parser.ReadOffset< SeString >( 80 );
        Unknown21 = parser.ReadOffset< uint >( 84 );
        Unknown22 = parser.ReadOffset< SeString >( 88 );
        Unknown23 = parser.ReadOffset< uint >( 92 );
        Unknown24 = parser.ReadOffset< SeString >( 96 );
        Unknown25 = parser.ReadOffset< uint >( 100 );
        Unknown26 = parser.ReadOffset< SeString >( 104 );
        Unknown27 = parser.ReadOffset< uint >( 108 );
        Unknown28 = parser.ReadOffset< SeString >( 112 );
        Unknown29 = parser.ReadOffset< uint >( 116 );
        Unknown30 = parser.ReadOffset< SeString >( 120 );
        Unknown31 = parser.ReadOffset< uint >( 124 );
        Unknown32 = parser.ReadOffset< SeString >( 128 );
        Unknown33 = parser.ReadOffset< uint >( 132 );
        Unknown34 = parser.ReadOffset< SeString >( 136 );
        Unknown35 = parser.ReadOffset< uint >( 140 );
        Unknown36 = parser.ReadOffset< SeString >( 144 );
        Unknown37 = parser.ReadOffset< uint >( 148 );
        Unknown38 = parser.ReadOffset< SeString >( 152 );
        Unknown39 = parser.ReadOffset< uint >( 156 );
        Unknown40 = parser.ReadOffset< SeString >( 160 );
        Unknown41 = parser.ReadOffset< uint >( 164 );
        Unknown42 = parser.ReadOffset< SeString >( 168 );
        Unknown43 = parser.ReadOffset< uint >( 172 );
        Unknown44 = parser.ReadOffset< SeString >( 176 );
        Unknown45 = parser.ReadOffset< uint >( 180 );
        Unknown46 = parser.ReadOffset< SeString >( 184 );
        Unknown47 = parser.ReadOffset< uint >( 188 );
        Unknown48 = parser.ReadOffset< SeString >( 192 );
        Unknown49 = parser.ReadOffset< uint >( 196 );
        Unknown50 = parser.ReadOffset< SeString >( 200 );
        Unknown51 = parser.ReadOffset< uint >( 204 );
        Unknown52 = parser.ReadOffset< SeString >( 208 );
        Unknown53 = parser.ReadOffset< uint >( 212 );
        Unknown54 = parser.ReadOffset< SeString >( 216 );
        Unknown55 = parser.ReadOffset< uint >( 220 );
        Unknown56 = parser.ReadOffset< SeString >( 224 );
        Unknown57 = parser.ReadOffset< uint >( 228 );
        Unknown58 = parser.ReadOffset< SeString >( 232 );
        Unknown59 = parser.ReadOffset< uint >( 236 );
        Unknown60 = parser.ReadOffset< SeString >( 240 );
        Unknown61 = parser.ReadOffset< uint >( 244 );
        Unknown62 = parser.ReadOffset< SeString >( 248 );
        Unknown63 = parser.ReadOffset< uint >( 252 );
        Unknown64 = parser.ReadOffset< SeString >( 256 );
        Unknown65 = parser.ReadOffset< uint >( 260 );
        Unknown66 = parser.ReadOffset< SeString >( 264 );
        Unknown67 = parser.ReadOffset< uint >( 268 );
        Unknown68 = parser.ReadOffset< SeString >( 272 );
        Unknown69 = parser.ReadOffset< uint >( 276 );
        Unknown70 = parser.ReadOffset< SeString >( 280 );
        Unknown71 = parser.ReadOffset< uint >( 284 );
        Unknown72 = parser.ReadOffset< SeString >( 288 );
        Unknown73 = parser.ReadOffset< uint >( 292 );
        Unknown74 = parser.ReadOffset< SeString >( 296 );
        Unknown75 = parser.ReadOffset< uint >( 300 );
        Unknown76 = parser.ReadOffset< SeString >( 304 );
        Unknown77 = parser.ReadOffset< uint >( 308 );
        Unknown78 = parser.ReadOffset< SeString >( 312 );
        Unknown79 = parser.ReadOffset< uint >( 316 );
        Name = parser.ReadOffset< SeString >( 320 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 324 ), language );
        

    }
}
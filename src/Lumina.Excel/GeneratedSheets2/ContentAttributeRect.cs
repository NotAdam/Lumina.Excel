// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentAttributeRect", columnHash: 0x01299c43 )]
public partial class ContentAttributeRect : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public uint Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public uint Unknown12 { get; private set; }
    public uint Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public uint Unknown16 { get; private set; }
    public uint Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public uint Unknown20 { get; private set; }
    public uint Unknown21 { get; private set; }
    public byte Unknown22 { get; private set; }
    public byte Unknown23 { get; private set; }
    public uint Unknown24 { get; private set; }
    public uint Unknown25 { get; private set; }
    public byte Unknown26 { get; private set; }
    public byte Unknown27 { get; private set; }
    public uint Unknown28 { get; private set; }
    public uint Unknown29 { get; private set; }
    public byte Unknown30 { get; private set; }
    public byte Unknown31 { get; private set; }
    public uint Unknown32 { get; private set; }
    public uint Unknown33 { get; private set; }
    public byte Unknown34 { get; private set; }
    public byte Unknown35 { get; private set; }
    public uint Unknown36 { get; private set; }
    public uint Unknown37 { get; private set; }
    public byte Unknown38 { get; private set; }
    public byte Unknown39 { get; private set; }
    public uint Unknown40 { get; private set; }
    public uint Unknown41 { get; private set; }
    public byte Unknown42 { get; private set; }
    public byte Unknown43 { get; private set; }
    public uint Unknown44 { get; private set; }
    public uint Unknown45 { get; private set; }
    public byte Unknown46 { get; private set; }
    public byte Unknown47 { get; private set; }
    public uint Unknown48 { get; private set; }
    public uint Unknown49 { get; private set; }
    public byte Unknown50 { get; private set; }
    public byte Unknown51 { get; private set; }
    public uint Unknown52 { get; private set; }
    public uint Unknown53 { get; private set; }
    public byte Unknown54 { get; private set; }
    public byte Unknown55 { get; private set; }
    public uint Unknown56 { get; private set; }
    public uint Unknown57 { get; private set; }
    public byte Unknown58 { get; private set; }
    public byte Unknown59 { get; private set; }
    public uint Unknown60 { get; private set; }
    public uint Unknown61 { get; private set; }
    public byte Unknown62 { get; private set; }
    public byte Unknown63 { get; private set; }
    public uint Unknown64 { get; private set; }
    public uint Unknown65 { get; private set; }
    public byte Unknown66 { get; private set; }
    public byte Unknown67 { get; private set; }
    public uint Unknown68 { get; private set; }
    public uint Unknown69 { get; private set; }
    public byte Unknown70 { get; private set; }
    public byte Unknown71 { get; private set; }
    public uint Unknown72 { get; private set; }
    public uint Unknown73 { get; private set; }
    public byte Unknown74 { get; private set; }
    public byte Unknown75 { get; private set; }
    public uint Unknown76 { get; private set; }
    public uint Unknown77 { get; private set; }
    public byte Unknown78 { get; private set; }
    public byte Unknown79 { get; private set; }
    public uint Unknown80 { get; private set; }
    public uint Unknown81 { get; private set; }
    public byte Unknown82 { get; private set; }
    public byte Unknown83 { get; private set; }
    public uint Unknown84 { get; private set; }
    public uint Unknown85 { get; private set; }
    public byte Unknown86 { get; private set; }
    public byte Unknown87 { get; private set; }
    public uint Unknown88 { get; private set; }
    public uint Unknown89 { get; private set; }
    public byte Unknown90 { get; private set; }
    public byte Unknown91 { get; private set; }
    public uint Unknown92 { get; private set; }
    public uint Unknown93 { get; private set; }
    public byte Unknown94 { get; private set; }
    public byte Unknown95 { get; private set; }
    public uint Unknown96 { get; private set; }
    public uint Unknown97 { get; private set; }
    public byte Unknown98 { get; private set; }
    public byte Unknown99 { get; private set; }
    public uint Unknown100 { get; private set; }
    public uint Unknown101 { get; private set; }
    public byte Unknown102 { get; private set; }
    public byte Unknown103 { get; private set; }
    public uint Unknown104 { get; private set; }
    public uint Unknown105 { get; private set; }
    public byte Unknown106 { get; private set; }
    public byte Unknown107 { get; private set; }
    public uint Unknown108 { get; private set; }
    public uint Unknown109 { get; private set; }
    public byte Unknown110 { get; private set; }
    public byte Unknown111 { get; private set; }
    public uint Unknown112 { get; private set; }
    public uint Unknown113 { get; private set; }
    public byte Unknown114 { get; private set; }
    public byte Unknown115 { get; private set; }
    public uint Unknown116 { get; private set; }
    public uint Unknown117 { get; private set; }
    public byte Unknown118 { get; private set; }
    public byte Unknown119 { get; private set; }
    public uint Unknown120 { get; private set; }
    public uint Unknown121 { get; private set; }
    public byte Unknown122 { get; private set; }
    public byte Unknown123 { get; private set; }
    public uint Unknown124 { get; private set; }
    public uint Unknown125 { get; private set; }
    public byte Unknown126 { get; private set; }
    public byte Unknown127 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< byte >( 8 );
        Unknown3 = parser.ReadOffset< byte >( 9 );
        Unknown4 = parser.ReadOffset< uint >( 12 );
        Unknown5 = parser.ReadOffset< uint >( 16 );
        Unknown6 = parser.ReadOffset< byte >( 20 );
        Unknown7 = parser.ReadOffset< byte >( 21 );
        Unknown8 = parser.ReadOffset< uint >( 24 );
        Unknown9 = parser.ReadOffset< uint >( 28 );
        Unknown10 = parser.ReadOffset< byte >( 32 );
        Unknown11 = parser.ReadOffset< byte >( 33 );
        Unknown12 = parser.ReadOffset< uint >( 36 );
        Unknown13 = parser.ReadOffset< uint >( 40 );
        Unknown14 = parser.ReadOffset< byte >( 44 );
        Unknown15 = parser.ReadOffset< byte >( 45 );
        Unknown16 = parser.ReadOffset< uint >( 48 );
        Unknown17 = parser.ReadOffset< uint >( 52 );
        Unknown18 = parser.ReadOffset< byte >( 56 );
        Unknown19 = parser.ReadOffset< byte >( 57 );
        Unknown20 = parser.ReadOffset< uint >( 60 );
        Unknown21 = parser.ReadOffset< uint >( 64 );
        Unknown22 = parser.ReadOffset< byte >( 68 );
        Unknown23 = parser.ReadOffset< byte >( 69 );
        Unknown24 = parser.ReadOffset< uint >( 72 );
        Unknown25 = parser.ReadOffset< uint >( 76 );
        Unknown26 = parser.ReadOffset< byte >( 80 );
        Unknown27 = parser.ReadOffset< byte >( 81 );
        Unknown28 = parser.ReadOffset< uint >( 84 );
        Unknown29 = parser.ReadOffset< uint >( 88 );
        Unknown30 = parser.ReadOffset< byte >( 92 );
        Unknown31 = parser.ReadOffset< byte >( 93 );
        Unknown32 = parser.ReadOffset< uint >( 96 );
        Unknown33 = parser.ReadOffset< uint >( 100 );
        Unknown34 = parser.ReadOffset< byte >( 104 );
        Unknown35 = parser.ReadOffset< byte >( 105 );
        Unknown36 = parser.ReadOffset< uint >( 108 );
        Unknown37 = parser.ReadOffset< uint >( 112 );
        Unknown38 = parser.ReadOffset< byte >( 116 );
        Unknown39 = parser.ReadOffset< byte >( 117 );
        Unknown40 = parser.ReadOffset< uint >( 120 );
        Unknown41 = parser.ReadOffset< uint >( 124 );
        Unknown42 = parser.ReadOffset< byte >( 128 );
        Unknown43 = parser.ReadOffset< byte >( 129 );
        Unknown44 = parser.ReadOffset< uint >( 132 );
        Unknown45 = parser.ReadOffset< uint >( 136 );
        Unknown46 = parser.ReadOffset< byte >( 140 );
        Unknown47 = parser.ReadOffset< byte >( 141 );
        Unknown48 = parser.ReadOffset< uint >( 144 );
        Unknown49 = parser.ReadOffset< uint >( 148 );
        Unknown50 = parser.ReadOffset< byte >( 152 );
        Unknown51 = parser.ReadOffset< byte >( 153 );
        Unknown52 = parser.ReadOffset< uint >( 156 );
        Unknown53 = parser.ReadOffset< uint >( 160 );
        Unknown54 = parser.ReadOffset< byte >( 164 );
        Unknown55 = parser.ReadOffset< byte >( 165 );
        Unknown56 = parser.ReadOffset< uint >( 168 );
        Unknown57 = parser.ReadOffset< uint >( 172 );
        Unknown58 = parser.ReadOffset< byte >( 176 );
        Unknown59 = parser.ReadOffset< byte >( 177 );
        Unknown60 = parser.ReadOffset< uint >( 180 );
        Unknown61 = parser.ReadOffset< uint >( 184 );
        Unknown62 = parser.ReadOffset< byte >( 188 );
        Unknown63 = parser.ReadOffset< byte >( 189 );
        Unknown64 = parser.ReadOffset< uint >( 192 );
        Unknown65 = parser.ReadOffset< uint >( 196 );
        Unknown66 = parser.ReadOffset< byte >( 200 );
        Unknown67 = parser.ReadOffset< byte >( 201 );
        Unknown68 = parser.ReadOffset< uint >( 204 );
        Unknown69 = parser.ReadOffset< uint >( 208 );
        Unknown70 = parser.ReadOffset< byte >( 212 );
        Unknown71 = parser.ReadOffset< byte >( 213 );
        Unknown72 = parser.ReadOffset< uint >( 216 );
        Unknown73 = parser.ReadOffset< uint >( 220 );
        Unknown74 = parser.ReadOffset< byte >( 224 );
        Unknown75 = parser.ReadOffset< byte >( 225 );
        Unknown76 = parser.ReadOffset< uint >( 228 );
        Unknown77 = parser.ReadOffset< uint >( 232 );
        Unknown78 = parser.ReadOffset< byte >( 236 );
        Unknown79 = parser.ReadOffset< byte >( 237 );
        Unknown80 = parser.ReadOffset< uint >( 240 );
        Unknown81 = parser.ReadOffset< uint >( 244 );
        Unknown82 = parser.ReadOffset< byte >( 248 );
        Unknown83 = parser.ReadOffset< byte >( 249 );
        Unknown84 = parser.ReadOffset< uint >( 252 );
        Unknown85 = parser.ReadOffset< uint >( 256 );
        Unknown86 = parser.ReadOffset< byte >( 260 );
        Unknown87 = parser.ReadOffset< byte >( 261 );
        Unknown88 = parser.ReadOffset< uint >( 264 );
        Unknown89 = parser.ReadOffset< uint >( 268 );
        Unknown90 = parser.ReadOffset< byte >( 272 );
        Unknown91 = parser.ReadOffset< byte >( 273 );
        Unknown92 = parser.ReadOffset< uint >( 276 );
        Unknown93 = parser.ReadOffset< uint >( 280 );
        Unknown94 = parser.ReadOffset< byte >( 284 );
        Unknown95 = parser.ReadOffset< byte >( 285 );
        Unknown96 = parser.ReadOffset< uint >( 288 );
        Unknown97 = parser.ReadOffset< uint >( 292 );
        Unknown98 = parser.ReadOffset< byte >( 296 );
        Unknown99 = parser.ReadOffset< byte >( 297 );
        Unknown100 = parser.ReadOffset< uint >( 300 );
        Unknown101 = parser.ReadOffset< uint >( 304 );
        Unknown102 = parser.ReadOffset< byte >( 308 );
        Unknown103 = parser.ReadOffset< byte >( 309 );
        Unknown104 = parser.ReadOffset< uint >( 312 );
        Unknown105 = parser.ReadOffset< uint >( 316 );
        Unknown106 = parser.ReadOffset< byte >( 320 );
        Unknown107 = parser.ReadOffset< byte >( 321 );
        Unknown108 = parser.ReadOffset< uint >( 324 );
        Unknown109 = parser.ReadOffset< uint >( 328 );
        Unknown110 = parser.ReadOffset< byte >( 332 );
        Unknown111 = parser.ReadOffset< byte >( 333 );
        Unknown112 = parser.ReadOffset< uint >( 336 );
        Unknown113 = parser.ReadOffset< uint >( 340 );
        Unknown114 = parser.ReadOffset< byte >( 344 );
        Unknown115 = parser.ReadOffset< byte >( 345 );
        Unknown116 = parser.ReadOffset< uint >( 348 );
        Unknown117 = parser.ReadOffset< uint >( 352 );
        Unknown118 = parser.ReadOffset< byte >( 356 );
        Unknown119 = parser.ReadOffset< byte >( 357 );
        Unknown120 = parser.ReadOffset< uint >( 360 );
        Unknown121 = parser.ReadOffset< uint >( 364 );
        Unknown122 = parser.ReadOffset< byte >( 368 );
        Unknown123 = parser.ReadOffset< byte >( 369 );
        Unknown124 = parser.ReadOffset< uint >( 372 );
        Unknown125 = parser.ReadOffset< uint >( 376 );
        Unknown126 = parser.ReadOffset< byte >( 380 );
        Unknown127 = parser.ReadOffset< byte >( 381 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIBuilding", columnHash: 0x6d809733 )]
public partial class MJIBuilding : ExcelRow
{
    
    public LazyRow< MJIText > Name { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Icon { get; private set; }
    public LazyRow< ExportedSG >[] Sgb { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public LazyRow< MJIItemPouch >[] Material { get; private set; }
    public byte[] Amount { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = new LazyRow< MJIText >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        Sgb = new LazyRow< ExportedSG >[5];
        for (int i = 0; i < 5; i++)
        	Sgb[i] = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< ushort >( (ushort) ( 12 + i * 2 ) ), language );
        Unknown1 = parser.ReadOffset< byte >( 22 );
        Unknown2 = parser.ReadOffset< byte >( 23 );
        Unknown3 = parser.ReadOffset< byte >( 24 );
        Unknown4 = parser.ReadOffset< byte >( 25 );
        Unknown5 = parser.ReadOffset< byte >( 26 );
        Unknown6 = parser.ReadOffset< byte >( 27 );
        Unknown7 = parser.ReadOffset< byte >( 28 );
        Unknown8 = parser.ReadOffset< byte >( 29 );
        Unknown9 = parser.ReadOffset< byte >( 30 );
        Unknown10 = parser.ReadOffset< byte >( 31 );
        Unknown11 = parser.ReadOffset< byte >( 32 );
        Unknown12 = parser.ReadOffset< byte >( 33 );
        Unknown13 = parser.ReadOffset< byte >( 34 );
        Unknown14 = parser.ReadOffset< byte >( 35 );
        Material = new LazyRow< MJIItemPouch >[5];
        for (int i = 0; i < 5; i++)
        	Material[i] = new LazyRow< MJIItemPouch >( gameData, parser.ReadOffset< byte >( (ushort) ( 36 + i * 1 ) ), language );
        Amount = new byte[5];
        for (int i = 0; i < 5; i++)
        	Amount[i] = parser.ReadOffset< byte >( 41 + i * 1 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJILandmark", columnHash: 0x7b947615 )]
public partial class MJILandmark : ExcelRow
{
    
    public LazyRow< MJIText > Name { get; private set; }
    public uint Icon { get; private set; }
    public ushort Unknown2 { get; private set; }
    public LazyRow< ExportedSG >[] SGB { get; private set; }
    public LazyRow< MJIItemPouch >[] Material { get; private set; }
    public ushort Unknown29 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte[] Amount { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = new LazyRow< MJIText >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Icon = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        SGB = new LazyRow< ExportedSG >[7];
        for (int i = 0; i < 7; i++)
        	SGB[i] = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< ushort >( (ushort) ( 10 + i * 2 ) ), language );
        Material = new LazyRow< MJIItemPouch >[5];
        for (int i = 0; i < 5; i++)
        	Material[i] = new LazyRow< MJIItemPouch >( gameData, parser.ReadOffset< ushort >( (ushort) ( 24 + i * 2 ) ), language );
        Unknown29 = parser.ReadOffset< ushort >( 34 );
        Unknown0 = parser.ReadOffset< byte >( 36 );
        Unknown1 = parser.ReadOffset< byte >( 37 );
        Unknown4 = parser.ReadOffset< byte >( 38 );
        Unknown6 = parser.ReadOffset< byte >( 39 );
        Unknown8 = parser.ReadOffset< byte >( 40 );
        Unknown10 = parser.ReadOffset< byte >( 41 );
        Unknown12 = parser.ReadOffset< byte >( 42 );
        Unknown13 = parser.ReadOffset< byte >( 43 );
        Unknown14 = parser.ReadOffset< byte >( 44 );
        Unknown15 = parser.ReadOffset< byte >( 45 );
        Unknown16 = parser.ReadOffset< byte >( 46 );
        Unknown17 = parser.ReadOffset< byte >( 47 );
        Amount = new byte[5];
        for (int i = 0; i < 5; i++)
        	Amount[i] = parser.ReadOffset< byte >( 48 + i * 1 );
        

    }
}
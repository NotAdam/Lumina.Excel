// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SharlayanCraftWorksSupply", columnHash: 0x903b128e )]
public partial class SharlayanCraftWorksSupply : ExcelRow
{
    
    public uint Unknown4 { get; private set; }
    public uint Unknown16 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public ushort Unknown12 { get; private set; }
    public ushort Unknown24 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown20 { get; private set; }
    public byte Unknown28 { get; private set; }
    public byte Unknown32 { get; private set; }
    public byte Unknown36 { get; private set; }
    public byte Unknown40 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Unknown17 { get; private set; }
    public ushort Unknown9 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public ushort Unknown25 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown21 { get; private set; }
    public byte Unknown29 { get; private set; }
    public byte Unknown33 { get; private set; }
    public byte Unknown37 { get; private set; }
    public byte Unknown41 { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Unknown18 { get; private set; }
    public ushort Unknown10 { get; private set; }
    public ushort Unknown14 { get; private set; }
    public ushort Unknown26 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown22 { get; private set; }
    public byte Unknown30 { get; private set; }
    public byte Unknown34 { get; private set; }
    public byte Unknown38 { get; private set; }
    public byte Unknown42 { get; private set; }
    public uint Unknown7 { get; private set; }
    public uint Unknown19 { get; private set; }
    public ushort Unknown11 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public ushort Unknown27 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown23 { get; private set; }
    public byte Unknown31 { get; private set; }
    public byte Unknown35 { get; private set; }
    public byte Unknown39 { get; private set; }
    public byte Unknown43 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown4 = parser.ReadOffset< uint >( 0 );
        Unknown16 = parser.ReadOffset< uint >( 4 );
        Unknown8 = parser.ReadOffset< ushort >( 8 );
        Unknown12 = parser.ReadOffset< ushort >( 10 );
        Unknown24 = parser.ReadOffset< ushort >( 12 );
        Unknown0 = parser.ReadOffset< byte >( 14 );
        Unknown20 = parser.ReadOffset< byte >( 15 );
        Unknown28 = parser.ReadOffset< byte >( 16 );
        Unknown32 = parser.ReadOffset< byte >( 17 );
        Unknown36 = parser.ReadOffset< byte >( 18 );
        Unknown40 = parser.ReadOffset< byte >( 19 );
        Unknown5 = parser.ReadOffset< uint >( 20 );
        Unknown17 = parser.ReadOffset< uint >( 24 );
        Unknown9 = parser.ReadOffset< ushort >( 28 );
        Unknown13 = parser.ReadOffset< ushort >( 30 );
        Unknown25 = parser.ReadOffset< ushort >( 32 );
        Unknown1 = parser.ReadOffset< byte >( 34 );
        Unknown21 = parser.ReadOffset< byte >( 35 );
        Unknown29 = parser.ReadOffset< byte >( 36 );
        Unknown33 = parser.ReadOffset< byte >( 37 );
        Unknown37 = parser.ReadOffset< byte >( 38 );
        Unknown41 = parser.ReadOffset< byte >( 39 );
        Unknown6 = parser.ReadOffset< uint >( 40 );
        Unknown18 = parser.ReadOffset< uint >( 44 );
        Unknown10 = parser.ReadOffset< ushort >( 48 );
        Unknown14 = parser.ReadOffset< ushort >( 50 );
        Unknown26 = parser.ReadOffset< ushort >( 52 );
        Unknown2 = parser.ReadOffset< byte >( 54 );
        Unknown22 = parser.ReadOffset< byte >( 55 );
        Unknown30 = parser.ReadOffset< byte >( 56 );
        Unknown34 = parser.ReadOffset< byte >( 57 );
        Unknown38 = parser.ReadOffset< byte >( 58 );
        Unknown42 = parser.ReadOffset< byte >( 59 );
        Unknown7 = parser.ReadOffset< uint >( 60 );
        Unknown19 = parser.ReadOffset< uint >( 64 );
        Unknown11 = parser.ReadOffset< ushort >( 68 );
        Unknown15 = parser.ReadOffset< ushort >( 70 );
        Unknown27 = parser.ReadOffset< ushort >( 72 );
        Unknown3 = parser.ReadOffset< byte >( 74 );
        Unknown23 = parser.ReadOffset< byte >( 75 );
        Unknown31 = parser.ReadOffset< byte >( 76 );
        Unknown35 = parser.ReadOffset< byte >( 77 );
        Unknown39 = parser.ReadOffset< byte >( 78 );
        Unknown43 = parser.ReadOffset< byte >( 79 );
        

    }
}
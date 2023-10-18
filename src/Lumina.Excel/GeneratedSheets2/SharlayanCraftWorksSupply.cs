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
    
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public uint Unknown11 { get; private set; }
    public uint Unknown12 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public ushort Unknown14 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    public byte Unknown21 { get; private set; }
    public uint Unknown22 { get; private set; }
    public uint Unknown23 { get; private set; }
    public ushort Unknown24 { get; private set; }
    public ushort Unknown25 { get; private set; }
    public ushort Unknown26 { get; private set; }
    public byte Unknown27 { get; private set; }
    public byte Unknown28 { get; private set; }
    public byte Unknown29 { get; private set; }
    public byte Unknown30 { get; private set; }
    public byte Unknown31 { get; private set; }
    public byte Unknown32 { get; private set; }
    public uint Unknown33 { get; private set; }
    public uint Unknown34 { get; private set; }
    public ushort Unknown35 { get; private set; }
    public ushort Unknown36 { get; private set; }
    public ushort Unknown37 { get; private set; }
    public byte Unknown38 { get; private set; }
    public byte Unknown39 { get; private set; }
    public byte Unknown40 { get; private set; }
    public byte Unknown41 { get; private set; }
    public byte Unknown42 { get; private set; }
    public byte Unknown43 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        Unknown3 = parser.ReadOffset< ushort >( 10 );
        Unknown4 = parser.ReadOffset< ushort >( 12 );
        Unknown5 = parser.ReadOffset< byte >( 14 );
        Unknown6 = parser.ReadOffset< byte >( 15 );
        Unknown7 = parser.ReadOffset< byte >( 16 );
        Unknown8 = parser.ReadOffset< byte >( 17 );
        Unknown9 = parser.ReadOffset< byte >( 18 );
        Unknown10 = parser.ReadOffset< byte >( 19 );
        Unknown11 = parser.ReadOffset< uint >( 20 );
        Unknown12 = parser.ReadOffset< uint >( 24 );
        Unknown13 = parser.ReadOffset< ushort >( 28 );
        Unknown14 = parser.ReadOffset< ushort >( 30 );
        Unknown15 = parser.ReadOffset< ushort >( 32 );
        Unknown16 = parser.ReadOffset< byte >( 34 );
        Unknown17 = parser.ReadOffset< byte >( 35 );
        Unknown18 = parser.ReadOffset< byte >( 36 );
        Unknown19 = parser.ReadOffset< byte >( 37 );
        Unknown20 = parser.ReadOffset< byte >( 38 );
        Unknown21 = parser.ReadOffset< byte >( 39 );
        Unknown22 = parser.ReadOffset< uint >( 40 );
        Unknown23 = parser.ReadOffset< uint >( 44 );
        Unknown24 = parser.ReadOffset< ushort >( 48 );
        Unknown25 = parser.ReadOffset< ushort >( 50 );
        Unknown26 = parser.ReadOffset< ushort >( 52 );
        Unknown27 = parser.ReadOffset< byte >( 54 );
        Unknown28 = parser.ReadOffset< byte >( 55 );
        Unknown29 = parser.ReadOffset< byte >( 56 );
        Unknown30 = parser.ReadOffset< byte >( 57 );
        Unknown31 = parser.ReadOffset< byte >( 58 );
        Unknown32 = parser.ReadOffset< byte >( 59 );
        Unknown33 = parser.ReadOffset< uint >( 60 );
        Unknown34 = parser.ReadOffset< uint >( 64 );
        Unknown35 = parser.ReadOffset< ushort >( 68 );
        Unknown36 = parser.ReadOffset< ushort >( 70 );
        Unknown37 = parser.ReadOffset< ushort >( 72 );
        Unknown38 = parser.ReadOffset< byte >( 74 );
        Unknown39 = parser.ReadOffset< byte >( 75 );
        Unknown40 = parser.ReadOffset< byte >( 76 );
        Unknown41 = parser.ReadOffset< byte >( 77 );
        Unknown42 = parser.ReadOffset< byte >( 78 );
        Unknown43 = parser.ReadOffset< byte >( 79 );
        

    }
}
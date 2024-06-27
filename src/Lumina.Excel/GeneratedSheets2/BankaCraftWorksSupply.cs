// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BankaCraftWorksSupply", columnHash: 0x444a6117 )]
public partial class BankaCraftWorksSupply : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public uint Unknown10 { get; private set; }
    public uint Unknown11 { get; private set; }
    public ushort Unknown12 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public uint Unknown20 { get; private set; }
    public uint Unknown21 { get; private set; }
    public ushort Unknown22 { get; private set; }
    public ushort Unknown23 { get; private set; }
    public byte Unknown24 { get; private set; }
    public byte Unknown25 { get; private set; }
    public byte Unknown26 { get; private set; }
    public byte Unknown27 { get; private set; }
    public byte Unknown28 { get; private set; }
    public byte Unknown29 { get; private set; }
    public uint Unknown30 { get; private set; }
    public uint Unknown31 { get; private set; }
    public ushort Unknown32 { get; private set; }
    public ushort Unknown33 { get; private set; }
    public byte Unknown34 { get; private set; }
    public byte Unknown35 { get; private set; }
    public byte Unknown36 { get; private set; }
    public byte Unknown37 { get; private set; }
    public byte Unknown38 { get; private set; }
    public byte Unknown39 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        Unknown3 = parser.ReadOffset< ushort >( 10 );
        Unknown4 = parser.ReadOffset< byte >( 12 );
        Unknown5 = parser.ReadOffset< byte >( 13 );
        Unknown6 = parser.ReadOffset< byte >( 14 );
        Unknown7 = parser.ReadOffset< byte >( 15 );
        Unknown8 = parser.ReadOffset< byte >( 16 );
        Unknown9 = parser.ReadOffset< byte >( 17 );
        Unknown10 = parser.ReadOffset< uint >( 20 );
        Unknown11 = parser.ReadOffset< uint >( 24 );
        Unknown12 = parser.ReadOffset< ushort >( 28 );
        Unknown13 = parser.ReadOffset< ushort >( 30 );
        Unknown14 = parser.ReadOffset< byte >( 32 );
        Unknown15 = parser.ReadOffset< byte >( 33 );
        Unknown16 = parser.ReadOffset< byte >( 34 );
        Unknown17 = parser.ReadOffset< byte >( 35 );
        Unknown18 = parser.ReadOffset< byte >( 36 );
        Unknown19 = parser.ReadOffset< byte >( 37 );
        Unknown20 = parser.ReadOffset< uint >( 40 );
        Unknown21 = parser.ReadOffset< uint >( 44 );
        Unknown22 = parser.ReadOffset< ushort >( 48 );
        Unknown23 = parser.ReadOffset< ushort >( 50 );
        Unknown24 = parser.ReadOffset< byte >( 52 );
        Unknown25 = parser.ReadOffset< byte >( 53 );
        Unknown26 = parser.ReadOffset< byte >( 54 );
        Unknown27 = parser.ReadOffset< byte >( 55 );
        Unknown28 = parser.ReadOffset< byte >( 56 );
        Unknown29 = parser.ReadOffset< byte >( 57 );
        Unknown30 = parser.ReadOffset< uint >( 60 );
        Unknown31 = parser.ReadOffset< uint >( 64 );
        Unknown32 = parser.ReadOffset< ushort >( 68 );
        Unknown33 = parser.ReadOffset< ushort >( 70 );
        Unknown34 = parser.ReadOffset< byte >( 72 );
        Unknown35 = parser.ReadOffset< byte >( 73 );
        Unknown36 = parser.ReadOffset< byte >( 74 );
        Unknown37 = parser.ReadOffset< byte >( 75 );
        Unknown38 = parser.ReadOffset< byte >( 76 );
        Unknown39 = parser.ReadOffset< byte >( 77 );
        

    }
}
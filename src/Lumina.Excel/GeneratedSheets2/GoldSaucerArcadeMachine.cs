// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GoldSaucerArcadeMachine", columnHash: 0xacb73d9e )]
public partial class GoldSaucerArcadeMachine : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public uint Poor { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Good { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public uint Unknown10 { get; private set; }
    public uint Great { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public uint Unknown15 { get; private set; }
    public uint Excellent { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public SeString Unknown20 { get; private set; }
    public SeString Unknown21 { get; private set; }
    public SeString Unknown22 { get; private set; }
    public SeString Unknown23 { get; private set; }
    public uint FailImage { get; private set; }
    public uint Unknown24 { get; private set; }
    public ushort Unknown25 { get; private set; }
    public byte Unknown26 { get; private set; }
    public byte Unknown27 { get; private set; }
    public byte Unknown28 { get; private set; }
    public byte Unknown29 { get; private set; }
    public byte Unknown30 { get; private set; }
    public byte Unknown31 { get; private set; }
    public sbyte Unknown32 { get; private set; }
    public sbyte Unknown33 { get; private set; }
    public sbyte Unknown34 { get; private set; }
    public sbyte Unknown35 { get; private set; }
    public sbyte Unknown36 { get; private set; }
    public sbyte Unknown37 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Poor = parser.ReadOffset< uint >( 4 );
        Unknown1 = parser.ReadOffset< byte >( 8 );
        Unknown2 = parser.ReadOffset< byte >( 9 );
        Unknown3 = parser.ReadOffset< byte >( 10 );
        Unknown4 = parser.ReadOffset< byte >( 11 );
        Unknown5 = parser.ReadOffset< uint >( 12 );
        Good = parser.ReadOffset< uint >( 16 );
        Unknown6 = parser.ReadOffset< byte >( 20 );
        Unknown7 = parser.ReadOffset< byte >( 21 );
        Unknown8 = parser.ReadOffset< byte >( 22 );
        Unknown9 = parser.ReadOffset< byte >( 23 );
        Unknown10 = parser.ReadOffset< uint >( 24 );
        Great = parser.ReadOffset< uint >( 28 );
        Unknown11 = parser.ReadOffset< byte >( 32 );
        Unknown12 = parser.ReadOffset< byte >( 33 );
        Unknown13 = parser.ReadOffset< byte >( 34 );
        Unknown14 = parser.ReadOffset< byte >( 35 );
        Unknown15 = parser.ReadOffset< uint >( 36 );
        Excellent = parser.ReadOffset< uint >( 40 );
        Unknown16 = parser.ReadOffset< byte >( 44 );
        Unknown17 = parser.ReadOffset< byte >( 45 );
        Unknown18 = parser.ReadOffset< byte >( 46 );
        Unknown19 = parser.ReadOffset< byte >( 47 );
        Unknown20 = parser.ReadOffset< SeString >( 48 );
        Unknown21 = parser.ReadOffset< SeString >( 52 );
        Unknown22 = parser.ReadOffset< SeString >( 56 );
        Unknown23 = parser.ReadOffset< SeString >( 60 );
        FailImage = parser.ReadOffset< uint >( 64 );
        Unknown24 = parser.ReadOffset< uint >( 68 );
        Unknown25 = parser.ReadOffset< ushort >( 72 );
        Unknown26 = parser.ReadOffset< byte >( 74 );
        Unknown27 = parser.ReadOffset< byte >( 75 );
        Unknown28 = parser.ReadOffset< byte >( 76 );
        Unknown29 = parser.ReadOffset< byte >( 77 );
        Unknown30 = parser.ReadOffset< byte >( 78 );
        Unknown31 = parser.ReadOffset< byte >( 79 );
        Unknown32 = parser.ReadOffset< sbyte >( 80 );
        Unknown33 = parser.ReadOffset< sbyte >( 81 );
        Unknown34 = parser.ReadOffset< sbyte >( 82 );
        Unknown35 = parser.ReadOffset< sbyte >( 83 );
        Unknown36 = parser.ReadOffset< sbyte >( 84 );
        Unknown37 = parser.ReadOffset< sbyte >( 85 );
        

    }
}
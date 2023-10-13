// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CraftLeveTalk", columnHash: 0x000c7d93 )]
public partial class CraftLeveTalk : ExcelRow
{
    
    public uint Unknown12 { get; private set; }
    public int Unknown30 { get; private set; }
    public byte Unknown6 { get; private set; }
    public sbyte Unknown18 { get; private set; }
    public sbyte Unknown24 { get; private set; }
    public bool Unknown0 { get; private set; }
    public uint Unknown13 { get; private set; }
    public int Unknown31 { get; private set; }
    public byte Unknown7 { get; private set; }
    public sbyte Unknown19 { get; private set; }
    public sbyte Unknown25 { get; private set; }
    public bool Unknown1 { get; private set; }
    public uint Unknown14 { get; private set; }
    public int Unknown32 { get; private set; }
    public byte Unknown8 { get; private set; }
    public sbyte Unknown20 { get; private set; }
    public sbyte Unknown26 { get; private set; }
    public bool Unknown2 { get; private set; }
    public uint Unknown15 { get; private set; }
    public int Unknown33 { get; private set; }
    public byte Unknown9 { get; private set; }
    public sbyte Unknown21 { get; private set; }
    public sbyte Unknown27 { get; private set; }
    public bool Unknown3 { get; private set; }
    public uint Unknown16 { get; private set; }
    public int Unknown34 { get; private set; }
    public byte Unknown10 { get; private set; }
    public sbyte Unknown22 { get; private set; }
    public sbyte Unknown28 { get; private set; }
    public bool Unknown4 { get; private set; }
    public uint Unknown17 { get; private set; }
    public int Unknown35 { get; private set; }
    public byte Unknown11 { get; private set; }
    public sbyte Unknown23 { get; private set; }
    public sbyte Unknown29 { get; private set; }
    public bool Unknown5 { get; private set; }
    public SeString[] Talk { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown12 = parser.ReadOffset< uint >( 0 );
        Unknown30 = parser.ReadOffset< int >( 4 );
        Unknown6 = parser.ReadOffset< byte >( 8 );
        Unknown18 = parser.ReadOffset< sbyte >( 9 );
        Unknown24 = parser.ReadOffset< sbyte >( 10 );
        Unknown0 = parser.ReadOffset< bool >( 11 );
        Unknown13 = parser.ReadOffset< uint >( 12 );
        Unknown31 = parser.ReadOffset< int >( 16 );
        Unknown7 = parser.ReadOffset< byte >( 20 );
        Unknown19 = parser.ReadOffset< sbyte >( 21 );
        Unknown25 = parser.ReadOffset< sbyte >( 22 );
        Unknown1 = parser.ReadOffset< bool >( 23 );
        Unknown14 = parser.ReadOffset< uint >( 24 );
        Unknown32 = parser.ReadOffset< int >( 28 );
        Unknown8 = parser.ReadOffset< byte >( 32 );
        Unknown20 = parser.ReadOffset< sbyte >( 33 );
        Unknown26 = parser.ReadOffset< sbyte >( 34 );
        Unknown2 = parser.ReadOffset< bool >( 35 );
        Unknown15 = parser.ReadOffset< uint >( 36 );
        Unknown33 = parser.ReadOffset< int >( 40 );
        Unknown9 = parser.ReadOffset< byte >( 44 );
        Unknown21 = parser.ReadOffset< sbyte >( 45 );
        Unknown27 = parser.ReadOffset< sbyte >( 46 );
        Unknown3 = parser.ReadOffset< bool >( 47 );
        Unknown16 = parser.ReadOffset< uint >( 48 );
        Unknown34 = parser.ReadOffset< int >( 52 );
        Unknown10 = parser.ReadOffset< byte >( 56 );
        Unknown22 = parser.ReadOffset< sbyte >( 57 );
        Unknown28 = parser.ReadOffset< sbyte >( 58 );
        Unknown4 = parser.ReadOffset< bool >( 59 );
        Unknown17 = parser.ReadOffset< uint >( 60 );
        Unknown35 = parser.ReadOffset< int >( 64 );
        Unknown11 = parser.ReadOffset< byte >( 68 );
        Unknown23 = parser.ReadOffset< sbyte >( 69 );
        Unknown29 = parser.ReadOffset< sbyte >( 70 );
        Unknown5 = parser.ReadOffset< bool >( 71 );
        Talk = new SeString[6];
        for (int i = 0; i < 6; i++)
        	Talk[i] = parser.ReadOffset< SeString >( 72 + i * 4 );
        

    }
}
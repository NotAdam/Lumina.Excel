// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GuildleveAssignmentTalk", columnHash: 0xed64467f )]
public partial class GuildleveAssignmentTalk : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public int Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public sbyte Unknown9 { get; private set; }
    public sbyte Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public uint Unknown12 { get; private set; }
    public int Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public sbyte Unknown15 { get; private set; }
    public sbyte Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    public uint Unknown18 { get; private set; }
    public int Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    public sbyte Unknown21 { get; private set; }
    public sbyte Unknown22 { get; private set; }
    public bool Unknown23 { get; private set; }
    public uint Unknown24 { get; private set; }
    public int Unknown25 { get; private set; }
    public byte Unknown26 { get; private set; }
    public sbyte Unknown27 { get; private set; }
    public sbyte Unknown28 { get; private set; }
    public bool Unknown29 { get; private set; }
    public SeString[] Talk { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Unknown2 = parser.ReadOffset< byte >( 8 );
        Unknown3 = parser.ReadOffset< sbyte >( 9 );
        Unknown4 = parser.ReadOffset< sbyte >( 10 );
        Unknown5 = parser.ReadOffset< bool >( 11 );
        Unknown6 = parser.ReadOffset< uint >( 12 );
        Unknown7 = parser.ReadOffset< int >( 16 );
        Unknown8 = parser.ReadOffset< byte >( 20 );
        Unknown9 = parser.ReadOffset< sbyte >( 21 );
        Unknown10 = parser.ReadOffset< sbyte >( 22 );
        Unknown11 = parser.ReadOffset< bool >( 23 );
        Unknown12 = parser.ReadOffset< uint >( 24 );
        Unknown13 = parser.ReadOffset< int >( 28 );
        Unknown14 = parser.ReadOffset< byte >( 32 );
        Unknown15 = parser.ReadOffset< sbyte >( 33 );
        Unknown16 = parser.ReadOffset< sbyte >( 34 );
        Unknown17 = parser.ReadOffset< bool >( 35 );
        Unknown18 = parser.ReadOffset< uint >( 36 );
        Unknown19 = parser.ReadOffset< int >( 40 );
        Unknown20 = parser.ReadOffset< byte >( 44 );
        Unknown21 = parser.ReadOffset< sbyte >( 45 );
        Unknown22 = parser.ReadOffset< sbyte >( 46 );
        Unknown23 = parser.ReadOffset< bool >( 47 );
        Unknown24 = parser.ReadOffset< uint >( 48 );
        Unknown25 = parser.ReadOffset< int >( 52 );
        Unknown26 = parser.ReadOffset< byte >( 56 );
        Unknown27 = parser.ReadOffset< sbyte >( 57 );
        Unknown28 = parser.ReadOffset< sbyte >( 58 );
        Unknown29 = parser.ReadOffset< bool >( 59 );
        Talk = new SeString[8];
        for (int i = 0; i < 8; i++)
        	Talk[i] = parser.ReadOffset< SeString >( 60 + i * 4 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ShellFixedFromCommand", columnHash: 0x219477f2 )]
public partial class ShellFixedFromCommand : ExcelRow
{
    
    public ulong Unknown0 { get; private set; }
    public ulong Unknown1 { get; private set; }
    public ulong Unknown2 { get; private set; }
    public ulong Unknown3 { get; private set; }
    public ulong Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public bool Unknown18 { get; private set; }
    public bool Unknown19 { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool Unknown21 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ulong >( 0 );
        Unknown1 = parser.ReadOffset< ulong >( 8 );
        Unknown2 = parser.ReadOffset< ulong >( 16 );
        Unknown3 = parser.ReadOffset< ulong >( 24 );
        Unknown4 = parser.ReadOffset< ulong >( 32 );
        Unknown5 = parser.ReadOffset< uint >( 40 );
        Unknown6 = parser.ReadOffset< uint >( 44 );
        Unknown7 = parser.ReadOffset< uint >( 48 );
        Unknown8 = parser.ReadOffset< byte >( 52 );
        Unknown9 = parser.ReadOffset< byte >( 53 );
        Unknown10 = parser.ReadOffset< byte >( 54 );
        Unknown11 = parser.ReadOffset< byte >( 55 );
        Unknown12 = parser.ReadOffset< byte >( 56 );
        Unknown13 = parser.ReadOffset< byte >( 57 );
        Unknown14 = parser.ReadOffset< byte >( 58 );
        Unknown15 = parser.ReadOffset< byte >( 59 );
        Unknown16 = parser.ReadOffset< byte >( 60 );
        Unknown17 = parser.ReadOffset< byte >( 61 );
        Unknown18 = parser.ReadOffset< bool >( 62 );
        Unknown19 = parser.ReadOffset< bool >( 62, 2 );
        Unknown20 = parser.ReadOffset< bool >( 62, 4 );
        Unknown21 = parser.ReadOffset< bool >( 62, 8 );
        

    }
}
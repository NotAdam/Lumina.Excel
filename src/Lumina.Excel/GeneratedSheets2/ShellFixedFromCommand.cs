// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ShellFixedFromCommand", columnHash: 0xde380e3e )]
public partial class ShellFixedFromCommand : ExcelRow
{
    
    public SeString Unknown8 { get; private set; }
    public SeString Unknown9 { get; private set; }
    public SeString Unknown10 { get; private set; }
    public SeString Unknown11 { get; private set; }
    public SeString Unknown12 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    public byte Unknown21 { get; private set; }
    public bool Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown8 = parser.ReadOffset< SeString >( 0 );
        Unknown9 = parser.ReadOffset< SeString >( 4 );
        Unknown10 = parser.ReadOffset< SeString >( 8 );
        Unknown11 = parser.ReadOffset< SeString >( 12 );
        Unknown12 = parser.ReadOffset< SeString >( 16 );
        Unknown2 = parser.ReadOffset< uint >( 20 );
        Unknown3 = parser.ReadOffset< uint >( 24 );
        Unknown6 = parser.ReadOffset< uint >( 28 );
        Unknown7 = parser.ReadOffset< byte >( 32 );
        Unknown13 = parser.ReadOffset< byte >( 33 );
        Unknown14 = parser.ReadOffset< byte >( 34 );
        Unknown15 = parser.ReadOffset< byte >( 35 );
        Unknown16 = parser.ReadOffset< byte >( 36 );
        Unknown17 = parser.ReadOffset< byte >( 37 );
        Unknown18 = parser.ReadOffset< byte >( 38 );
        Unknown19 = parser.ReadOffset< byte >( 39 );
        Unknown20 = parser.ReadOffset< byte >( 40 );
        Unknown21 = parser.ReadOffset< byte >( 41 );
        Unknown0 = parser.ReadOffset< bool >( 42 );
        Unknown1 = parser.ReadOffset< bool >( 42, 2 );
        Unknown4 = parser.ReadOffset< bool >( 42, 4 );
        Unknown5 = parser.ReadOffset< bool >( 42, 8 );
        

    }
}
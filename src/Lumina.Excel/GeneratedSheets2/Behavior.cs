// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Behavior", columnHash: 0x858a7450 )]
public partial class Behavior : ExcelRow
{
    
    public uint ContentArgument0 { get; private set; }
    public uint Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public LazyRow< Balloon > Balloon { get; private set; }
    public ushort Unknown4 { get; private set; }
    public short Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Condition0Target { get; private set; }
    public byte Condition0Type { get; private set; }
    public byte Condition1Target { get; private set; }
    public byte Condition1Type { get; private set; }
    public byte ContentArgument1 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ContentArgument0 = parser.ReadOffset< uint >( 0 );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        Unknown1 = parser.ReadOffset< int >( 8 );
        Unknown2 = parser.ReadOffset< int >( 12 );
        Unknown3 = parser.ReadOffset< ushort >( 16 );
        Balloon = new LazyRow< Balloon >( gameData, parser.ReadOffset< ushort >( 18 ), language );
        Unknown4 = parser.ReadOffset< ushort >( 20 );
        Unknown5 = parser.ReadOffset< short >( 22 );
        Unknown6 = parser.ReadOffset< byte >( 24 );
        Unknown7 = parser.ReadOffset< byte >( 25 );
        Condition0Target = parser.ReadOffset< byte >( 26 );
        Condition0Type = parser.ReadOffset< byte >( 27 );
        Condition1Target = parser.ReadOffset< byte >( 28 );
        Condition1Type = parser.ReadOffset< byte >( 29 );
        ContentArgument1 = parser.ReadOffset< byte >( 30 );
        Unknown8 = parser.ReadOffset< byte >( 31 );
        Unknown9 = parser.ReadOffset< byte >( 32 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GcArmyCapture", columnHash: 0x95ba3e0b )]
public partial class GcArmyCapture : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        Unknown3 = parser.ReadOffset< ushort >( 10 );
        Unknown4 = parser.ReadOffset< ushort >( 12 );
        Unknown5 = parser.ReadOffset< ushort >( 14 );
        Unknown6 = parser.ReadOffset< byte >( 16 );
        Unknown7 = parser.ReadOffset< byte >( 17 );
        

    }
}
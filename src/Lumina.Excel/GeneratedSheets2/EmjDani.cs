// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EmjDani", columnHash: 0xf3fb0152 )]
public partial class EmjDani : ExcelRow
{
    
    public uint Icon { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public short Unknown4 { get; private set; }
    public short Unknown5 { get; private set; }
    public short Unknown6 { get; private set; }
    public short Unknown7 { get; private set; }
    public short Unknown8 { get; private set; }
    public short Unknown9 { get; private set; }
    public short Unknown10 { get; private set; }
    public short Unknown11 { get; private set; }
    public bool Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 6 );
        Unknown4 = parser.ReadOffset< short >( 8 );
        Unknown5 = parser.ReadOffset< short >( 10 );
        Unknown6 = parser.ReadOffset< short >( 12 );
        Unknown7 = parser.ReadOffset< short >( 14 );
        Unknown8 = parser.ReadOffset< short >( 16 );
        Unknown9 = parser.ReadOffset< short >( 18 );
        Unknown10 = parser.ReadOffset< short >( 20 );
        Unknown11 = parser.ReadOffset< short >( 22 );
        Unknown3 = parser.ReadOffset< bool >( 24 );
        

    }
}
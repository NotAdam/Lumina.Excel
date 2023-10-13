// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "OrnamentCustomize", columnHash: 0x9f62c1b0 )]
public partial class OrnamentCustomize : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public short Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public short Unknown3 { get; private set; }
    public short Unknown4 { get; private set; }
    public short Unknown5 { get; private set; }
    public short Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        Unknown1 = parser.ReadOffset< short >( 2 );
        Unknown2 = parser.ReadOffset< short >( 4 );
        Unknown3 = parser.ReadOffset< short >( 6 );
        Unknown4 = parser.ReadOffset< short >( 8 );
        Unknown5 = parser.ReadOffset< short >( 10 );
        Unknown6 = parser.ReadOffset< short >( 12 );
        

    }
}
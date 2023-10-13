// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AddonHudSize", columnHash: 0x20bf3d37 )]
public partial class AddonHudSize : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public short Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 2 );
        Unknown2 = parser.ReadOffset< short >( 4 );
        Unknown3 = parser.ReadOffset< short >( 6 );
        

    }
}
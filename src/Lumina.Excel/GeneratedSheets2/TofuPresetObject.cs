// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TofuPresetObject", columnHash: 0xf0686a78 )]
public partial class TofuPresetObject : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public short Unknown4 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 6 );
        Unknown4 = parser.ReadOffset< short >( 8 );
        Unknown3 = parser.ReadOffset< byte >( 10 );
        Unknown5 = parser.ReadOffset< bool >( 11 );
        Unknown6 = parser.ReadOffset< bool >( 11, 2 );
        

    }
}
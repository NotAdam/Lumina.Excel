// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Cutscene", columnHash: 0xae8b8521 )]
public partial class Cutscene : ExcelRow
{
    
    public SeString Path { get; private set; }
    public int Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Path = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< int >( 4 );
        Unknown1 = parser.ReadOffset< int >( 8 );
        Unknown2 = parser.ReadOffset< int >( 12 );
        Unknown3 = parser.ReadOffset< int >( 16 );
        Unknown4 = parser.ReadOffset< ushort >( 20 );
        Unknown5 = parser.ReadOffset< byte >( 22 );
        Unknown6 = parser.ReadOffset< byte >( 23 );
        Unknown7 = parser.ReadOffset< bool >( 24 );
        Unknown8 = parser.ReadOffset< bool >( 24, 2 );
        

    }
}
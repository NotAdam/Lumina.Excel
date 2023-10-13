// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Omikuji", columnHash: 0x11155d32 )]
public partial class Omikuji : ExcelRow
{
    
    public SeString Unknown5 { get; private set; }
    public SeString Unknown6 { get; private set; }
    public int Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown3 { get; private set; }
    public int Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown5 = parser.ReadOffset< SeString >( 0 );
        Unknown6 = parser.ReadOffset< SeString >( 4 );
        Unknown0 = parser.ReadOffset< int >( 8 );
        Unknown1 = parser.ReadOffset< int >( 12 );
        Unknown2 = parser.ReadOffset< int >( 16 );
        Unknown3 = parser.ReadOffset< int >( 20 );
        Unknown4 = parser.ReadOffset< int >( 24 );
        

    }
}
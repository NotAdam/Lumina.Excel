// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Weather", columnHash: 0x02cf2541 )]
public partial class Weather : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public SeString Unknown3 { get; private set; }
    public SeString Unknown4 { get; private set; }
    public SeString Unknown5 { get; private set; }
    public SeString Unknown6 { get; private set; }
    public int Icon { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Unknown3 = parser.ReadOffset< SeString >( 8 );
        Unknown4 = parser.ReadOffset< SeString >( 12 );
        Unknown5 = parser.ReadOffset< SeString >( 16 );
        Unknown6 = parser.ReadOffset< SeString >( 20 );
        Icon = parser.ReadOffset< int >( 24 );
        

    }
}
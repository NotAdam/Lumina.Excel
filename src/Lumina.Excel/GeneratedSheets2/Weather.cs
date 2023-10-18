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
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public SeString Unknown2 { get; private set; }
    public SeString Unknown3 { get; private set; }
    public int Icon { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Unknown0 = parser.ReadOffset< SeString >( 8 );
        Unknown1 = parser.ReadOffset< SeString >( 12 );
        Unknown2 = parser.ReadOffset< SeString >( 16 );
        Unknown3 = parser.ReadOffset< SeString >( 20 );
        Icon = parser.ReadOffset< int >( 24 );
        

    }
}
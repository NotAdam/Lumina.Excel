// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingEmploymentNpcRace", columnHash: 0xdebb20e3 )]
public partial class HousingEmploymentNpcRace : ExcelRow
{
    
    public SeString Race { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Race = parser.ReadOffset< SeString >( 0 );
        

    }
}
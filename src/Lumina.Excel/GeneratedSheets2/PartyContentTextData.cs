// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PartyContentTextData", columnHash: 0xdebb20e3 )]
public partial class PartyContentTextData : ExcelRow
{
    
    public SeString Data { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Data = parser.ReadOffset< SeString >( 0 );
        

    }
}
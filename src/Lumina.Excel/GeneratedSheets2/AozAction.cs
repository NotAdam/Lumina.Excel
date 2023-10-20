// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AozAction", columnHash: 0x5a516458 )]
public partial class AozAction : ExcelRow
{
    
    public LazyRow< Action > Action { get; private set; }
    public byte Rank { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Action = new LazyRow< Action >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Rank = parser.ReadOffset< byte >( 4 );
        

    }
}
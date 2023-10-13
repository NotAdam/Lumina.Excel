// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EurekaMagiaAction", columnHash: 0x5a516458 )]
public partial class EurekaMagiaAction : ExcelRow
{
    
    public LazyRow< Action > Action { get; private set; }
    public byte MaxUses { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Action = new LazyRow< Action >( gameData, parser.ReadOffset< uint >( 0 ), language );
        MaxUses = parser.ReadOffset< byte >( 4 );
        

    }
}
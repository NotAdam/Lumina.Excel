// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FCRights", columnHash: 0xce73d687 )]
public partial class FCRights : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public ushort Icon { get; private set; }
    public LazyRow< FCRank > FCRank { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< ushort >( 8 );
        FCRank = new LazyRow< FCRank >( gameData, parser.ReadOffset< byte >( 10 ), language );
        

    }
}
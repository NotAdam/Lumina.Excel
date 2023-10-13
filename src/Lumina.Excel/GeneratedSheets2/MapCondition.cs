// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MapCondition", columnHash: 0x2064ea88 )]
public partial class MapCondition : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 0 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        Unknown2 = parser.ReadOffset< byte >( 6 );
        

    }
}
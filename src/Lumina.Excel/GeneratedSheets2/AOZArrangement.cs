// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AOZArrangement", columnHash: 0x2020acf6 )]
public partial class AOZArrangement : ExcelRow
{
    
    public LazyRow< AOZContentBriefingBNpc > AOZContentBriefingBNpc { get; private set; }
    public ushort Position { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        AOZContentBriefingBNpc = new LazyRow< AOZContentBriefingBNpc >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Position = parser.ReadOffset< ushort >( 2 );
        

    }
}
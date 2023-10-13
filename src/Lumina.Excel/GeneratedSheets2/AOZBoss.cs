// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AOZBoss", columnHash: 0x2020acf6 )]
public partial class AOZBoss : ExcelRow
{
    
    public LazyRow< AOZContentBriefingBNpc > Boss { get; private set; }
    public ushort Position { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Boss = new LazyRow< AOZContentBriefingBNpc >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Position = parser.ReadOffset< ushort >( 2 );
        

    }
}
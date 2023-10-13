// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentRandomSelect", columnHash: 0xd870e208 )]
public partial class ContentRandomSelect : ExcelRow
{
    
    public LazyRow< ContentFinderCondition > Name { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = new LazyRow< ContentFinderCondition >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        

    }
}
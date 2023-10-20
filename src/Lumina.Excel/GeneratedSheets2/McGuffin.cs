// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "McGuffin", columnHash: 0xdcfd9eba )]
public partial class McGuffin : ExcelRow
{
    
    public LazyRow< McGuffinUIData > UIData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        UIData = new LazyRow< McGuffinUIData >( gameData, parser.ReadOffset< byte >( 0 ), language );
        

    }
}
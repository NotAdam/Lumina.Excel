// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "StainTransient", columnHash: 0x5d58cc84 )]
public partial class StainTransient : ExcelRow
{
    
    public LazyRow< Item > Item1 { get; private set; }
    public LazyRow< Item > Item2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item1 = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Item2 = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 4 ), language );
        

    }
}
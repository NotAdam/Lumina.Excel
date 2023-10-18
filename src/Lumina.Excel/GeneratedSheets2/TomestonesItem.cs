// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TomestonesItem", columnHash: 0xc8901190 )]
public partial class TomestonesItem : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< Tomestones > Tomestones { get; private set; }
    public sbyte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        Tomestones = new LazyRow< Tomestones >( gameData, parser.ReadOffset< int >( 4 ), language );
        Unknown0 = parser.ReadOffset< sbyte >( 8 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemSearchCategory", columnHash: 0x95df38b2 )]
public partial class ItemSearchCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public int Icon { get; private set; }
    public byte Category { get; private set; }
    public byte Order { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< int >( 4 );
        Category = parser.ReadOffset< byte >( 8 );
        Order = parser.ReadOffset< byte >( 9 );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< sbyte >( 10 ), language );
        Unknown0 = parser.ReadOffset< bool >( 11 );
        

    }
}
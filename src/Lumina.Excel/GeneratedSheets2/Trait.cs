// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Trait", columnHash: 0x82f2127d )]
public partial class Trait : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public int Icon { get; private set; }
    public short Value { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    public byte Level { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte Unknown7 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Icon = parser.ReadOffset< int >( 8 );
        Value = parser.ReadOffset< short >( 12 );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 14 ), language );
        Level = parser.ReadOffset< byte >( 15 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 16 ), language );
        Unknown7 = parser.ReadOffset< byte >( 17 );
        

    }
}
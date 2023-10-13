// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "YKW", columnHash: 0x12e24636 )]
public partial class YKW : ExcelRow
{
    
    public SeString Unknown8 { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< TerritoryType >[] Location { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown8 = parser.ReadOffset< SeString >( 0 );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 8 );
        Location = new LazyRow< TerritoryType >[6];
        for (int i = 0; i < 6; i++)
        	Location[i] = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( (ushort) ( 10 + i * 2 ) ), language );
        

    }
}
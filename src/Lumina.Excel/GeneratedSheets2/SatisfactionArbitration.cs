// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SatisfactionArbitration", columnHash: 0x3f77b2e9 )]
public partial class SatisfactionArbitration : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public byte SatisfactionLevel { get; private set; }
    public LazyRow< SatisfactionNpc > SatisfactionNpc { get; private set; }
    public byte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        SatisfactionLevel = parser.ReadOffset< byte >( 4 );
        SatisfactionNpc = new LazyRow< SatisfactionNpc >( gameData, parser.ReadOffset< byte >( 5 ), language );
        Unknown3 = parser.ReadOffset< byte >( 6 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AdventureExPhase", columnHash: 0x2ebeea9f )]
public partial class AdventureExPhase : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< Adventure > AdventureBegin { get; private set; }
    public LazyRow< Adventure > AdventureEnd { get; private set; }
    public uint Unknown4 { get; private set; }
    public LazyRow< ExVersion > Expansion { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        AdventureBegin = new LazyRow< Adventure >( gameData, parser.ReadOffset< uint >( 4 ), language );
        AdventureEnd = new LazyRow< Adventure >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Unknown4 = parser.ReadOffset< uint >( 12 );
        Expansion = new LazyRow< ExVersion >( gameData, parser.ReadOffset< byte >( 16 ), language );
        

    }
}
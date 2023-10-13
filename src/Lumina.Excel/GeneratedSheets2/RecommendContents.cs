// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RecommendContents", columnHash: 0xe79dd9d4 )]
public partial class RecommendContents : ExcelRow
{
    
    public LazyRow< Level > Level { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    public byte MinLevel { get; private set; }
    public byte MaxLevel { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Level = new LazyRow< Level >( gameData, parser.ReadOffset< int >( 0 ), language );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 4 ), language );
        MinLevel = parser.ReadOffset< byte >( 5 );
        MaxLevel = parser.ReadOffset< byte >( 6 );
        

    }
}
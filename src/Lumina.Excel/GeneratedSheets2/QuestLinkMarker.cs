// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestLinkMarker", columnHash: 0xea112ef0 )]
public partial class QuestLinkMarker : ExcelRow
{
    
    public LazyRow< Map > SourceMap { get; private set; }
    public LazyRow< Level > Level { get; private set; }
    public LazyRow< Map > TargetMap { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SourceMap = new LazyRow< Map >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Level = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( 4 ), language );
        TargetMap = new LazyRow< Map >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Unknown0 = parser.ReadOffset< byte >( 12 );
        Unknown1 = parser.ReadOffset< bool >( 13 );
        

    }
}
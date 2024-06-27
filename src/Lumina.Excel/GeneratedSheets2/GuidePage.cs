// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GuidePage", columnHash: 0x7fcd4e75 )]
public partial class GuidePage : ExcelRow
{
    
    public ILazyRow Output { get; private set; }
    public byte Key { get; private set; }
    public bool Unknown_70 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        var OutputRowId = parser.ReadOffset< uint >( 0 );
        Key = parser.ReadOffset< byte >( 4 );
        Unknown_70 = parser.ReadOffset< bool >( 5 );
        
        Output = Key switch
        {
        	1 => new LazyRow< GuidePageString >( gameData, OutputRowId, language ),
        	2 => new LazyRow< GuidePageString >( gameData, OutputRowId, language ),
        	4 => new LazyRow< GuidePageString >( gameData, OutputRowId, language ),
        	5 => new LazyRow< GuidePageString >( gameData, OutputRowId, language ),
        	6 => new LazyRow< GuidePageString >( gameData, OutputRowId, language ),
        	_ => new EmptyLazyRow( (uint) OutputRowId ),
        };
    }
}
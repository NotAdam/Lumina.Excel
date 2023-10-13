// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GuidePage", columnHash: 0x5bfa8a4e )]
public partial class GuidePage : ExcelRow
{
    
    public ILazyRow Output { get; private set; }
    public byte Key { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        var OutputRowId = parser.ReadOffset< uint >( 0 );
        Key = parser.ReadOffset< byte >( 4 );
        
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
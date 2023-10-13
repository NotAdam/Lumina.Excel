// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BannerTimeline", columnHash: 0xdb953b5e )]
public partial class BannerTimeline : ExcelRow
{
    
    public SeString Name { get; private set; }
    public ILazyRow AdditionalData { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< BannerCondition > UnlockCondition { get; private set; }
    public ushort SortKey { get; private set; }
    public byte Type { get; private set; }
    public LazyRow< ClassJobCategory > AcceptClassJobCategory { get; private set; }
    public byte Category { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        var AdditionalDataRowId = parser.ReadOffset< uint >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        SortKey = parser.ReadOffset< ushort >( 14 );
        Type = parser.ReadOffset< byte >( 16 );
        AcceptClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 17 ), language );
        Category = parser.ReadOffset< byte >( 18 );
        
        AdditionalData = Type switch
        {
        	2 => new LazyRow< Action >( gameData, AdditionalDataRowId, language ),
        	11 => new LazyRow< Emote >( gameData, AdditionalDataRowId, language ),
        	20 => new LazyRow< ActionTimeline >( gameData, AdditionalDataRowId, language ),
        	_ => new EmptyLazyRow( (uint) AdditionalDataRowId ),
        };
    }
}
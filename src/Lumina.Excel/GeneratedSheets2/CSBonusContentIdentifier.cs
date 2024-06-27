// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CSBonusContentIdentifier", columnHash: 0xe981d72a )]
public partial class CSBonusContentIdentifier : ExcelRow
{
    
    public ILazyRow Content { get; private set; }
    public LazyRow< Quest > UnlockQuest0 { get; private set; }
    public LazyRow< Quest > UnlockQuest1 { get; private set; }
    public LazyRow< Quest > UnlockQuest2 { get; private set; }
    public uint Unknown6 { get; private set; }
    public ILazyRow Map { get; private set; }
    public byte ContentLinkType { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        var ContentRowId = parser.ReadOffset< uint >( 0 );
        UnlockQuest0 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        UnlockQuest1 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 8 ), language );
        UnlockQuest2 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 12 ), language );
        Unknown6 = parser.ReadOffset< uint >( 16 );
        var MapRowId = parser.ReadOffset< uint >( 20 );
        ContentLinkType = parser.ReadOffset< byte >( 24 );
        Unknown2 = parser.ReadOffset< bool >( 25 );
        
        Content = ContentLinkType switch
        {
        	1 => new LazyRow< InstanceContent >( gameData, ContentRowId, language ),
        	2 => new LazyRow< GoldSaucerContent >( gameData, ContentRowId, language ),
        	3 => new LazyRow< TerritoryType >( gameData, ContentRowId, language ),
        	4 => new LazyRow< MobHuntOrderType >( gameData, ContentRowId, language ),
        	5 => new LazyRow< TreasureHuntRank >( gameData, ContentRowId, language ),
        	6 => new LazyRow< FishParameter >( gameData, ContentRowId, language ),
        	7 => new LazyRow< ENpcResident >( gameData, ContentRowId, language ),
        	_ => new EmptyLazyRow( (uint) ContentRowId ),
        };
        Map = ContentLinkType switch
        {
        	1 => new LazyRow< Level >( gameData, MapRowId, language ),
        	2 => new LazyRow< Level >( gameData, MapRowId, language ),
        	3 => new LazyRow< Fate >( gameData, MapRowId, language ),
        	4 => new LazyRow< Level >( gameData, MapRowId, language ),
        	7 => new LazyRow< Level >( gameData, MapRowId, language ),
        	_ => new EmptyLazyRow( (uint) MapRowId ),
        };
    }
}
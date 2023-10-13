// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BannerCondition", columnHash: 0x363466df )]
public partial class BannerCondition : ExcelRow
{
    
    public ILazyRow[] UnlockCriteria1 { get; private set; }
    public ILazyRow UnlockCriteria2 { get; private set; }
    public ILazyRow UnlockCriteria3 { get; private set; }
    public ILazyRow UnlockCriteria4 { get; private set; }
    public ILazyRow Prerequisite { get; private set; }
    public byte UnlockType1 { get; private set; }
    public byte UnlockType2 { get; private set; }
    public byte PrerequisiteType { get; private set; }
    public LazyRow< BannerObtainHintType > UnlockHint { get; private set; }
    public bool Unknown14 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        var UnlockCriteria1 = new ILazyRow[ 6 ];
        UIntSpan UnlockCriteria1RowId = stackalloc uint[ 6 ];
        for( int i = 0; i < 6; i++ )
        {
        	UnlockCriteria1RowId[ i ] = (uint) parser.ReadOffset< int >( 0 + ( i * 4 ) );
        }
        var UnlockCriteria2RowId = parser.ReadOffset< uint >( 24 );
        var UnlockCriteria3RowId = parser.ReadOffset< uint >( 28 );
        var UnlockCriteria4RowId = parser.ReadOffset< uint >( 32 );
        var PrerequisiteRowId = parser.ReadOffset< uint >( 36 );
        UnlockType1 = parser.ReadOffset< byte >( 40 );
        UnlockType2 = parser.ReadOffset< byte >( 41 );
        PrerequisiteType = parser.ReadOffset< byte >( 42 );
        UnlockHint = new LazyRow< BannerObtainHintType >( gameData, parser.ReadOffset< byte >( 43 ), language );
        Unknown14 = parser.ReadOffset< bool >( 44 );
        
        for( int i = 0; i < 6; i++ )
        {
        	UnlockCriteria1[ i ] = UnlockType1 switch
        	{
        		1 => new LazyRow< Quest >( gameData, UnlockCriteria1RowId[i], language ),
        		4 => new LazyRow< ContentFinderCondition >( gameData, UnlockCriteria1RowId[i], language ),
        		5 => new LazyRow< Emote >( gameData, UnlockCriteria1RowId[i], language ),
        		6 => new LazyRow< Companion >( gameData, UnlockCriteria1RowId[i], language ),
        		_ => new EmptyLazyRow( (uint) UnlockCriteria1RowId[i] ),
        	};
        }
        UnlockCriteria2 = UnlockType2 switch
        {
        	2 => new LazyRow< Quest >( gameData, UnlockCriteria2RowId, language ),
        	4 => new LazyRow< ENpcResident >( gameData, UnlockCriteria2RowId, language ),
        	5 => new LazyRow< Item >( gameData, UnlockCriteria2RowId, language ),
        	6 => new LazyRow< Item >( gameData, UnlockCriteria2RowId, language ),
        	7 => new LazyRow< Item >( gameData, UnlockCriteria2RowId, language ),
        	8 => new LazyRow< Item >( gameData, UnlockCriteria2RowId, language ),
        	11 => new LazyRow< Achievement >( gameData, UnlockCriteria2RowId, language ),
        	12 => new LazyRow< Item >( gameData, UnlockCriteria2RowId, language ),
        	13 => new LazyRow< ENpcBase >( gameData, UnlockCriteria2RowId, language ),
        	21 => new LazyRow< ENpcBase >( gameData, UnlockCriteria2RowId, language ),
        	_ => new EmptyLazyRow( (uint) UnlockCriteria2RowId ),
        };
        UnlockCriteria3 = UnlockType2 switch
        {
        	4 => new LazyRow< Level >( gameData, UnlockCriteria3RowId, language ),
        	13 => new LazyRow< Level >( gameData, UnlockCriteria3RowId, language ),
        	21 => new LazyRow< Level >( gameData, UnlockCriteria3RowId, language ),
        	_ => new EmptyLazyRow( (uint) UnlockCriteria3RowId ),
        };
        UnlockCriteria4 = UnlockType2 switch
        {
        	4 => new LazyRow< Item >( gameData, UnlockCriteria4RowId, language ),
        	21 => new LazyRow< Item >( gameData, UnlockCriteria4RowId, language ),
        	_ => new EmptyLazyRow( (uint) UnlockCriteria4RowId ),
        };
        Prerequisite = PrerequisiteType switch
        {
        	1 => new LazyRow< Quest >( gameData, PrerequisiteRowId, language ),
        	3 => new LazyRow< ContentFinderCondition >( gameData, PrerequisiteRowId, language ),
        	4 => new LazyRow< ContentFinderCondition >( gameData, PrerequisiteRowId, language ),
        	_ => new EmptyLazyRow( (uint) PrerequisiteRowId ),
        };
    }
}
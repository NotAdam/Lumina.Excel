// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Achievement", columnHash: 0x6cfd2977 )]
public partial class Achievement : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public ILazyRow Key { get; private set; }
    public ILazyRow[] Data { get; private set; }
    public LazyRow< Title > Title { get; private set; }
    public ushort Icon { get; private set; }
    public ushort Order { get; private set; }
    public LazyRow< AchievementCategory > AchievementCategory { get; private set; }
    public LazyRow< AchievementTarget > AchievementTarget { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Points { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Type { get; private set; }
    public byte Unknown24 { get; private set; }
    public LazyRow< AchievementHideCondition > AchievementHideCondition { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        var KeyRowId = parser.ReadOffset< int >( 12 );
        var Data = new ILazyRow[ 8 ];
        UIntSpan DataRowId = stackalloc uint[ 8 ];
        for( int i = 0; i < 8; i++ )
        {
        	DataRowId[ i ] = (uint) parser.ReadOffset< int >( 16 + ( i * 4 ) );
        }
        Title = new LazyRow< Title >( gameData, parser.ReadOffset< ushort >( 48 ), language );
        Icon = parser.ReadOffset< ushort >( 50 );
        Order = parser.ReadOffset< ushort >( 52 );
        AchievementCategory = new LazyRow< AchievementCategory >( gameData, parser.ReadOffset< byte >( 54 ), language );
        AchievementTarget = new LazyRow< AchievementTarget >( gameData, parser.ReadOffset< byte >( 55 ), language );
        Unknown4 = parser.ReadOffset< byte >( 56 );
        Points = parser.ReadOffset< byte >( 57 );
        Unknown8 = parser.ReadOffset< byte >( 58 );
        Unknown9 = parser.ReadOffset< byte >( 59 );
        Unknown10 = parser.ReadOffset< byte >( 60 );
        Unknown12 = parser.ReadOffset< byte >( 61 );
        Type = parser.ReadOffset< byte >( 62 );
        Unknown24 = parser.ReadOffset< byte >( 63 );
        AchievementHideCondition = new LazyRow< AchievementHideCondition >( gameData, parser.ReadOffset< byte >( 64 ), language );
        
        Key = Type switch
        {
        	2 => new LazyRow< Achievement >( gameData, KeyRowId, language ),
        	3 => new LazyRow< ClassJob >( gameData, KeyRowId, language ),
        	6 => new LazyRow< Quest >( gameData, KeyRowId, language ),
        	7 => new LazyRow< ClassJob >( gameData, KeyRowId, language ),
        	8 => new LazyRow< Map >( gameData, KeyRowId, language ),
        	9 => new LazyRow< Quest >( gameData, KeyRowId, language ),
        	11 => new LazyRow< GrandCompany >( gameData, KeyRowId, language ),
        	14 => new LazyRow< InstanceContent >( gameData, KeyRowId, language ),
        	15 => new LazyRow< BeastTribe >( gameData, KeyRowId, language ),
        	18 => new LazyRow< GrandCompany >( gameData, KeyRowId, language ),
        	20 => new LazyRow< AetherCurrentCompFlgSet >( gameData, KeyRowId, language ),
        	24 => new LazyRow< Quest >( gameData, KeyRowId, language ),
        	_ => new EmptyLazyRow( (uint) KeyRowId ),
        };
        for( int i = 0; i < 8; i++ )
        {
        	Data[ i ] = Type switch
        	{
        		2 => new LazyRow< Achievement >( gameData, DataRowId[i], language ),
        		6 => new LazyRow< Quest >( gameData, DataRowId[i], language ),
        		9 => new LazyRow< Quest >( gameData, DataRowId[i], language ),
        		15 => new LazyRow< BeastReputationRank >( gameData, DataRowId[i], language ),
        		20 => new LazyRow< AetherCurrentCompFlgSet >( gameData, DataRowId[i], language ),
        		24 => EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, DataRowId[i], language, "ClassJob", "Quest" ),
        		_ => new EmptyLazyRow( (uint) DataRowId[i] ),
        	};
        }
    }
}
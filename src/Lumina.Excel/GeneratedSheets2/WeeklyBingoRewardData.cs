// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeeklyBingoRewardData", columnHash: 0x02b099a0 )]
public partial class WeeklyBingoRewardData : ExcelRow
{
    
    public uint RewardItem1 { get; private set; }
    public ILazyRow RewardItem2 { get; private set; }
    public ILazyRow RewardItem3 { get; private set; }
    public ushort RewardQuantity1 { get; private set; }
    public ushort RewardQuantity2 { get; private set; }
    public ushort RewardQuantity3 { get; private set; }
    public byte RewardType1 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte RewardType2 { get; private set; }
    public byte RewardType3 { get; private set; }
    public bool RewardHq2 { get; private set; }
    public bool RewardHq3 { get; private set; }
    public bool RewardHq1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        RewardItem1 = parser.ReadOffset< uint >( 0 );
        var RewardItem2RowId = parser.ReadOffset< uint >( 4 );
        var RewardItem3RowId = parser.ReadOffset< uint >( 8 );
        RewardQuantity1 = parser.ReadOffset< ushort >( 12 );
        RewardQuantity2 = parser.ReadOffset< ushort >( 14 );
        RewardQuantity3 = parser.ReadOffset< ushort >( 16 );
        RewardType1 = parser.ReadOffset< byte >( 18 );
        Unknown0 = parser.ReadOffset< byte >( 19 );
        RewardType2 = parser.ReadOffset< byte >( 20 );
        RewardType3 = parser.ReadOffset< byte >( 21 );
        RewardHq2 = parser.ReadOffset< bool >( 22 );
        RewardHq3 = parser.ReadOffset< bool >( 23 );
        RewardHq1 = parser.ReadOffset< bool >( 24 );
        
        RewardItem2 = RewardType2 switch
        {
        	1 => new LazyRow< Item >( gameData, RewardItem2RowId, language ),
        	2 => new LazyRow< Tomestones >( gameData, RewardItem2RowId, language ),
        	_ => new EmptyLazyRow( (uint) RewardItem2RowId ),
        };
        RewardItem3 = RewardType3 switch
        {
        	1 => new LazyRow< Item >( gameData, RewardItem3RowId, language ),
        	2 => new LazyRow< Tomestones >( gameData, RewardItem3RowId, language ),
        	_ => new EmptyLazyRow( (uint) RewardItem3RowId ),
        };
    }
}
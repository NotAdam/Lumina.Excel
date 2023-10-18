// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestClassJobReward", columnHash: 0x3d96093f )]
public partial class QuestClassJobReward : ExcelRow
{
    
    public LazyRow< Item >[] RewardItem { get; private set; }
    public LazyRow< Item >[] RequiredItem { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte[] RewardAmount { get; private set; }
    public byte[] RequiredAmount { get; private set; }
    public bool Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        RewardItem = new LazyRow< Item >[4];
        for (int i = 0; i < 4; i++)
        	RewardItem[i] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) ( 0 + i * 4 ) ), language );
        RequiredItem = new LazyRow< Item >[4];
        for (int i = 0; i < 4; i++)
        	RequiredItem[i] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) ( 16 + i * 4 ) ), language );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 32 ), language );
        RewardAmount = new byte[4];
        for (int i = 0; i < 4; i++)
        	RewardAmount[i] = parser.ReadOffset< byte >( 33 + i * 1 );
        RequiredAmount = new byte[4];
        for (int i = 0; i < 4; i++)
        	RequiredAmount[i] = parser.ReadOffset< byte >( 37 + i * 1 );
        Unknown0 = parser.ReadOffset< bool >( 41 );
        Unknown1 = parser.ReadOffset< bool >( 42 );
        Unknown2 = parser.ReadOffset< bool >( 43 );
        Unknown3 = parser.ReadOffset< bool >( 44 );
        Unknown4 = parser.ReadOffset< bool >( 45 );
        Unknown5 = parser.ReadOffset< bool >( 46 );
        Unknown6 = parser.ReadOffset< bool >( 47 );
        Unknown7 = parser.ReadOffset< bool >( 48 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringLeve", columnHash: 0xfa74e4d0 )]
public partial class GatheringLeve : ExcelRow
{
    
    public LazyRow< GatheringLeveRoute >[] Route { get; private set; }
    public LazyRow< EventItem >[] RequiredItem { get; private set; }
    public LazyRow< GatheringLeveRule > Rule { get; private set; }
    public LazyRow< GatheringLeveBNpcEntry > BNpcEntry { get; private set; }
    public ushort[] Objective { get; private set; }
    public byte[] RequiredItemQuantity { get; private set; }
    public byte ItemNumber { get; private set; }
    public byte Varient { get; private set; }
    public bool UseSecondaryTool { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Route = new LazyRow< GatheringLeveRoute >[4];
        for (int i = 0; i < 4; i++)
        	Route[i] = new LazyRow< GatheringLeveRoute >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        RequiredItem = new LazyRow< EventItem >[4];
        for (int i = 0; i < 4; i++)
        	RequiredItem[i] = new LazyRow< EventItem >( gameData, parser.ReadOffset< int >( (ushort) ( 16 + i * 4 ) ), language );
        Rule = new LazyRow< GatheringLeveRule >( gameData, parser.ReadOffset< int >( 32 ), language );
        BNpcEntry = new LazyRow< GatheringLeveBNpcEntry >( gameData, parser.ReadOffset< int >( 36 ), language );
        Objective = new ushort[2];
        for (int i = 0; i < 2; i++)
        	Objective[i] = parser.ReadOffset< ushort >( 40 + i * 2 );
        RequiredItemQuantity = new byte[4];
        for (int i = 0; i < 4; i++)
        	RequiredItemQuantity[i] = parser.ReadOffset< byte >( 44 + i * 1 );
        ItemNumber = parser.ReadOffset< byte >( 48 );
        Varient = parser.ReadOffset< byte >( 49 );
        UseSecondaryTool = parser.ReadOffset< bool >( 50 );
        

    }
}
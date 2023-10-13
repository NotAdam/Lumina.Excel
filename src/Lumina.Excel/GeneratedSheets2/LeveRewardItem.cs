// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "LeveRewardItem", columnHash: 0x00035bbe )]
public partial class LeveRewardItem : ExcelRow
{
    
    public LazyRow< LeveRewardItemGroup >[] LeveRewardItemGroup { get; private set; }
    public byte[] ProbabilityPercent { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LeveRewardItemGroup = new LazyRow< LeveRewardItemGroup >[8];
        for (int i = 0; i < 8; i++)
        	LeveRewardItemGroup[i] = new LazyRow< LeveRewardItemGroup >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        ProbabilityPercent = new byte[8];
        for (int i = 0; i < 8; i++)
        	ProbabilityPercent[i] = parser.ReadOffset< byte >( 16 + i * 1 );
        

    }
}
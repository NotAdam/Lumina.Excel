// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentRouletteRoleBonus", columnHash: 0x8c1eab22 )]
public partial class ContentRouletteRoleBonus : ExcelRow
{
    
    public LazyRow< Item > ItemRewardType { get; private set; }
    public uint Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public byte RewardAmount { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ItemRewardType = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        Unknown1 = parser.ReadOffset< ushort >( 8 );
        Unknown2 = parser.ReadOffset< ushort >( 10 );
        Unknown3 = parser.ReadOffset< ushort >( 12 );
        Unknown4 = parser.ReadOffset< ushort >( 14 );
        Unknown5 = parser.ReadOffset< ushort >( 16 );
        Unknown6 = parser.ReadOffset< ushort >( 18 );
        RewardAmount = parser.ReadOffset< byte >( 20 );
        Unknown7 = parser.ReadOffset< byte >( 21 );
        Unknown8 = parser.ReadOffset< byte >( 22 );
        Unknown9 = parser.ReadOffset< byte >( 23 );
        

    }
}
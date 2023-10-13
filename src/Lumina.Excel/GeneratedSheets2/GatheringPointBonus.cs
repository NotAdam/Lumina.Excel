// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringPointBonus", columnHash: 0xcd832c29 )]
public partial class GatheringPointBonus : ExcelRow
{
    
    public uint ConditionValue { get; private set; }
    public uint Unknown7 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort BonusValue { get; private set; }
    public ushort Unknown5 { get; private set; }
    public LazyRow< GatheringCondition > Condition { get; private set; }
    public LazyRow< GatheringPointBonusType > BonusType { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ConditionValue = parser.ReadOffset< uint >( 0 );
        Unknown7 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        BonusValue = parser.ReadOffset< ushort >( 10 );
        Unknown5 = parser.ReadOffset< ushort >( 12 );
        Condition = new LazyRow< GatheringCondition >( gameData, parser.ReadOffset< byte >( 14 ), language );
        BonusType = new LazyRow< GatheringPointBonusType >( gameData, parser.ReadOffset< byte >( 15 ), language );
        Unknown6 = parser.ReadOffset< bool >( 16 );
        

    }
}
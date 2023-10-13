// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanionTransient", columnHash: 0xea0b06cf )]
public partial class CompanionTransient : ExcelRow
{
    
    public SeString Description { get; private set; }
    public SeString DescriptionEnhanced { get; private set; }
    public SeString Tooltip { get; private set; }
    public SeString SpecialActionName { get; private set; }
    public SeString SpecialActionDescription { get; private set; }
    public byte Attack { get; private set; }
    public byte Defense { get; private set; }
    public byte Speed { get; private set; }
    public LazyRow< MinionSkillType > MinionSkillType { get; private set; }
    public bool HasAreaAttack { get; private set; }
    public bool StrengthGate { get; private set; }
    public bool StrengthEye { get; private set; }
    public bool StrengthShield { get; private set; }
    public bool StrengthArcana { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Description = parser.ReadOffset< SeString >( 0 );
        DescriptionEnhanced = parser.ReadOffset< SeString >( 4 );
        Tooltip = parser.ReadOffset< SeString >( 8 );
        SpecialActionName = parser.ReadOffset< SeString >( 12 );
        SpecialActionDescription = parser.ReadOffset< SeString >( 16 );
        Attack = parser.ReadOffset< byte >( 20 );
        Defense = parser.ReadOffset< byte >( 21 );
        Speed = parser.ReadOffset< byte >( 22 );
        MinionSkillType = new LazyRow< MinionSkillType >( gameData, parser.ReadOffset< byte >( 23 ), language );
        HasAreaAttack = parser.ReadOffset< bool >( 24 );
        StrengthGate = parser.ReadOffset< bool >( 24, 2 );
        StrengthEye = parser.ReadOffset< bool >( 24, 4 );
        StrengthShield = parser.ReadOffset< bool >( 24, 8 );
        StrengthArcana = parser.ReadOffset< bool >( 24, 16 );
        

    }
}
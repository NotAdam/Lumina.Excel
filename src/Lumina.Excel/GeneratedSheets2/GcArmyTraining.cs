// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GcArmyTraining", columnHash: 0x274780bb )]
public partial class GcArmyTraining : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public uint Experience { get; private set; }
    public sbyte PhysicalBonus { get; private set; }
    public sbyte MentalBonus { get; private set; }
    public sbyte TacticalBonus { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Experience = parser.ReadOffset< uint >( 8 );
        PhysicalBonus = parser.ReadOffset< sbyte >( 12 );
        MentalBonus = parser.ReadOffset< sbyte >( 13 );
        TacticalBonus = parser.ReadOffset< sbyte >( 14 );
        

    }
}
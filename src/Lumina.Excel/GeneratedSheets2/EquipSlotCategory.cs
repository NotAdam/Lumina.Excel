// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EquipSlotCategory", columnHash: 0xf4ab6454 )]
public partial class EquipSlotCategory : ExcelRow
{
    
    public sbyte MainHand { get; private set; }
    public sbyte OffHand { get; private set; }
    public sbyte Head { get; private set; }
    public sbyte Body { get; private set; }
    public sbyte Gloves { get; private set; }
    public sbyte Waist { get; private set; }
    public sbyte Legs { get; private set; }
    public sbyte Feet { get; private set; }
    public sbyte Ears { get; private set; }
    public sbyte Neck { get; private set; }
    public sbyte Wrists { get; private set; }
    public sbyte FingerL { get; private set; }
    public sbyte FingerR { get; private set; }
    public sbyte SoulCrystal { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        MainHand = parser.ReadOffset< sbyte >( 0 );
        OffHand = parser.ReadOffset< sbyte >( 1 );
        Head = parser.ReadOffset< sbyte >( 2 );
        Body = parser.ReadOffset< sbyte >( 3 );
        Gloves = parser.ReadOffset< sbyte >( 4 );
        Waist = parser.ReadOffset< sbyte >( 5 );
        Legs = parser.ReadOffset< sbyte >( 6 );
        Feet = parser.ReadOffset< sbyte >( 7 );
        Ears = parser.ReadOffset< sbyte >( 8 );
        Neck = parser.ReadOffset< sbyte >( 9 );
        Wrists = parser.ReadOffset< sbyte >( 10 );
        FingerL = parser.ReadOffset< sbyte >( 11 );
        FingerR = parser.ReadOffset< sbyte >( 12 );
        SoulCrystal = parser.ReadOffset< sbyte >( 13 );
        

    }
}
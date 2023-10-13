// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BaseParam", columnHash: 0x8568afe3 )]
public partial class BaseParam : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public ushort OneHandWeaponPercent { get; private set; }
    public ushort OffHandPercent { get; private set; }
    public ushort HeadPercent { get; private set; }
    public ushort ChestPercent { get; private set; }
    public ushort HandsPercent { get; private set; }
    public ushort WaistPercent { get; private set; }
    public ushort LegsPercent { get; private set; }
    public ushort FeetPercent { get; private set; }
    public ushort EarringPercent { get; private set; }
    public ushort NecklacePercent { get; private set; }
    public ushort BraceletPercent { get; private set; }
    public ushort RingPercent { get; private set; }
    public ushort TwoHandWeaponPercent { get; private set; }
    public ushort UnderArmorPercent { get; private set; }
    public ushort ChestHeadPercent { get; private set; }
    public ushort ChestHeadLegsFeetPercent { get; private set; }
    public ushort Unknown20 { get; private set; }
    public ushort LegsFeetPercent { get; private set; }
    public ushort HeadChestHandsLegsFeetPercent { get; private set; }
    public ushort ChestLegsGlovesPercent { get; private set; }
    public ushort ChestLegsFeetPercent { get; private set; }
    public ushort Unknown25 { get; private set; }
    public byte OrderPriority { get; private set; }
    public byte[] MeldParam { get; private set; }
    public sbyte PacketIndex { get; private set; }
    public bool Unknown39 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        OneHandWeaponPercent = parser.ReadOffset< ushort >( 8 );
        OffHandPercent = parser.ReadOffset< ushort >( 10 );
        HeadPercent = parser.ReadOffset< ushort >( 12 );
        ChestPercent = parser.ReadOffset< ushort >( 14 );
        HandsPercent = parser.ReadOffset< ushort >( 16 );
        WaistPercent = parser.ReadOffset< ushort >( 18 );
        LegsPercent = parser.ReadOffset< ushort >( 20 );
        FeetPercent = parser.ReadOffset< ushort >( 22 );
        EarringPercent = parser.ReadOffset< ushort >( 24 );
        NecklacePercent = parser.ReadOffset< ushort >( 26 );
        BraceletPercent = parser.ReadOffset< ushort >( 28 );
        RingPercent = parser.ReadOffset< ushort >( 30 );
        TwoHandWeaponPercent = parser.ReadOffset< ushort >( 32 );
        UnderArmorPercent = parser.ReadOffset< ushort >( 34 );
        ChestHeadPercent = parser.ReadOffset< ushort >( 36 );
        ChestHeadLegsFeetPercent = parser.ReadOffset< ushort >( 38 );
        Unknown20 = parser.ReadOffset< ushort >( 40 );
        LegsFeetPercent = parser.ReadOffset< ushort >( 42 );
        HeadChestHandsLegsFeetPercent = parser.ReadOffset< ushort >( 44 );
        ChestLegsGlovesPercent = parser.ReadOffset< ushort >( 46 );
        ChestLegsFeetPercent = parser.ReadOffset< ushort >( 48 );
        Unknown25 = parser.ReadOffset< ushort >( 50 );
        OrderPriority = parser.ReadOffset< byte >( 52 );
        MeldParam = new byte[13];
        for (int i = 0; i < 13; i++)
        	MeldParam[i] = parser.ReadOffset< byte >( 53 + i * 1 );
        PacketIndex = parser.ReadOffset< sbyte >( 66 );
        Unknown39 = parser.ReadOffset< bool >( 67 );
        

    }
}
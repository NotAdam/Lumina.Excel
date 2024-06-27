// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Pet", columnHash: 0x9416a25d )]
public partial class Pet : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< Action >[] Abilities { get; private set; }
    public LazyRow< Action > AutoAction { get; private set; }
    public byte SmallScalePercentage { get; private set; }
    public byte MediumScalePercentage { get; private set; }
    public byte LargeScalePercentage { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public sbyte Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool NonCombatSummon { get; private set; }
    public bool Unknown17 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Abilities = new LazyRow< Action >[4];
        for (int i = 0; i < 4; i++)
        	Abilities[i] = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( (ushort) ( 4 + i * 2 ) ), language );
        AutoAction = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        SmallScalePercentage = parser.ReadOffset< byte >( 14 );
        MediumScalePercentage = parser.ReadOffset< byte >( 15 );
        LargeScalePercentage = parser.ReadOffset< byte >( 16 );
        Unknown8 = parser.ReadOffset< byte >( 17 );
        Unknown9 = parser.ReadOffset< byte >( 18 );
        Unknown10 = parser.ReadOffset< byte >( 19 );
        Unknown11 = parser.ReadOffset< byte >( 20 );
        Unknown12 = parser.ReadOffset< byte >( 21 );
        Unknown13 = parser.ReadOffset< byte >( 22 );
        Unknown14 = parser.ReadOffset< sbyte >( 23 );
        Unknown15 = parser.ReadOffset< bool >( 24 );
        NonCombatSummon = parser.ReadOffset< bool >( 24, 2 );
        Unknown17 = parser.ReadOffset< bool >( 24, 4 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AOZContentBriefingBNpc", columnHash: 0xfc0810d7 )]
public partial class AOZContentBriefingBNpc : ExcelRow
{
    
    public LazyRow< BNpcName > BNpcName { get; private set; }
    public uint TargetSmall { get; private set; }
    public uint TargetLarge { get; private set; }
    public byte Endurance { get; private set; }
    public byte Fire { get; private set; }
    public byte Ice { get; private set; }
    public byte Wind { get; private set; }
    public byte Earth { get; private set; }
    public byte Thunder { get; private set; }
    public byte Water { get; private set; }
    public byte Slashing { get; private set; }
    public byte Piercing { get; private set; }
    public byte Blunt { get; private set; }
    public byte Magic { get; private set; }
    public bool HideStats { get; private set; }
    public bool SlowVuln { get; private set; }
    public bool PetrificationVuln { get; private set; }
    public bool ParalysisVuln { get; private set; }
    public bool InterruptionVuln { get; private set; }
    public bool BlindVuln { get; private set; }
    public bool StunVuln { get; private set; }
    public bool SleepVuln { get; private set; }
    public bool BindVuln { get; private set; }
    public bool HeavyVuln { get; private set; }
    public bool FlatOrDeathVuln { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< uint >( 0 ), language );
        TargetSmall = parser.ReadOffset< uint >( 4 );
        TargetLarge = parser.ReadOffset< uint >( 8 );
        Endurance = parser.ReadOffset< byte >( 12 );
        Fire = parser.ReadOffset< byte >( 13 );
        Ice = parser.ReadOffset< byte >( 14 );
        Wind = parser.ReadOffset< byte >( 15 );
        Earth = parser.ReadOffset< byte >( 16 );
        Thunder = parser.ReadOffset< byte >( 17 );
        Water = parser.ReadOffset< byte >( 18 );
        Slashing = parser.ReadOffset< byte >( 19 );
        Piercing = parser.ReadOffset< byte >( 20 );
        Blunt = parser.ReadOffset< byte >( 21 );
        Magic = parser.ReadOffset< byte >( 22 );
        HideStats = parser.ReadOffset< bool >( 23 );
        SlowVuln = parser.ReadOffset< bool >( 23, 2 );
        PetrificationVuln = parser.ReadOffset< bool >( 23, 4 );
        ParalysisVuln = parser.ReadOffset< bool >( 23, 8 );
        InterruptionVuln = parser.ReadOffset< bool >( 23, 16 );
        BlindVuln = parser.ReadOffset< bool >( 23, 32 );
        StunVuln = parser.ReadOffset< bool >( 23, 64 );
        SleepVuln = parser.ReadOffset< bool >( 23, 128 );
        BindVuln = parser.ReadOffset< bool >( 24 );
        HeavyVuln = parser.ReadOffset< bool >( 24, 2 );
        FlatOrDeathVuln = parser.ReadOffset< bool >( 24, 4 );
        

    }
}
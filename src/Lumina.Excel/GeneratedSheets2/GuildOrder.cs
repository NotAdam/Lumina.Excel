// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GuildOrder", columnHash: 0xbdf9fa30 )]
public partial class GuildOrder : ExcelRow
{
    
    public SeString Objective { get; private set; }
    public SeString Description1 { get; private set; }
    public SeString Description2 { get; private set; }
    public SeString Description3 { get; private set; }
    public uint CompletionBonusExp { get; private set; }
    public uint RewardExp { get; private set; }
    public uint CompletionBonusGil { get; private set; }
    public uint RewardGil { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public LazyRow< ENpcResident > ENpcName { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Objective = parser.ReadOffset< SeString >( 0 );
        Description1 = parser.ReadOffset< SeString >( 4 );
        Description2 = parser.ReadOffset< SeString >( 8 );
        Description3 = parser.ReadOffset< SeString >( 12 );
        CompletionBonusExp = parser.ReadOffset< uint >( 16 );
        RewardExp = parser.ReadOffset< uint >( 20 );
        CompletionBonusGil = parser.ReadOffset< uint >( 24 );
        RewardGil = parser.ReadOffset< uint >( 28 );
        Unknown0 = parser.ReadOffset< uint >( 32 );
        Unknown1 = parser.ReadOffset< uint >( 36 );
        Unknown2 = parser.ReadOffset< uint >( 40 );
        Unknown3 = parser.ReadOffset< uint >( 44 );
        Unknown4 = parser.ReadOffset< ushort >( 48 );
        Unknown5 = parser.ReadOffset< ushort >( 50 );
        Unknown6 = parser.ReadOffset< bool >( 52 );
        Unknown7 = parser.ReadOffset< bool >( 53 );
        ENpcName = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 56 ), language );
        

    }
}
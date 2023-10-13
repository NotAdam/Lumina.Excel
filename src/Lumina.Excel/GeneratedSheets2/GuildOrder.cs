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
    public uint Unknown9 { get; private set; }
    public uint Unknown10 { get; private set; }
    public uint Unknown11 { get; private set; }
    public uint Unknown12 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public ushort Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown16 { get; private set; }
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
        Unknown9 = parser.ReadOffset< uint >( 32 );
        Unknown10 = parser.ReadOffset< uint >( 36 );
        Unknown11 = parser.ReadOffset< uint >( 40 );
        Unknown12 = parser.ReadOffset< uint >( 44 );
        Unknown13 = parser.ReadOffset< ushort >( 48 );
        Unknown14 = parser.ReadOffset< ushort >( 50 );
        Unknown15 = parser.ReadOffset< bool >( 52 );
        Unknown16 = parser.ReadOffset< bool >( 53 );
        ENpcName = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 56 ), language );
        

    }
}
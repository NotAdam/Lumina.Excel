// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GcArmyExpedition", columnHash: 0x852cc288 )]
public partial class GcArmyExpedition : ExcelRow
{
    public struct ExpeditionParamsStruct
    {
    	public LazyRow< Item > RewardItem { get; internal set; }
    	public ushort RequiredPhysical { get; internal set; }
    	public ushort RequiredMental { get; internal set; }
    	public ushort RequiredTactical { get; internal set; }
    	public byte RewardQuantity { get; internal set; }
    	public byte PercentPhysicalMet { get; internal set; }
    	public byte PercentMentalMet { get; internal set; }
    	public byte PercentTacticalMet { get; internal set; }
    	public byte PercentAllMet { get; internal set; }
    }
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public ExpeditionParamsStruct[] ExpeditionParams { get; private set; }
    public uint RewardExperience { get; private set; }
    public ushort RequiredSeals { get; private set; }
    public byte RequiredFlag { get; private set; }
    public byte UnlockFlag { get; private set; }
    public byte RequiredLevel { get; private set; }
    public byte PercentBase { get; private set; }
    public byte Unknown0 { get; private set; }
    public LazyRow< GcArmyExpeditionType > GcArmyExpeditionType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        ExpeditionParams = new ExpeditionParamsStruct[6];
        for (int i = 0; i < 6; i++)
        {
        	ExpeditionParams[i].RewardItem = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) (i * 16 + 8) ), language );
        	ExpeditionParams[i].RequiredPhysical = parser.ReadOffset< ushort >( (ushort) (i * 16 + 12));
        	ExpeditionParams[i].RequiredMental = parser.ReadOffset< ushort >( (ushort) (i * 16 + 14));
        	ExpeditionParams[i].RequiredTactical = parser.ReadOffset< ushort >( (ushort) (i * 16 + 16));
        	ExpeditionParams[i].RewardQuantity = parser.ReadOffset< byte >( (ushort) (i * 16 + 18));
        	ExpeditionParams[i].PercentPhysicalMet = parser.ReadOffset< byte >( (ushort) (i * 16 + 19));
        	ExpeditionParams[i].PercentMentalMet = parser.ReadOffset< byte >( (ushort) (i * 16 + 20));
        	ExpeditionParams[i].PercentTacticalMet = parser.ReadOffset< byte >( (ushort) (i * 16 + 21));
        	ExpeditionParams[i].PercentAllMet = parser.ReadOffset< byte >( (ushort) (i * 16 + 22));
        }
        RewardExperience = parser.ReadOffset< uint >( 104 );
        RequiredSeals = parser.ReadOffset< ushort >( 108 );
        RequiredFlag = parser.ReadOffset< byte >( 110 );
        UnlockFlag = parser.ReadOffset< byte >( 111 );
        RequiredLevel = parser.ReadOffset< byte >( 112 );
        PercentBase = parser.ReadOffset< byte >( 113 );
        Unknown0 = parser.ReadOffset< byte >( 114 );
        GcArmyExpeditionType = new LazyRow< GcArmyExpeditionType >( gameData, parser.ReadOffset< byte >( 115 ), language );
        

    }
}
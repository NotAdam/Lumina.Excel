// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GCSupplyDutyReward", columnHash: 0x6be0e840 )]
public partial class GCSupplyDutyReward : ExcelRow
{
    
    public uint ExperienceSupply { get; private set; }
    public uint ExperienceProvisioning { get; private set; }
    public uint SealsExpertDelivery { get; private set; }
    public uint SealsSupply { get; private set; }
    public uint SealsProvisioning { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExperienceSupply = parser.ReadOffset< uint >( 0 );
        ExperienceProvisioning = parser.ReadOffset< uint >( 4 );
        SealsExpertDelivery = parser.ReadOffset< uint >( 8 );
        SealsSupply = parser.ReadOffset< uint >( 12 );
        SealsProvisioning = parser.ReadOffset< uint >( 16 );
        

    }
}
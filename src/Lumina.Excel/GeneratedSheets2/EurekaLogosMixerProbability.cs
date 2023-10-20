// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EurekaLogosMixerProbability", columnHash: 0xdcfd9eba )]
public partial class EurekaLogosMixerProbability : ExcelRow
{
    
    public byte ProbabilityPercent { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ProbabilityPercent = parser.ReadOffset< byte >( 0 );
        

    }
}
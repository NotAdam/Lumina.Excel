// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJICraftworksPopularityType", columnHash: 0xd870e208 )]
public partial class MJICraftworksPopularityType : ExcelRow
{
    
    public ushort Ratio { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Ratio = parser.ReadOffset< ushort >( 0 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJICraftworksPopularity", columnHash: 0x92a82168 )]
public partial class MJICraftworksPopularity : ExcelRow
{
    
    public LazyRow< MJICraftworksPopularityType >[] Popularity { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Popularity = new LazyRow< MJICraftworksPopularityType >[91];
        for (int i = 0; i < 91; i++)
        	Popularity[i] = new LazyRow< MJICraftworksPopularityType >( gameData, parser.ReadOffset< byte >( (ushort) ( 0 + i * 1 ) ), language );
        

    }
}
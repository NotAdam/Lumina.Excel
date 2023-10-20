// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FCReputation", columnHash: 0x3d6be37e )]
public partial class FCReputation : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint PointsToNext { get; private set; }
    public uint RequiredPoints { get; private set; }
    public LazyRow< UIColor > Color { get; private set; }
    public byte DiscountRate { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        PointsToNext = parser.ReadOffset< uint >( 4 );
        RequiredPoints = parser.ReadOffset< uint >( 8 );
        Color = new LazyRow< UIColor >( gameData, parser.ReadOffset< uint >( 12 ), language );
        DiscountRate = parser.ReadOffset< byte >( 16 );
        

    }
}
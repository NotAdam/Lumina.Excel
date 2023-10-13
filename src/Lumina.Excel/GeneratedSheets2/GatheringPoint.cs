// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringPoint", columnHash: 0x09006f05 )]
public partial class GatheringPoint : ExcelRow
{
    
    public LazyRow< GatheringPointBase > GatheringPointBase { get; private set; }
    public LazyRow< GatheringPointBonus >[] GatheringPointBonus { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public LazyRow< GatheringSubCategory > GatheringSubCategory { get; private set; }
    public byte Type { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Count { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GatheringPointBase = new LazyRow< GatheringPointBase >( gameData, parser.ReadOffset< int >( 0 ), language );
        GatheringPointBonus = new LazyRow< GatheringPointBonus >[2];
        for (int i = 0; i < 2; i++)
        	GatheringPointBonus[i] = new LazyRow< GatheringPointBonus >( gameData, parser.ReadOffset< ushort >( (ushort) ( 4 + i * 2 ) ), language );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        GatheringSubCategory = new LazyRow< GatheringSubCategory >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Type = parser.ReadOffset< byte >( 14 );
        Unknown1 = parser.ReadOffset< byte >( 15 );
        Count = parser.ReadOffset< byte >( 16 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingUnitedExterior", columnHash: 0x88a791a7 )]
public partial class HousingUnitedExterior : ExcelRow
{
    
    public LazyRow< HousingExterior > Roof { get; private set; }
    public LazyRow< HousingExterior > Walls { get; private set; }
    public LazyRow< HousingExterior > Windows { get; private set; }
    public LazyRow< HousingExterior > Door { get; private set; }
    public LazyRow< HousingExterior > OptionalRoof { get; private set; }
    public LazyRow< HousingExterior > OptionalWall { get; private set; }
    public LazyRow< HousingExterior > OptionalSignboard { get; private set; }
    public LazyRow< HousingExterior > Fence { get; private set; }
    public byte PlotSize { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Roof = new LazyRow< HousingExterior >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Walls = new LazyRow< HousingExterior >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Windows = new LazyRow< HousingExterior >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Door = new LazyRow< HousingExterior >( gameData, parser.ReadOffset< uint >( 12 ), language );
        OptionalRoof = new LazyRow< HousingExterior >( gameData, parser.ReadOffset< uint >( 16 ), language );
        OptionalWall = new LazyRow< HousingExterior >( gameData, parser.ReadOffset< uint >( 20 ), language );
        OptionalSignboard = new LazyRow< HousingExterior >( gameData, parser.ReadOffset< uint >( 24 ), language );
        Fence = new LazyRow< HousingExterior >( gameData, parser.ReadOffset< uint >( 28 ), language );
        PlotSize = parser.ReadOffset< byte >( 32 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboTaxiStand", columnHash: 0x233d23d9 )]
public partial class ChocoboTaxiStand : ExcelRow
{
    
    public SeString PlaceName { get; private set; }
    public LazyRow< ChocoboTaxi >[] TargetLocations { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        PlaceName = parser.ReadOffset< SeString >( 0 );
        TargetLocations = new LazyRow< ChocoboTaxi >[8];
        for (int i = 0; i < 8; i++)
        	TargetLocations[i] = new LazyRow< ChocoboTaxi >( gameData, parser.ReadOffset< ushort >( (ushort) ( 4 + i * 2 ) ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboRace", columnHash: 0xde74b4c4 )]
public partial class ChocoboRace : ExcelRow
{
    
    public LazyRow< ChocoboRaceRank > ChocoboRaceRank { get; private set; }
    public LazyRow< ChocoboRaceTerritory > ChocoboRaceTerritory { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ChocoboRaceRank = new LazyRow< ChocoboRaceRank >( gameData, parser.ReadOffset< byte >( 0 ), language );
        ChocoboRaceTerritory = new LazyRow< ChocoboRaceTerritory >( gameData, parser.ReadOffset< byte >( 1 ), language );
        

    }
}
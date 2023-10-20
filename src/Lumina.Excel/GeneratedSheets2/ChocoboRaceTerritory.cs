// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboRaceTerritory", columnHash: 0x39e8d543 )]
public partial class ChocoboRaceTerritory : ExcelRow
{
    
    public int Icon { get; private set; }
    public LazyRow< GoldSaucerTextData > Name { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< int >( 0 );
        Name = new LazyRow< GoldSaucerTextData >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        

    }
}
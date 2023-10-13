// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AetherCurrentCompFlgSet", columnHash: 0x39815af8 )]
public partial class AetherCurrentCompFlgSet : ExcelRow
{
    
    public LazyRow< TerritoryType > Territory { get; private set; }
    public LazyRow< AetherCurrent >[] AetherCurrents { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Territory = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< int >( 0 ), language );
        AetherCurrents = new LazyRow< AetherCurrent >[15];
        for (int i = 0; i < 15; i++)
        	AetherCurrents[i] = new LazyRow< AetherCurrent >( gameData, parser.ReadOffset< int >( (ushort) ( 4 + i * 4 ) ), language );
        

    }
}
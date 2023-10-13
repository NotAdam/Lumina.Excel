// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MobHuntTarget", columnHash: 0x83a7f541 )]
public partial class MobHuntTarget : ExcelRow
{
    
    public uint Icon { get; private set; }
    public LazyRow< BNpcName > Name { get; private set; }
    public LazyRow< Fate > FATE { get; private set; }
    public LazyRow< Map > TerritoryType { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< uint >( 0 );
        Name = new LazyRow< BNpcName >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        FATE = new LazyRow< Fate >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        TerritoryType = new LazyRow< Map >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        

    }
}
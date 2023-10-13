// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MonsterNoteTarget", columnHash: 0x4157404f )]
public partial class MonsterNoteTarget : ExcelRow
{
    
    public int Icon { get; private set; }
    public LazyRow< BNpcName > BNpcName { get; private set; }
    public LazyRow< PlaceName >[] PlaceNameZone { get; private set; }
    public LazyRow< PlaceName >[] PlaceNameLocation { get; private set; }
    public LazyRow< Town > Town { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< int >( 0 );
        BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        PlaceNameZone = new LazyRow< PlaceName >[3];
        for (int i = 0; i < 3; i++)
        	PlaceNameZone[i] = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( (ushort) ( 6 + i * 2 ) ), language );
        PlaceNameLocation = new LazyRow< PlaceName >[3];
        for (int i = 0; i < 3; i++)
        	PlaceNameLocation[i] = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( (ushort) ( 12 + i * 2 ) ), language );
        Town = new LazyRow< Town >( gameData, parser.ReadOffset< byte >( 18 ), language );
        

    }
}
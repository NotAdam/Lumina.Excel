// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GcArmyEquipPreset", columnHash: 0x5a4de23a )]
public partial class GcArmyEquipPreset : ExcelRow
{
    
    public LazyRow< Item > MainHand { get; private set; }
    public LazyRow< Item > OffHand { get; private set; }
    public LazyRow< Item > Head { get; private set; }
    public LazyRow< Item > Body { get; private set; }
    public LazyRow< Item > Gloves { get; private set; }
    public LazyRow< Item > Legs { get; private set; }
    public LazyRow< Item > Feet { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        MainHand = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        OffHand = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        Head = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 8 ), language );
        Body = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 12 ), language );
        Gloves = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 16 ), language );
        Legs = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 20 ), language );
        Feet = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 24 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BGMSituation", columnHash: 0x64a88f98 )]
public partial class BGMSituation : ExcelRow
{
    
    public LazyRow< BGM > DaytimeID { get; private set; }
    public LazyRow< BGM > NightID { get; private set; }
    public LazyRow< BGM > BattleID { get; private set; }
    public LazyRow< BGM > DaybreakID { get; private set; }
    public LazyRow< BGM > TwilightID { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        DaytimeID = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        NightID = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        BattleID = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        DaybreakID = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        TwilightID = new LazyRow< BGM >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        

    }
}
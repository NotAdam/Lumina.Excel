// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MobHuntOrderType", columnHash: 0x795a75a0 )]
public partial class MobHuntOrderType : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< EventItem > EventItem { get; private set; }
    public LazyRow< MobHuntOrder > OrderStart { get; private set; }
    public byte Type { get; private set; }
    public byte OrderAmount { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        EventItem = new LazyRow< EventItem >( gameData, parser.ReadOffset< uint >( 4 ), language );
        OrderStart = new LazyRow< MobHuntOrder >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Type = parser.ReadOffset< byte >( 10 );
        OrderAmount = parser.ReadOffset< byte >( 11 );
        

    }
}
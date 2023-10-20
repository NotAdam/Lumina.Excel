// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DynamicEventSingleBattle", columnHash: 0xe760c985 )]
public partial class DynamicEventSingleBattle : ExcelRow
{
    
    public SeString Text { get; private set; }
    public uint Icon { get; private set; }
    public LazyRow< BNpcName > BNpcName { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< int >( 8 ), language );
        

    }
}
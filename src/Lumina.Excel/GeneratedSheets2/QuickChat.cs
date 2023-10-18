// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuickChat", columnHash: 0x66d693c5 )]
public partial class QuickChat : ExcelRow
{
    
    public SeString NameAction { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< Addon > Addon { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< QuickChatTransient > QuickChatTransient { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NameAction = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< int >( 4 );
        Addon = new LazyRow< Addon >( gameData, parser.ReadOffset< int >( 8 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 12 );
        QuickChatTransient = new LazyRow< QuickChatTransient >( gameData, parser.ReadOffset< sbyte >( 14 ), language );
        

    }
}
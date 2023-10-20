// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemBarterCheck", columnHash: 0x8920dbd8 )]
public partial class ItemBarterCheck : ExcelRow
{
    
    public ILazyRow Question { get; private set; }
    public LazyRow< Addon > Confirm { get; private set; }
    public LazyRow< AddonTransient > Category { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Question = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 0 ), language, "LogMessage", "Addon" );
        Confirm = new LazyRow< Addon >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Category = new LazyRow< AddonTransient >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        

    }
}
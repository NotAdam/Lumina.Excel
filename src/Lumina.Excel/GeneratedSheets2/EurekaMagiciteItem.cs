// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EurekaMagiciteItem", columnHash: 0xbc638df5 )]
public partial class EurekaMagiciteItem : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< EurekaMagiciteItemType > EurekaMagiciteItemType { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        EurekaMagiciteItemType = new LazyRow< EurekaMagiciteItemType >( gameData, parser.ReadOffset< byte >( 4 ), language );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 5 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MYCTemporaryItem", columnHash: 0x9176820b )]
public partial class MYCTemporaryItem : ExcelRow
{
    
    public LazyRow< Action > Action { get; private set; }
    public LazyRow< MYCTemporaryItemUICategory > Category { get; private set; }
    public byte Type { get; private set; }
    public byte Max { get; private set; }
    public byte Weight { get; private set; }
    public byte Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Action = new LazyRow< Action >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Category = new LazyRow< MYCTemporaryItemUICategory >( gameData, parser.ReadOffset< byte >( 4 ), language );
        Type = parser.ReadOffset< byte >( 5 );
        Max = parser.ReadOffset< byte >( 6 );
        Weight = parser.ReadOffset< byte >( 7 );
        Order = parser.ReadOffset< byte >( 8 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AetherialWheel", columnHash: 0xfee5acb6 )]
public partial class AetherialWheel : ExcelRow
{
    
    public LazyRow< Item > ItemUnprimed { get; private set; }
    public LazyRow< Item > ItemPrimed { get; private set; }
    public byte Grade { get; private set; }
    public byte HoursRequired { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ItemUnprimed = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        ItemPrimed = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        Grade = parser.ReadOffset< byte >( 8 );
        HoursRequired = parser.ReadOffset< byte >( 9 );
        

    }
}
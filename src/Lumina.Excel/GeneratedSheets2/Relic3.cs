// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Relic3", columnHash: 0xeb3c566a )]
public partial class Relic3 : ExcelRow
{
    
    public LazyRow< Item > ItemAnimus { get; private set; }
    public LazyRow< Item > ItemScroll { get; private set; }
    public LazyRow< Item > ItemNovus { get; private set; }
    public int Icon { get; private set; }
    public byte MateriaLimit { get; private set; }
    public sbyte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ItemAnimus = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        ItemScroll = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 4 ), language );
        ItemNovus = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Icon = parser.ReadOffset< int >( 12 );
        MateriaLimit = parser.ReadOffset< byte >( 16 );
        Unknown0 = parser.ReadOffset< sbyte >( 17 );
        

    }
}
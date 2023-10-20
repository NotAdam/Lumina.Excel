// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIItemPouch", columnHash: 0x471e775e )]
public partial class MJIItemPouch : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< MJIItemCategory > Category { get; private set; }
    public LazyRow< MJICropSeed > Crop { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Category = new LazyRow< MJIItemCategory >( gameData, parser.ReadOffset< int >( 4 ), language );
        Crop = new LazyRow< MJICropSeed >( gameData, parser.ReadOffset< byte >( 8 ), language );
        Unknown0 = parser.ReadOffset< byte >( 9 );
        

    }
}
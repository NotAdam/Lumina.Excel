// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Race", columnHash: 0x3403807a )]
public partial class Race : ExcelRow
{
    
    public SeString Masculine { get; private set; }
    public SeString Feminine { get; private set; }
    public LazyRow< Item > RSEMBody { get; private set; }
    public LazyRow< Item > RSEFBody { get; private set; }
    public LazyRow< Item > RSEMHands { get; private set; }
    public LazyRow< Item > RSEFHands { get; private set; }
    public LazyRow< Item > RSEMLegs { get; private set; }
    public LazyRow< Item > RSEFLegs { get; private set; }
    public LazyRow< Item > RSEMFeet { get; private set; }
    public LazyRow< Item > RSEFFeet { get; private set; }
    public byte Unknown0 { get; private set; }
    public LazyRow< ExVersion > ExPac { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Masculine = parser.ReadOffset< SeString >( 0 );
        Feminine = parser.ReadOffset< SeString >( 4 );
        RSEMBody = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 8 ), language );
        RSEFBody = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 12 ), language );
        RSEMHands = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 16 ), language );
        RSEFHands = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 20 ), language );
        RSEMLegs = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 24 ), language );
        RSEFLegs = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 28 ), language );
        RSEMFeet = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 32 ), language );
        RSEFFeet = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 36 ), language );
        Unknown0 = parser.ReadOffset< byte >( 40 );
        ExPac = new LazyRow< ExVersion >( gameData, parser.ReadOffset< byte >( 41 ), language );
        

    }
}
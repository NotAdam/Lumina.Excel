// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Credit", columnHash: 0x1fe6ec22 )]
public partial class Credit : ExcelRow
{
    
    public LazyRow< CreditCast > Roles1 { get; private set; }
    public LazyRow< CreditCast > JapaneseCast1 { get; private set; }
    public LazyRow< CreditCast > EnglishCast1 { get; private set; }
    public LazyRow< CreditCast > FrenchCast1 { get; private set; }
    public LazyRow< CreditCast > GermanCast1 { get; private set; }
    public LazyRow< CreditCast > Roles2 { get; private set; }
    public LazyRow< CreditCast > JapaneseCast2 { get; private set; }
    public LazyRow< CreditCast > EnglishCast2 { get; private set; }
    public LazyRow< CreditCast > FrenchCast2 { get; private set; }
    public LazyRow< CreditCast > GermanCast2 { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Roles1 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        JapaneseCast1 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        EnglishCast1 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        FrenchCast1 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        GermanCast1 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Roles2 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        JapaneseCast2 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        EnglishCast2 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        FrenchCast2 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        GermanCast2 = new LazyRow< CreditCast >( gameData, parser.ReadOffset< ushort >( 18 ), language );
        Unknown0 = parser.ReadOffset< byte >( 20 );
        

    }
}
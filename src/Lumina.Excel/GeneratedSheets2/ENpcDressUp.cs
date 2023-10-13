// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ENpcDressUp", columnHash: 0xde74b4c4 )]
public partial class ENpcDressUp : ExcelRow
{
    
    public byte Unknown0 { get; private set; }
    public LazyRow< ENpcDressUpDress > ENpcDressUpDress { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< byte >( 0 );
        ENpcDressUpDress = new LazyRow< ENpcDressUpDress >( gameData, parser.ReadOffset< byte >( 1 ), language );
        

    }
}
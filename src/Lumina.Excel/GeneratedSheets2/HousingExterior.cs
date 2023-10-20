// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingExterior", columnHash: 0xb56595e0 )]
public partial class HousingExterior : ExcelRow
{
    
    public SeString Model { get; private set; }
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte HousingSize { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Model = parser.ReadOffset< SeString >( 0 );
        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        Unknown0 = parser.ReadOffset< byte >( 6 );
        Unknown1 = parser.ReadOffset< byte >( 7 );
        HousingSize = parser.ReadOffset< byte >( 8 );
        

    }
}
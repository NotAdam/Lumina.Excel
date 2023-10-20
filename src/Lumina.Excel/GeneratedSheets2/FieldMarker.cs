// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FieldMarker", columnHash: 0x23003392 )]
public partial class FieldMarker : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< VFX > VFX { get; private set; }
    public ushort UiIcon { get; private set; }
    public ushort MapIcon { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        VFX = new LazyRow< VFX >( gameData, parser.ReadOffset< int >( 4 ), language );
        UiIcon = parser.ReadOffset< ushort >( 8 );
        MapIcon = parser.ReadOffset< ushort >( 10 );
        

    }
}
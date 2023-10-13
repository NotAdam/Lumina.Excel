// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "UDS_Event", columnHash: 0xdfabf9e4 )]
public partial class UDS_Event : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString Type { get; private set; }
    public LazyRow< UDS_Property >[] Property { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        Type = parser.ReadOffset< SeString >( 4 );
        Property = new LazyRow< UDS_Property >[32];
        for (int i = 0; i < 32; i++)
        	Property[i] = new LazyRow< UDS_Property >( gameData, parser.ReadOffset< int >( (ushort) ( 8 + i * 4 ) ), language );
        

    }
}
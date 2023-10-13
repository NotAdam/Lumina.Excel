// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "StanceChange", columnHash: 0xf31cad82 )]
public partial class StanceChange : ExcelRow
{
    
    public float Unknown4 { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< Action >[] Action { get; private set; }
    public ushort Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown4 = parser.ReadOffset< float >( 0 );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        Action = new LazyRow< Action >[2];
        for (int i = 0; i < 2; i++)
        	Action[i] = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( (ushort) ( 6 + i * 2 ) ), language );
        Unknown3 = parser.ReadOffset< ushort >( 10 );
        

    }
}
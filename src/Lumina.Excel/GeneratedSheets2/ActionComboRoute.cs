// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionComboRoute", columnHash: 0xe732fd5b )]
public partial class ActionComboRoute : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< Action >[] Action { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Action = new LazyRow< Action >[7];
        for (int i = 0; i < 7; i++)
        	Action[i] = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( (ushort) ( 4 + i * 2 ) ), language );
        Unknown3 = parser.ReadOffset< sbyte >( 18 );
        Unknown4 = parser.ReadOffset< bool >( 19 );
        

    }
}
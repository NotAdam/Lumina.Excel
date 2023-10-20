// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MountAction", columnHash: 0x58822da3 )]
public partial class MountAction : ExcelRow
{
    
    public LazyRow< Action >[] Action { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Action = new LazyRow< Action >[6];
        for (int i = 0; i < 6; i++)
        	Action[i] = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        

    }
}
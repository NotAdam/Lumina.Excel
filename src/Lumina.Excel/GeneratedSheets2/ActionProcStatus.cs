// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionProcStatus", columnHash: 0xd870e208 )]
public partial class ActionProcStatus : ExcelRow
{
    
    public LazyRow< Status > Status { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Status = new LazyRow< Status >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        

    }
}
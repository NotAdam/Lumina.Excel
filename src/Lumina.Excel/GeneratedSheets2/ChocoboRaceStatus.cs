// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboRaceStatus", columnHash: 0xf8ab135e )]
public partial class ChocoboRaceStatus : ExcelRow
{
    
    public LazyRow< Status > Status { get; private set; }
    public ushort Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Status = new LazyRow< Status >( gameData, parser.ReadOffset< int >( 0 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        

    }
}
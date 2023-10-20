// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "OrchestrionUiparam", columnHash: 0xd73eab80 )]
public partial class OrchestrionUiparam : ExcelRow
{
    
    public ushort Order { get; private set; }
    public LazyRow< OrchestrionCategory > OrchestrionCategory { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Order = parser.ReadOffset< ushort >( 0 );
        OrchestrionCategory = new LazyRow< OrchestrionCategory >( gameData, parser.ReadOffset< byte >( 2 ), language );
        

    }
}
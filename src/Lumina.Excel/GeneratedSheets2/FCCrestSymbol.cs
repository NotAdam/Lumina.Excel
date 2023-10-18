// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FCCrestSymbol", columnHash: 0x43bdd5b1 )]
public partial class FCCrestSymbol : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public byte ColorNum { get; private set; }
    public byte FCRight { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        ColorNum = parser.ReadOffset< byte >( 2 );
        FCRight = parser.ReadOffset< byte >( 3 );
        

    }
}
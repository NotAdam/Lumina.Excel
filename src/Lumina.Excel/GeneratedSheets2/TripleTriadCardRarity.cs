// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TripleTriadCardRarity", columnHash: 0xdcfd9eba )]
public partial class TripleTriadCardRarity : ExcelRow
{
    
    public byte Stars { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Stars = parser.ReadOffset< byte >( 0 );
        

    }
}
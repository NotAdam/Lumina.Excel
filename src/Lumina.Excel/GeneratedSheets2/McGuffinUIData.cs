// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "McGuffinUIData", columnHash: 0x7e82af84 )]
public partial class McGuffinUIData : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Icon { get; private set; }
    public ushort Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        Order = parser.ReadOffset< ushort >( 8 );
        

    }
}
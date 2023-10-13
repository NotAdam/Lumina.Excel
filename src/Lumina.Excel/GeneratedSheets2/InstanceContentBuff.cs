// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "InstanceContentBuff", columnHash: 0x2020acf6 )]
public partial class InstanceContentBuff : ExcelRow
{
    
    public ushort EchoStart { get; private set; }
    public ushort EchoDeath { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        EchoStart = parser.ReadOffset< ushort >( 0 );
        EchoDeath = parser.ReadOffset< ushort >( 2 );
        

    }
}
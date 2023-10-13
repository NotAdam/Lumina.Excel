// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BGMScene", columnHash: 0x2711a5ea )]
public partial class BGMScene : ExcelRow
{
    
    public bool EnableDisableRestart { get; private set; }
    public bool Resume { get; private set; }
    public bool EnablePassEnd { get; private set; }
    public bool ForceAutoReset { get; private set; }
    public bool IgnoreBattle { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        EnableDisableRestart = parser.ReadOffset< bool >( 0 );
        Resume = parser.ReadOffset< bool >( 0, 2 );
        EnablePassEnd = parser.ReadOffset< bool >( 0, 4 );
        ForceAutoReset = parser.ReadOffset< bool >( 0, 8 );
        IgnoreBattle = parser.ReadOffset< bool >( 0, 16 );
        

    }
}
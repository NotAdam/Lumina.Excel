// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BGM", columnHash: 0xc9fc6953 )]
public partial class BGM : ExcelRow
{
    
    public SeString File { get; private set; }
    public float DisableRestartResetTime { get; private set; }
    public byte Priority { get; private set; }
    public byte SpecialMode { get; private set; }
    public bool DisableRestartTimeOut { get; private set; }
    public bool DisableRestart { get; private set; }
    public bool PassEnd { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        File = parser.ReadOffset< SeString >( 0 );
        DisableRestartResetTime = parser.ReadOffset< float >( 4 );
        Priority = parser.ReadOffset< byte >( 8 );
        SpecialMode = parser.ReadOffset< byte >( 9 );
        DisableRestartTimeOut = parser.ReadOffset< bool >( 10 );
        DisableRestart = parser.ReadOffset< bool >( 10, 2 );
        PassEnd = parser.ReadOffset< bool >( 10, 4 );
        

    }
}
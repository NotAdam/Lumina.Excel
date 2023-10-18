// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BehaviorPath", columnHash: 0x96572d0d )]
public partial class BehaviorPath : ExcelRow
{
    
    public float Speed { get; private set; }
    public bool IsTurnTransition { get; private set; }
    public bool IsFadeOut { get; private set; }
    public bool IsFadeIn { get; private set; }
    public bool IsWalking { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Speed = parser.ReadOffset< float >( 0 );
        IsTurnTransition = parser.ReadOffset< bool >( 4 );
        IsFadeOut = parser.ReadOffset< bool >( 4, 2 );
        IsFadeIn = parser.ReadOffset< bool >( 4, 4 );
        IsWalking = parser.ReadOffset< bool >( 4, 8 );
        Unknown0 = parser.ReadOffset< bool >( 4, 16 );
        

    }
}
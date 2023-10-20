// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Omen", columnHash: 0xd79b6c3f )]
public partial class Omen : ExcelRow
{
    
    public SeString Path { get; private set; }
    public SeString PathAlly { get; private set; }
    public byte Type { get; private set; }
    public sbyte Unknown0 { get; private set; }
    public bool RestrictYScale { get; private set; }
    public bool LargeScale { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Path = parser.ReadOffset< SeString >( 0 );
        PathAlly = parser.ReadOffset< SeString >( 4 );
        Type = parser.ReadOffset< byte >( 8 );
        Unknown0 = parser.ReadOffset< sbyte >( 9 );
        RestrictYScale = parser.ReadOffset< bool >( 10 );
        LargeScale = parser.ReadOffset< bool >( 10, 2 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Knockback", columnHash: 0x6876beaf )]
public partial class Knockback : ExcelRow
{
    
    public byte Distance { get; private set; }
    public byte Speed { get; private set; }
    public byte NearDistance { get; private set; }
    public byte Direction { get; private set; }
    public byte DirectionArg { get; private set; }
    public bool Motion { get; private set; }
    public bool CancelMove { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Distance = parser.ReadOffset< byte >( 0 );
        Speed = parser.ReadOffset< byte >( 1 );
        NearDistance = parser.ReadOffset< byte >( 2 );
        Direction = parser.ReadOffset< byte >( 3 );
        DirectionArg = parser.ReadOffset< byte >( 4 );
        Motion = parser.ReadOffset< bool >( 5 );
        CancelMove = parser.ReadOffset< bool >( 5, 2 );
        

    }
}
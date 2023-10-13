// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Attract", columnHash: 0xdb0ddee7 )]
public partial class Attract : ExcelRow
{
    
    public ushort MaxDistance { get; private set; }
    public ushort Speed { get; private set; }
    public short MinRemainingDistance { get; private set; }
    public byte Direction { get; private set; }
    public bool UseDistanceBetweenHitboxes { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        MaxDistance = parser.ReadOffset< ushort >( 0 );
        Speed = parser.ReadOffset< ushort >( 2 );
        MinRemainingDistance = parser.ReadOffset< short >( 4 );
        Direction = parser.ReadOffset< byte >( 6 );
        UseDistanceBetweenHitboxes = parser.ReadOffset< bool >( 7 );
        

    }
}
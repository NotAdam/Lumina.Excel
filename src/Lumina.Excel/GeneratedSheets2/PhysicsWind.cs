// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PhysicsWind", columnHash: 0x3bc4120f )]
public partial class PhysicsWind : ExcelRow
{
    
    public float Threshold { get; private set; }
    public float Amplitude { get; private set; }
    public float AmplitudeFrequency { get; private set; }
    public float PowerMin { get; private set; }
    public float PowerMax { get; private set; }
    public float PowerFrequency { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Threshold = parser.ReadOffset< float >( 0 );
        Amplitude = parser.ReadOffset< float >( 4 );
        AmplitudeFrequency = parser.ReadOffset< float >( 8 );
        PowerMin = parser.ReadOffset< float >( 12 );
        PowerMax = parser.ReadOffset< float >( 16 );
        PowerFrequency = parser.ReadOffset< float >( 20 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CutsceneEventMotion", columnHash: 0x025adb1e )]
public partial class CutsceneEventMotion : ExcelRow
{
    
    public float Unknown0 { get; private set; }
    public float Unknown1 { get; private set; }
    public float Unknown2 { get; private set; }
    public float Unknown3 { get; private set; }
    public float Unknown4 { get; private set; }
    public float Unknown5 { get; private set; }
    public float Unknown6 { get; private set; }
    public float Unknown7 { get; private set; }
    public float Unknown8 { get; private set; }
    public float Unknown9 { get; private set; }
    public float Unknown10 { get; private set; }
    public float Unknown11 { get; private set; }
    public ushort Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< float >( 0 );
        Unknown1 = parser.ReadOffset< float >( 4 );
        Unknown2 = parser.ReadOffset< float >( 8 );
        Unknown3 = parser.ReadOffset< float >( 12 );
        Unknown4 = parser.ReadOffset< float >( 16 );
        Unknown5 = parser.ReadOffset< float >( 20 );
        Unknown6 = parser.ReadOffset< float >( 24 );
        Unknown7 = parser.ReadOffset< float >( 28 );
        Unknown8 = parser.ReadOffset< float >( 32 );
        Unknown9 = parser.ReadOffset< float >( 36 );
        Unknown10 = parser.ReadOffset< float >( 40 );
        Unknown11 = parser.ReadOffset< float >( 44 );
        Unknown12 = parser.ReadOffset< ushort >( 48 );
        Unknown13 = parser.ReadOffset< byte >( 50 );
        

    }
}
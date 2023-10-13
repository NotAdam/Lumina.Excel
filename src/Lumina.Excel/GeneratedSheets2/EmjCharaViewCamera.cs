// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EmjCharaViewCamera", columnHash: 0x3bc4120f )]
public partial class EmjCharaViewCamera : ExcelRow
{
    
    public float Unknown0 { get; private set; }
    public float Unknown1 { get; private set; }
    public float Unknown2 { get; private set; }
    public float Unknown3 { get; private set; }
    public float Unknown4 { get; private set; }
    public float Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< float >( 0 );
        Unknown1 = parser.ReadOffset< float >( 4 );
        Unknown2 = parser.ReadOffset< float >( 8 );
        Unknown3 = parser.ReadOffset< float >( 12 );
        Unknown4 = parser.ReadOffset< float >( 16 );
        Unknown5 = parser.ReadOffset< float >( 20 );
        

    }
}
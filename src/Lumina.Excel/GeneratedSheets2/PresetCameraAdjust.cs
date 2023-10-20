// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PresetCameraAdjust", columnHash: 0x1d35bc8f )]
public partial class PresetCameraAdjust : ExcelRow
{
    
    public float Hyur_M { get; private set; }
    public float Hyur_F { get; private set; }
    public float Elezen_M { get; private set; }
    public float Elezen_F { get; private set; }
    public float Lalafell_M { get; private set; }
    public float Lalafell_F { get; private set; }
    public float Miqote_M { get; private set; }
    public float Miqote_F { get; private set; }
    public float Roe_M { get; private set; }
    public float Roe_F { get; private set; }
    public float Hrothgar_M { get; private set; }
    public float Hrothgar_F { get; private set; }
    public float Viera_M { get; private set; }
    public float Viera_F { get; private set; }
    public float Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Hyur_M = parser.ReadOffset< float >( 0 );
        Hyur_F = parser.ReadOffset< float >( 4 );
        Elezen_M = parser.ReadOffset< float >( 8 );
        Elezen_F = parser.ReadOffset< float >( 12 );
        Lalafell_M = parser.ReadOffset< float >( 16 );
        Lalafell_F = parser.ReadOffset< float >( 20 );
        Miqote_M = parser.ReadOffset< float >( 24 );
        Miqote_F = parser.ReadOffset< float >( 28 );
        Roe_M = parser.ReadOffset< float >( 32 );
        Roe_F = parser.ReadOffset< float >( 36 );
        Hrothgar_M = parser.ReadOffset< float >( 40 );
        Hrothgar_F = parser.ReadOffset< float >( 44 );
        Viera_M = parser.ReadOffset< float >( 48 );
        Viera_F = parser.ReadOffset< float >( 52 );
        Unknown0 = parser.ReadOffset< float >( 56 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PresetCamera", columnHash: 0x246479ab )]
public partial class PresetCamera : ExcelRow
{
    
    public float PosX { get; private set; }
    public float PosY { get; private set; }
    public float PosZ { get; private set; }
    public float Elezen { get; private set; }
    public float Lalafell { get; private set; }
    public float Miqote { get; private set; }
    public float Roe { get; private set; }
    public float Hrothgar { get; private set; }
    public float Viera { get; private set; }
    public float Unknown0 { get; private set; }
    public float Hyur_F { get; private set; }
    public float Elezen_F { get; private set; }
    public float Lalafell_F { get; private set; }
    public float Miqote_F { get; private set; }
    public float Roe_F { get; private set; }
    public float Hrothgar_F { get; private set; }
    public float Viera_F { get; private set; }
    public ushort EID { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        PosX = parser.ReadOffset< float >( 0 );
        PosY = parser.ReadOffset< float >( 4 );
        PosZ = parser.ReadOffset< float >( 8 );
        Elezen = parser.ReadOffset< float >( 12 );
        Lalafell = parser.ReadOffset< float >( 16 );
        Miqote = parser.ReadOffset< float >( 20 );
        Roe = parser.ReadOffset< float >( 24 );
        Hrothgar = parser.ReadOffset< float >( 28 );
        Viera = parser.ReadOffset< float >( 32 );
        Unknown0 = parser.ReadOffset< float >( 36 );
        Hyur_F = parser.ReadOffset< float >( 40 );
        Elezen_F = parser.ReadOffset< float >( 44 );
        Lalafell_F = parser.ReadOffset< float >( 48 );
        Miqote_F = parser.ReadOffset< float >( 52 );
        Roe_F = parser.ReadOffset< float >( 56 );
        Hrothgar_F = parser.ReadOffset< float >( 60 );
        Viera_F = parser.ReadOffset< float >( 64 );
        EID = parser.ReadOffset< ushort >( 68 );
        

    }
}
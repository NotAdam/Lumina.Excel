// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MountCustomize", columnHash: 0xdde90e69 )]
public partial class MountCustomize : ExcelRow
{
    
    public ushort HyurMidlanderMaleScale { get; private set; }
    public ushort HyurMidlanderFemaleScale { get; private set; }
    public ushort HyurHighlanderMaleScale { get; private set; }
    public ushort HyurHighlanderFemaleScale { get; private set; }
    public ushort ElezenMaleScale { get; private set; }
    public ushort ElezenFemaleScale { get; private set; }
    public ushort LalaMaleScale { get; private set; }
    public ushort LalaFemaleScale { get; private set; }
    public ushort MiqoMaleScale { get; private set; }
    public ushort MiqoFemaleScale { get; private set; }
    public ushort RoeMaleScale { get; private set; }
    public ushort RoeFemaleScale { get; private set; }
    public ushort AuRaMaleScale { get; private set; }
    public ushort AuRaFemaleScale { get; private set; }
    public ushort HrothgarMaleScale { get; private set; }
    public ushort VieraMaleScale { get; private set; }
    public ushort VieraFemaleScale { get; private set; }
    public ushort HyurMidlanderMaleCameraHeight { get; private set; }
    public ushort HyurMidlanderFemaleCameraHeight { get; private set; }
    public byte HyurHighlanderMaleCameraHeight { get; private set; }
    public byte HyurHighlanderFemaleCameraHeight { get; private set; }
    public byte ElezenMaleCameraHeight { get; private set; }
    public byte ElezenFemaleCameraHeight { get; private set; }
    public byte LalaMaleCameraHeight { get; private set; }
    public byte LalaFemaleCameraHeight { get; private set; }
    public byte MiqoMaleCameraHeight { get; private set; }
    public byte MiqoFemaleCameraHeight { get; private set; }
    public byte RoeMaleCameraHeight { get; private set; }
    public byte RoeFemaleCameraHeight { get; private set; }
    public byte AuRaMaleCameraHeight { get; private set; }
    public byte AuRaFemaleCameraHeight { get; private set; }
    public byte HrothgarMaleCameraHeight { get; private set; }
    public byte VieraMaleCameraHeight { get; private set; }
    public byte VieraFemaleCameraHeight { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown_70_1 { get; private set; }
    public byte Unknown_70_2 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        HyurMidlanderMaleScale = parser.ReadOffset< ushort >( 0 );
        HyurMidlanderFemaleScale = parser.ReadOffset< ushort >( 2 );
        HyurHighlanderMaleScale = parser.ReadOffset< ushort >( 4 );
        HyurHighlanderFemaleScale = parser.ReadOffset< ushort >( 6 );
        ElezenMaleScale = parser.ReadOffset< ushort >( 8 );
        ElezenFemaleScale = parser.ReadOffset< ushort >( 10 );
        LalaMaleScale = parser.ReadOffset< ushort >( 12 );
        LalaFemaleScale = parser.ReadOffset< ushort >( 14 );
        MiqoMaleScale = parser.ReadOffset< ushort >( 16 );
        MiqoFemaleScale = parser.ReadOffset< ushort >( 18 );
        RoeMaleScale = parser.ReadOffset< ushort >( 20 );
        RoeFemaleScale = parser.ReadOffset< ushort >( 22 );
        AuRaMaleScale = parser.ReadOffset< ushort >( 24 );
        AuRaFemaleScale = parser.ReadOffset< ushort >( 26 );
        HrothgarMaleScale = parser.ReadOffset< ushort >( 28 );
        VieraMaleScale = parser.ReadOffset< ushort >( 30 );
        VieraFemaleScale = parser.ReadOffset< ushort >( 32 );
        HyurMidlanderMaleCameraHeight = parser.ReadOffset< ushort >( 34 );
        HyurMidlanderFemaleCameraHeight = parser.ReadOffset< ushort >( 36 );
        HyurHighlanderMaleCameraHeight = parser.ReadOffset< byte >( 38 );
        HyurHighlanderFemaleCameraHeight = parser.ReadOffset< byte >( 39 );
        ElezenMaleCameraHeight = parser.ReadOffset< byte >( 40 );
        ElezenFemaleCameraHeight = parser.ReadOffset< byte >( 41 );
        LalaMaleCameraHeight = parser.ReadOffset< byte >( 42 );
        LalaFemaleCameraHeight = parser.ReadOffset< byte >( 43 );
        MiqoMaleCameraHeight = parser.ReadOffset< byte >( 44 );
        MiqoFemaleCameraHeight = parser.ReadOffset< byte >( 45 );
        RoeMaleCameraHeight = parser.ReadOffset< byte >( 46 );
        RoeFemaleCameraHeight = parser.ReadOffset< byte >( 47 );
        AuRaMaleCameraHeight = parser.ReadOffset< byte >( 48 );
        AuRaFemaleCameraHeight = parser.ReadOffset< byte >( 49 );
        HrothgarMaleCameraHeight = parser.ReadOffset< byte >( 50 );
        VieraMaleCameraHeight = parser.ReadOffset< byte >( 51 );
        VieraFemaleCameraHeight = parser.ReadOffset< byte >( 52 );
        Unknown0 = parser.ReadOffset< byte >( 53 );
        Unknown1 = parser.ReadOffset< byte >( 54 );
        Unknown_70_1 = parser.ReadOffset< byte >( 55 );
        Unknown_70_2 = parser.ReadOffset< byte >( 56 );
        Unknown2 = parser.ReadOffset< bool >( 57 );
        

    }
}
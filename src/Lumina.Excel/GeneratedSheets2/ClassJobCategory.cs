// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ClassJobCategory", columnHash: 0x7caef8ce )]
public partial class ClassJobCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public bool ADV { get; private set; }
    public bool GLA { get; private set; }
    public bool PGL { get; private set; }
    public bool MRD { get; private set; }
    public bool LNC { get; private set; }
    public bool ARC { get; private set; }
    public bool CNJ { get; private set; }
    public bool THM { get; private set; }
    public bool CRP { get; private set; }
    public bool BSM { get; private set; }
    public bool ARM { get; private set; }
    public bool GSM { get; private set; }
    public bool LTW { get; private set; }
    public bool WVR { get; private set; }
    public bool ALC { get; private set; }
    public bool CUL { get; private set; }
    public bool MIN { get; private set; }
    public bool BTN { get; private set; }
    public bool FSH { get; private set; }
    public bool PLD { get; private set; }
    public bool MNK { get; private set; }
    public bool WAR { get; private set; }
    public bool DRG { get; private set; }
    public bool BRD { get; private set; }
    public bool WHM { get; private set; }
    public bool BLM { get; private set; }
    public bool ACN { get; private set; }
    public bool SMN { get; private set; }
    public bool SCH { get; private set; }
    public bool ROG { get; private set; }
    public bool NIN { get; private set; }
    public bool MCH { get; private set; }
    public bool DRK { get; private set; }
    public bool AST { get; private set; }
    public bool SAM { get; private set; }
    public bool RDM { get; private set; }
    public bool BLU { get; private set; }
    public bool GNB { get; private set; }
    public bool DNC { get; private set; }
    public bool RPR { get; private set; }
    public bool SGE { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        ADV = parser.ReadOffset< bool >( 4 );
        GLA = parser.ReadOffset< bool >( 5 );
        PGL = parser.ReadOffset< bool >( 6 );
        MRD = parser.ReadOffset< bool >( 7 );
        LNC = parser.ReadOffset< bool >( 8 );
        ARC = parser.ReadOffset< bool >( 9 );
        CNJ = parser.ReadOffset< bool >( 10 );
        THM = parser.ReadOffset< bool >( 11 );
        CRP = parser.ReadOffset< bool >( 12 );
        BSM = parser.ReadOffset< bool >( 13 );
        ARM = parser.ReadOffset< bool >( 14 );
        GSM = parser.ReadOffset< bool >( 15 );
        LTW = parser.ReadOffset< bool >( 16 );
        WVR = parser.ReadOffset< bool >( 17 );
        ALC = parser.ReadOffset< bool >( 18 );
        CUL = parser.ReadOffset< bool >( 19 );
        MIN = parser.ReadOffset< bool >( 20 );
        BTN = parser.ReadOffset< bool >( 21 );
        FSH = parser.ReadOffset< bool >( 22 );
        PLD = parser.ReadOffset< bool >( 23 );
        MNK = parser.ReadOffset< bool >( 24 );
        WAR = parser.ReadOffset< bool >( 25 );
        DRG = parser.ReadOffset< bool >( 26 );
        BRD = parser.ReadOffset< bool >( 27 );
        WHM = parser.ReadOffset< bool >( 28 );
        BLM = parser.ReadOffset< bool >( 29 );
        ACN = parser.ReadOffset< bool >( 30 );
        SMN = parser.ReadOffset< bool >( 31 );
        SCH = parser.ReadOffset< bool >( 32 );
        ROG = parser.ReadOffset< bool >( 33 );
        NIN = parser.ReadOffset< bool >( 34 );
        MCH = parser.ReadOffset< bool >( 35 );
        DRK = parser.ReadOffset< bool >( 36 );
        AST = parser.ReadOffset< bool >( 37 );
        SAM = parser.ReadOffset< bool >( 38 );
        RDM = parser.ReadOffset< bool >( 39 );
        BLU = parser.ReadOffset< bool >( 40 );
        GNB = parser.ReadOffset< bool >( 41 );
        DNC = parser.ReadOffset< bool >( 42 );
        RPR = parser.ReadOffset< bool >( 43 );
        SGE = parser.ReadOffset< bool >( 44 );
        

    }
}
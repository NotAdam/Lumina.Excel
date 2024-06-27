// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaMakeName", columnHash: 0x6fbe744d )]
public partial class CharaMakeName : ExcelRow
{
    
    public SeString HyurMidlanderMale { get; private set; }
    public SeString HyurMidlanderFemale { get; private set; }
    public SeString HyurMidlanderLastName { get; private set; }
    public SeString HyurHighlanderMale { get; private set; }
    public SeString HyurHighlanderFemale { get; private set; }
    public SeString HyurHighlanderLastName { get; private set; }
    public SeString ElezenMale { get; private set; }
    public SeString ElezenFemale { get; private set; }
    public SeString ElezenWildwoodLastName { get; private set; }
    public SeString ElezenDuskwightLastName { get; private set; }
    public SeString MiqoteSunMale { get; private set; }
    public SeString MiqoteSunFemale { get; private set; }
    public SeString MiqoteSunMaleLastName { get; private set; }
    public SeString MiqoteSunFemaleLastName { get; private set; }
    public SeString MiqoteMoonMale { get; private set; }
    public SeString MiqoteMoonFemale { get; private set; }
    public SeString MiqoteMoonLastname { get; private set; }
    public SeString LalafellPlainsfolkFirstNameStart { get; private set; }
    public SeString LalafellPlainsfolkLastNameStart { get; private set; }
    public SeString LalafellPlainsfolkEndOfNames { get; private set; }
    public SeString LalafellDunesfolkMale { get; private set; }
    public SeString LalafellDunesfolkMaleLastName { get; private set; }
    public SeString LalafellDunesfolkFemale { get; private set; }
    public SeString LalafellDunesfolkFemaleLastName { get; private set; }
    public SeString RoegadynSeaWolfMale { get; private set; }
    public SeString RoegadynSeaWolfMaleLastName { get; private set; }
    public SeString RoegadynSeaWolfFemale { get; private set; }
    public SeString RoegadynSeaWolfFemaleLastName { get; private set; }
    public SeString RoegadynHellsguardFirstName { get; private set; }
    public SeString RoegadynHellsguardMaleLastName { get; private set; }
    public SeString RoegadynHellsguardFemaleLastName { get; private set; }
    public SeString AuRaRaenMale { get; private set; }
    public SeString AuRaRaenFemale { get; private set; }
    public SeString AuRaRaenLastName { get; private set; }
    public SeString AuRaXaelaMale { get; private set; }
    public SeString AuRaXaelaFemale { get; private set; }
    public SeString AuRaXaelaLastName { get; private set; }
    public SeString HrothgarHellionsFirstName { get; private set; }
    public SeString HrothgarHellionsLastName { get; private set; }
    public SeString HrothgarLostFirstName { get; private set; }
    public SeString HrothgarLostLastName { get; private set; }
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public SeString Unknown2 { get; private set; }
    public SeString VieraFirstName { get; private set; }
    public SeString VieraRavaLastName { get; private set; }
    public SeString VieraVeenaLastName { get; private set; }
    public SeString Unknown_70_1 { get; private set; }
    public SeString Unknown_70_2 { get; private set; }
    public SeString Unknown_70_3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        HyurMidlanderMale = parser.ReadOffset< SeString >( 0 );
        HyurMidlanderFemale = parser.ReadOffset< SeString >( 4 );
        HyurMidlanderLastName = parser.ReadOffset< SeString >( 8 );
        HyurHighlanderMale = parser.ReadOffset< SeString >( 12 );
        HyurHighlanderFemale = parser.ReadOffset< SeString >( 16 );
        HyurHighlanderLastName = parser.ReadOffset< SeString >( 20 );
        ElezenMale = parser.ReadOffset< SeString >( 24 );
        ElezenFemale = parser.ReadOffset< SeString >( 28 );
        ElezenWildwoodLastName = parser.ReadOffset< SeString >( 32 );
        ElezenDuskwightLastName = parser.ReadOffset< SeString >( 36 );
        MiqoteSunMale = parser.ReadOffset< SeString >( 40 );
        MiqoteSunFemale = parser.ReadOffset< SeString >( 44 );
        MiqoteSunMaleLastName = parser.ReadOffset< SeString >( 48 );
        MiqoteSunFemaleLastName = parser.ReadOffset< SeString >( 52 );
        MiqoteMoonMale = parser.ReadOffset< SeString >( 56 );
        MiqoteMoonFemale = parser.ReadOffset< SeString >( 60 );
        MiqoteMoonLastname = parser.ReadOffset< SeString >( 64 );
        LalafellPlainsfolkFirstNameStart = parser.ReadOffset< SeString >( 68 );
        LalafellPlainsfolkLastNameStart = parser.ReadOffset< SeString >( 72 );
        LalafellPlainsfolkEndOfNames = parser.ReadOffset< SeString >( 76 );
        LalafellDunesfolkMale = parser.ReadOffset< SeString >( 80 );
        LalafellDunesfolkMaleLastName = parser.ReadOffset< SeString >( 84 );
        LalafellDunesfolkFemale = parser.ReadOffset< SeString >( 88 );
        LalafellDunesfolkFemaleLastName = parser.ReadOffset< SeString >( 92 );
        RoegadynSeaWolfMale = parser.ReadOffset< SeString >( 96 );
        RoegadynSeaWolfMaleLastName = parser.ReadOffset< SeString >( 100 );
        RoegadynSeaWolfFemale = parser.ReadOffset< SeString >( 104 );
        RoegadynSeaWolfFemaleLastName = parser.ReadOffset< SeString >( 108 );
        RoegadynHellsguardFirstName = parser.ReadOffset< SeString >( 112 );
        RoegadynHellsguardMaleLastName = parser.ReadOffset< SeString >( 116 );
        RoegadynHellsguardFemaleLastName = parser.ReadOffset< SeString >( 120 );
        AuRaRaenMale = parser.ReadOffset< SeString >( 124 );
        AuRaRaenFemale = parser.ReadOffset< SeString >( 128 );
        AuRaRaenLastName = parser.ReadOffset< SeString >( 132 );
        AuRaXaelaMale = parser.ReadOffset< SeString >( 136 );
        AuRaXaelaFemale = parser.ReadOffset< SeString >( 140 );
        AuRaXaelaLastName = parser.ReadOffset< SeString >( 144 );
        HrothgarHellionsFirstName = parser.ReadOffset< SeString >( 148 );
        HrothgarHellionsLastName = parser.ReadOffset< SeString >( 152 );
        HrothgarLostFirstName = parser.ReadOffset< SeString >( 156 );
        HrothgarLostLastName = parser.ReadOffset< SeString >( 160 );
        Unknown0 = parser.ReadOffset< SeString >( 164 );
        Unknown1 = parser.ReadOffset< SeString >( 168 );
        Unknown2 = parser.ReadOffset< SeString >( 172 );
        VieraFirstName = parser.ReadOffset< SeString >( 176 );
        VieraRavaLastName = parser.ReadOffset< SeString >( 180 );
        VieraVeenaLastName = parser.ReadOffset< SeString >( 184 );
        Unknown_70_1 = parser.ReadOffset< SeString >( 188 );
        Unknown_70_2 = parser.ReadOffset< SeString >( 192 );
        Unknown_70_3 = parser.ReadOffset< SeString >( 196 );
        

    }
}
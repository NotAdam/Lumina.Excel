// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentMemberType", columnHash: 0x65d5ee00 )]
public partial class ContentMemberType : ExcelRow
{
    
    public byte Unknown1 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte TanksPerParty { get; private set; }
    public byte HealersPerParty { get; private set; }
    public byte MeleesPerParty { get; private set; }
    public byte RangedPerParty { get; private set; }
    public bool Unknown0 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    public bool Unknown18 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown1 = parser.ReadOffset< byte >( 0 );
        Unknown4 = parser.ReadOffset< byte >( 1 );
        Unknown5 = parser.ReadOffset< byte >( 2 );
        Unknown6 = parser.ReadOffset< byte >( 3 );
        Unknown7 = parser.ReadOffset< byte >( 4 );
        Unknown8 = parser.ReadOffset< byte >( 5 );
        Unknown9 = parser.ReadOffset< byte >( 6 );
        TanksPerParty = parser.ReadOffset< byte >( 7 );
        HealersPerParty = parser.ReadOffset< byte >( 8 );
        MeleesPerParty = parser.ReadOffset< byte >( 9 );
        RangedPerParty = parser.ReadOffset< byte >( 10 );
        Unknown0 = parser.ReadOffset< bool >( 11 );
        Unknown2 = parser.ReadOffset< bool >( 11, 2 );
        Unknown3 = parser.ReadOffset< bool >( 11, 4 );
        Unknown14 = parser.ReadOffset< bool >( 11, 8 );
        Unknown15 = parser.ReadOffset< bool >( 11, 16 );
        Unknown16 = parser.ReadOffset< bool >( 11, 32 );
        Unknown17 = parser.ReadOffset< bool >( 11, 64 );
        Unknown18 = parser.ReadOffset< bool >( 11, 128 );
        

    }
}
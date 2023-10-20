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
    
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte TanksPerParty { get; private set; }
    public byte HealersPerParty { get; private set; }
    public byte MeleesPerParty { get; private set; }
    public byte RangedPerParty { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< byte >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 1 );
        Unknown2 = parser.ReadOffset< byte >( 2 );
        Unknown3 = parser.ReadOffset< byte >( 3 );
        Unknown4 = parser.ReadOffset< byte >( 4 );
        Unknown5 = parser.ReadOffset< byte >( 5 );
        Unknown6 = parser.ReadOffset< byte >( 6 );
        TanksPerParty = parser.ReadOffset< byte >( 7 );
        HealersPerParty = parser.ReadOffset< byte >( 8 );
        MeleesPerParty = parser.ReadOffset< byte >( 9 );
        RangedPerParty = parser.ReadOffset< byte >( 10 );
        Unknown7 = parser.ReadOffset< bool >( 11 );
        Unknown8 = parser.ReadOffset< bool >( 11, 2 );
        Unknown9 = parser.ReadOffset< bool >( 11, 4 );
        Unknown10 = parser.ReadOffset< bool >( 11, 8 );
        Unknown11 = parser.ReadOffset< bool >( 11, 16 );
        Unknown12 = parser.ReadOffset< bool >( 11, 32 );
        Unknown13 = parser.ReadOffset< bool >( 11, 64 );
        Unknown14 = parser.ReadOffset< bool >( 11, 128 );
        

    }
}
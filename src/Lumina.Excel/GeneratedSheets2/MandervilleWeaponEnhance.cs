// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MandervilleWeaponEnhance", columnHash: 0x9ec26187 )]
public partial class MandervilleWeaponEnhance : ExcelRow
{
    
    public uint Unknown1 { get; private set; }
    public uint Unknown4 { get; private set; }
    public uint Unknown7 { get; private set; }
    public uint Unknown10 { get; private set; }
    public uint Unknown13 { get; private set; }
    public uint Unknown15 { get; private set; }
    public ushort Unknown14 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown12 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown1 = parser.ReadOffset< uint >( 0 );
        Unknown4 = parser.ReadOffset< uint >( 4 );
        Unknown7 = parser.ReadOffset< uint >( 8 );
        Unknown10 = parser.ReadOffset< uint >( 12 );
        Unknown13 = parser.ReadOffset< uint >( 16 );
        Unknown15 = parser.ReadOffset< uint >( 20 );
        Unknown14 = parser.ReadOffset< ushort >( 24 );
        Unknown0 = parser.ReadOffset< byte >( 26 );
        Unknown2 = parser.ReadOffset< byte >( 27 );
        Unknown5 = parser.ReadOffset< byte >( 28 );
        Unknown8 = parser.ReadOffset< byte >( 29 );
        Unknown11 = parser.ReadOffset< byte >( 30 );
        Unknown3 = parser.ReadOffset< byte >( 31 );
        Unknown6 = parser.ReadOffset< byte >( 32 );
        Unknown9 = parser.ReadOffset< byte >( 33 );
        Unknown12 = parser.ReadOffset< byte >( 34 );
        

    }
}
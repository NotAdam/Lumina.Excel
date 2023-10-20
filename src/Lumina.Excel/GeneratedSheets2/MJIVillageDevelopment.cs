// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIVillageDevelopment", columnHash: 0x038243ca )]
public partial class MJIVillageDevelopment : ExcelRow
{
    
    public LazyRow< ENpcResident > ENPC { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public LazyRow< Behavior > Behavior0 { get; private set; }
    public LazyRow< Behavior > Behavior1 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ENPC = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        Unknown1 = parser.ReadOffset< uint >( 8 );
        Unknown2 = parser.ReadOffset< uint >( 12 );
        Unknown3 = parser.ReadOffset< uint >( 16 );
        Unknown4 = parser.ReadOffset< uint >( 20 );
        Behavior0 = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        Behavior1 = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 26 ), language );
        Unknown5 = parser.ReadOffset< byte >( 28 );
        Unknown6 = parser.ReadOffset< byte >( 29 );
        Unknown7 = parser.ReadOffset< byte >( 30 );
        Unknown8 = parser.ReadOffset< byte >( 31 );
        Unknown9 = parser.ReadOffset< byte >( 32 );
        Unknown10 = parser.ReadOffset< byte >( 33 );
        Unknown11 = parser.ReadOffset< byte >( 34 );
        

    }
}
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
    public uint Unknown4 { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Unknown8 { get; private set; }
    public uint Unknown10 { get; private set; }
    public uint Unknown12 { get; private set; }
    public LazyRow< Behavior > Behavior0 { get; private set; }
    public LazyRow< Behavior > Behavior1 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ENPC = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown4 = parser.ReadOffset< uint >( 4 );
        Unknown6 = parser.ReadOffset< uint >( 8 );
        Unknown8 = parser.ReadOffset< uint >( 12 );
        Unknown10 = parser.ReadOffset< uint >( 16 );
        Unknown12 = parser.ReadOffset< uint >( 20 );
        Behavior0 = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        Behavior1 = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 26 ), language );
        Unknown1 = parser.ReadOffset< byte >( 28 );
        Unknown2 = parser.ReadOffset< byte >( 29 );
        Unknown3 = parser.ReadOffset< byte >( 30 );
        Unknown5 = parser.ReadOffset< byte >( 31 );
        Unknown7 = parser.ReadOffset< byte >( 32 );
        Unknown13 = parser.ReadOffset< byte >( 33 );
        Unknown14 = parser.ReadOffset< byte >( 34 );
        

    }
}
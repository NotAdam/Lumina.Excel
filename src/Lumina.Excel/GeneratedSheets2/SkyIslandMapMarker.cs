// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SkyIslandMapMarker", columnHash: 0xa4e38464 )]
public partial class SkyIslandMapMarker : ExcelRow
{
    
    public short Unknown0 { get; private set; }
    public short Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public short Unknown3 { get; private set; }
    public short Unknown4 { get; private set; }
    public short Unknown5 { get; private set; }
    public short Unknown6 { get; private set; }
    public short Unknown7 { get; private set; }
    public short Unknown8 { get; private set; }
    public short Unknown9 { get; private set; }
    public short Unknown10 { get; private set; }
    public short Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< short >( 0 );
        Unknown1 = parser.ReadOffset< short >( 2 );
        Unknown2 = parser.ReadOffset< short >( 4 );
        Unknown3 = parser.ReadOffset< short >( 6 );
        Unknown4 = parser.ReadOffset< short >( 8 );
        Unknown5 = parser.ReadOffset< short >( 10 );
        Unknown6 = parser.ReadOffset< short >( 12 );
        Unknown7 = parser.ReadOffset< short >( 14 );
        Unknown8 = parser.ReadOffset< short >( 16 );
        Unknown9 = parser.ReadOffset< short >( 18 );
        Unknown10 = parser.ReadOffset< short >( 20 );
        Unknown11 = parser.ReadOffset< short >( 22 );
        Unknown12 = parser.ReadOffset< byte >( 24 );
        Unknown13 = parser.ReadOffset< byte >( 25 );
        Unknown14 = parser.ReadOffset< byte >( 26 );
        Unknown15 = parser.ReadOffset< byte >( 27 );
        Unknown16 = parser.ReadOffset< byte >( 28 );
        

    }
}
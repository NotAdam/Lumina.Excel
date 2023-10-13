// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MapMarkerRegion", columnHash: 0xe2747195 )]
public partial class MapMarkerRegion : ExcelRow
{
    
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public short X { get; private set; }
    public short Unknown2 { get; private set; }
    public short Unknown5 { get; private set; }
    public short Unknown6 { get; private set; }
    public short Unknown9 { get; private set; }
    public short Unknown10 { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool Unknown11 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown3 = parser.ReadOffset< ushort >( 0 );
        Unknown4 = parser.ReadOffset< ushort >( 2 );
        Unknown7 = parser.ReadOffset< ushort >( 4 );
        Unknown8 = parser.ReadOffset< ushort >( 6 );
        X = parser.ReadOffset< short >( 8 );
        Unknown2 = parser.ReadOffset< short >( 10 );
        Unknown5 = parser.ReadOffset< short >( 12 );
        Unknown6 = parser.ReadOffset< short >( 14 );
        Unknown9 = parser.ReadOffset< short >( 16 );
        Unknown10 = parser.ReadOffset< short >( 18 );
        Unknown0 = parser.ReadOffset< byte >( 20 );
        Unknown11 = parser.ReadOffset< bool >( 21 );
        

    }
}
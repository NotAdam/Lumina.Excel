// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PointMenuChoice", columnHash: 0xcc7f3288 )]
public partial class PointMenuChoice : ExcelRow
{
    
    public float Unknown0 { get; private set; }
    public float Unknown1 { get; private set; }
    public float Unknown2 { get; private set; }
    public float Unknown3 { get; private set; }
    public float Unknown4 { get; private set; }
    public float Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< float >( 0 );
        Unknown1 = parser.ReadOffset< float >( 4 );
        Unknown2 = parser.ReadOffset< float >( 8 );
        Unknown3 = parser.ReadOffset< float >( 12 );
        Unknown4 = parser.ReadOffset< float >( 16 );
        Unknown5 = parser.ReadOffset< float >( 20 );
        Unknown6 = parser.ReadOffset< ushort >( 24 );
        Unknown7 = parser.ReadOffset< byte >( 26 );
        Unknown8 = parser.ReadOffset< byte >( 27 );
        Unknown9 = parser.ReadOffset< byte >( 28 );
        Unknown10 = parser.ReadOffset< byte >( 29 );
        Unknown11 = parser.ReadOffset< byte >( 30 );
        Unknown12 = parser.ReadOffset< byte >( 31 );
        

    }
}
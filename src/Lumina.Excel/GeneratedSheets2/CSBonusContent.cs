// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CSBonusContent", columnHash: 0xf8d2be91 )]
public partial class CSBonusContent : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown3 { get; private set; }
    public int Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Unknown2 = parser.ReadOffset< int >( 8 );
        Unknown3 = parser.ReadOffset< int >( 12 );
        Unknown4 = parser.ReadOffset< int >( 16 );
        Unknown5 = parser.ReadOffset< ushort >( 20 );
        Unknown6 = parser.ReadOffset< ushort >( 22 );
        Unknown7 = parser.ReadOffset< ushort >( 24 );
        Unknown8 = parser.ReadOffset< byte >( 26 );
        Unknown9 = parser.ReadOffset< byte >( 27 );
        Unknown10 = parser.ReadOffset< byte >( 28 );
        Unknown11 = parser.ReadOffset< byte >( 29 );
        Unknown12 = parser.ReadOffset< byte >( 30 );
        Unknown13 = parser.ReadOffset< byte >( 31 );
        

    }
}
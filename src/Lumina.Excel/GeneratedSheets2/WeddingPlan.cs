// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeddingPlan", columnHash: 0x6ceafe59 )]
public partial class WeddingPlan : ExcelRow
{
    
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    
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
        Unknown7 = parser.ReadOffset< byte >( 7 );
        Unknown8 = parser.ReadOffset< byte >( 8 );
        Unknown9 = parser.ReadOffset< byte >( 9 );
        Unknown10 = parser.ReadOffset< byte >( 10 );
        Unknown11 = parser.ReadOffset< byte >( 11 );
        Unknown12 = parser.ReadOffset< byte >( 12 );
        Unknown13 = parser.ReadOffset< byte >( 13 );
        Unknown14 = parser.ReadOffset< byte >( 14 );
        Unknown15 = parser.ReadOffset< byte >( 15 );
        Unknown16 = parser.ReadOffset< byte >( 16 );
        Unknown17 = parser.ReadOffset< byte >( 17 );
        Unknown18 = parser.ReadOffset< byte >( 18 );
        Unknown19 = parser.ReadOffset< byte >( 19 );
        

    }
}
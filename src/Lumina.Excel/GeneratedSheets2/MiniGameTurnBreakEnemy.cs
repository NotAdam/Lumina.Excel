// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MiniGameTurnBreakEnemy", columnHash: 0x8267f7fa )]
public partial class MiniGameTurnBreakEnemy : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public int Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public int Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public int Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public bool Unknown18 { get; private set; }
    public bool Unknown19 { get; private set; }
    public int Unknown20 { get; private set; }
    public int Unknown21 { get; private set; }
    public byte Unknown22 { get; private set; }
    public byte Unknown23 { get; private set; }
    public byte Unknown24 { get; private set; }
    public byte Unknown25 { get; private set; }
    public byte Unknown26 { get; private set; }
    public byte Unknown27 { get; private set; }
    public byte Unknown28 { get; private set; }
    public byte Unknown29 { get; private set; }
    public byte Unknown30 { get; private set; }
    public byte Unknown31 { get; private set; }
    public byte Unknown32 { get; private set; }
    public byte Unknown33 { get; private set; }
    public bool Unknown34 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        Unknown2 = parser.ReadOffset< byte >( 5 );
        Unknown3 = parser.ReadOffset< bool >( 6 );
        Unknown4 = parser.ReadOffset< bool >( 6, 2 );
        Unknown5 = parser.ReadOffset< int >( 8 );
        Unknown6 = parser.ReadOffset< byte >( 12 );
        Unknown7 = parser.ReadOffset< byte >( 13 );
        Unknown8 = parser.ReadOffset< bool >( 14 );
        Unknown9 = parser.ReadOffset< bool >( 14, 2 );
        Unknown10 = parser.ReadOffset< int >( 16 );
        Unknown11 = parser.ReadOffset< byte >( 20 );
        Unknown12 = parser.ReadOffset< byte >( 21 );
        Unknown13 = parser.ReadOffset< bool >( 22 );
        Unknown14 = parser.ReadOffset< bool >( 22, 2 );
        Unknown15 = parser.ReadOffset< int >( 24 );
        Unknown16 = parser.ReadOffset< byte >( 28 );
        Unknown17 = parser.ReadOffset< byte >( 29 );
        Unknown18 = parser.ReadOffset< bool >( 30 );
        Unknown19 = parser.ReadOffset< bool >( 30, 2 );
        Unknown20 = parser.ReadOffset< int >( 32 );
        Unknown21 = parser.ReadOffset< int >( 36 );
        Unknown22 = parser.ReadOffset< byte >( 40 );
        Unknown23 = parser.ReadOffset< byte >( 41 );
        Unknown24 = parser.ReadOffset< byte >( 42 );
        Unknown25 = parser.ReadOffset< byte >( 43 );
        Unknown26 = parser.ReadOffset< byte >( 44 );
        Unknown27 = parser.ReadOffset< byte >( 45 );
        Unknown28 = parser.ReadOffset< byte >( 46 );
        Unknown29 = parser.ReadOffset< byte >( 47 );
        Unknown30 = parser.ReadOffset< byte >( 48 );
        Unknown31 = parser.ReadOffset< byte >( 49 );
        Unknown32 = parser.ReadOffset< byte >( 50 );
        Unknown33 = parser.ReadOffset< byte >( 51 );
        Unknown34 = parser.ReadOffset< bool >( 52 );
        

    }
}
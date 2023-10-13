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
    
    public int Unknown28 { get; private set; }
    public byte Unknown20 { get; private set; }
    public byte Unknown24 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown16 { get; private set; }
    public int Unknown29 { get; private set; }
    public byte Unknown21 { get; private set; }
    public byte Unknown25 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown17 { get; private set; }
    public int Unknown30 { get; private set; }
    public byte Unknown22 { get; private set; }
    public byte Unknown26 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown18 { get; private set; }
    public int Unknown31 { get; private set; }
    public byte Unknown23 { get; private set; }
    public byte Unknown27 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown19 { get; private set; }
    public int Unknown3 { get; private set; }
    public int Unknown7 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown32 { get; private set; }
    public byte Unknown33 { get; private set; }
    public byte Unknown34 { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown28 = parser.ReadOffset< int >( 0 );
        Unknown20 = parser.ReadOffset< byte >( 4 );
        Unknown24 = parser.ReadOffset< byte >( 5 );
        Unknown12 = parser.ReadOffset< bool >( 6 );
        Unknown16 = parser.ReadOffset< bool >( 6, 2 );
        Unknown29 = parser.ReadOffset< int >( 8 );
        Unknown21 = parser.ReadOffset< byte >( 12 );
        Unknown25 = parser.ReadOffset< byte >( 13 );
        Unknown13 = parser.ReadOffset< bool >( 14 );
        Unknown17 = parser.ReadOffset< bool >( 14, 2 );
        Unknown30 = parser.ReadOffset< int >( 16 );
        Unknown22 = parser.ReadOffset< byte >( 20 );
        Unknown26 = parser.ReadOffset< byte >( 21 );
        Unknown14 = parser.ReadOffset< bool >( 22 );
        Unknown18 = parser.ReadOffset< bool >( 22, 2 );
        Unknown31 = parser.ReadOffset< int >( 24 );
        Unknown23 = parser.ReadOffset< byte >( 28 );
        Unknown27 = parser.ReadOffset< byte >( 29 );
        Unknown15 = parser.ReadOffset< bool >( 30 );
        Unknown19 = parser.ReadOffset< bool >( 30, 2 );
        Unknown3 = parser.ReadOffset< int >( 32 );
        Unknown7 = parser.ReadOffset< int >( 36 );
        Unknown0 = parser.ReadOffset< byte >( 40 );
        Unknown1 = parser.ReadOffset< byte >( 41 );
        Unknown2 = parser.ReadOffset< byte >( 42 );
        Unknown5 = parser.ReadOffset< byte >( 43 );
        Unknown6 = parser.ReadOffset< byte >( 44 );
        Unknown8 = parser.ReadOffset< byte >( 45 );
        Unknown9 = parser.ReadOffset< byte >( 46 );
        Unknown10 = parser.ReadOffset< byte >( 47 );
        Unknown11 = parser.ReadOffset< byte >( 48 );
        Unknown32 = parser.ReadOffset< byte >( 49 );
        Unknown33 = parser.ReadOffset< byte >( 50 );
        Unknown34 = parser.ReadOffset< byte >( 51 );
        Unknown4 = parser.ReadOffset< bool >( 52 );
        

    }
}
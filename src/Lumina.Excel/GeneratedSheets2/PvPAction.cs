// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PvPAction", columnHash: 0x3818ca1d )]
public partial class PvPAction : ExcelRow
{
    
    public LazyRow< Action > Action { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown8 { get; private set; }
    public bool[] GrandCompany { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Action = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Unknown2 = parser.ReadOffset< ushort >( 2 );
        Unknown3 = parser.ReadOffset< ushort >( 4 );
        Unknown4 = parser.ReadOffset< ushort >( 6 );
        Unknown1 = parser.ReadOffset< byte >( 8 );
        Unknown8 = parser.ReadOffset< byte >( 9 );
        GrandCompany = new bool[3];
        for (int i = 0; i < 3; i++)
        	GrandCompany[i] = parser.ReadOffset< bool >( 10 + i * 1 );
        

    }
}
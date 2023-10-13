// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TripleTriadTournament", columnHash: 0x5cc70a8f )]
public partial class TripleTriadTournament : ExcelRow
{
    
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< byte >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 1 );
        Unknown2 = parser.ReadOffset< byte >( 2 );
        Unknown3 = parser.ReadOffset< byte >( 3 );
        

    }
}
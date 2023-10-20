// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TripleTriadRule", columnHash: 0x83e50db1 )]
public partial class TripleTriadRule : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public int Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Unknown0 = parser.ReadOffset< int >( 8 );
        Unknown1 = parser.ReadOffset< byte >( 12 );
        Unknown2 = parser.ReadOffset< byte >( 13 );
        Unknown3 = parser.ReadOffset< byte >( 14 );
        Unknown4 = parser.ReadOffset< bool >( 15 );
        

    }
}
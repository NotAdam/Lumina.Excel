// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TripleTriadCard", columnHash: 0x45c06ae0 )]
public partial class TripleTriadCard : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Unknown2 { get; private set; }
    public SeString Description { get; private set; }
    public sbyte Unknown1 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown2 = parser.ReadOffset< SeString >( 4 );
        Description = parser.ReadOffset< SeString >( 8 );
        Unknown1 = parser.ReadOffset< sbyte >( 12 );
        Unknown3 = parser.ReadOffset< sbyte >( 13 );
        StartsWithVowel = parser.ReadOffset< sbyte >( 14 );
        Unknown5 = parser.ReadOffset< sbyte >( 15 );
        Unknown6 = parser.ReadOffset< sbyte >( 16 );
        Unknown7 = parser.ReadOffset< sbyte >( 17 );
        

    }
}
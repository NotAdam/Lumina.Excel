// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GrandCompany", columnHash: 0x472d6d8c )]
public partial class GrandCompany : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Unknown0 { get; private set; }
    public SeString Unknown1 { get; private set; }
    public sbyte Unknown2 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public sbyte Unknown8 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< SeString >( 4 );
        Unknown1 = parser.ReadOffset< SeString >( 8 );
        Unknown2 = parser.ReadOffset< sbyte >( 12 );
        Unknown3 = parser.ReadOffset< sbyte >( 13 );
        Unknown4 = parser.ReadOffset< sbyte >( 14 );
        Unknown5 = parser.ReadOffset< sbyte >( 15 );
        Unknown6 = parser.ReadOffset< sbyte >( 16 );
        Unknown7 = parser.ReadOffset< sbyte >( 17 );
        Unknown8 = parser.ReadOffset< sbyte >( 20 );
        

    }
}
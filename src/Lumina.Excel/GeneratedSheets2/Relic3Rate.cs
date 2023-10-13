// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Relic3Rate", columnHash: 0xc5b95f3a )]
public partial class Relic3Rate : ExcelRow
{
    
    public sbyte Unknown0 { get; private set; }
    public sbyte Unknown1 { get; private set; }
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

        Unknown0 = parser.ReadOffset< sbyte >( 0 );
        Unknown1 = parser.ReadOffset< sbyte >( 1 );
        Unknown2 = parser.ReadOffset< sbyte >( 2 );
        Unknown3 = parser.ReadOffset< sbyte >( 3 );
        Unknown4 = parser.ReadOffset< sbyte >( 4 );
        Unknown5 = parser.ReadOffset< sbyte >( 5 );
        Unknown6 = parser.ReadOffset< sbyte >( 6 );
        Unknown7 = parser.ReadOffset< sbyte >( 7 );
        Unknown8 = parser.ReadOffset< sbyte >( 8 );
        

    }
}
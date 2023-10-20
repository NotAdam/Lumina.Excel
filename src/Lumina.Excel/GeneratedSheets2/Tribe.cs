// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Tribe", columnHash: 0xe74759fb )]
public partial class Tribe : ExcelRow
{
    
    public SeString Masculine { get; private set; }
    public SeString Feminine { get; private set; }
    public sbyte Hp { get; private set; }
    public sbyte Mp { get; private set; }
    public sbyte STR { get; private set; }
    public sbyte VIT { get; private set; }
    public sbyte DEX { get; private set; }
    public sbyte INT { get; private set; }
    public sbyte MND { get; private set; }
    public sbyte PIE { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Masculine = parser.ReadOffset< SeString >( 0 );
        Feminine = parser.ReadOffset< SeString >( 4 );
        Hp = parser.ReadOffset< sbyte >( 8 );
        Mp = parser.ReadOffset< sbyte >( 9 );
        STR = parser.ReadOffset< sbyte >( 10 );
        VIT = parser.ReadOffset< sbyte >( 11 );
        DEX = parser.ReadOffset< sbyte >( 12 );
        INT = parser.ReadOffset< sbyte >( 13 );
        MND = parser.ReadOffset< sbyte >( 14 );
        PIE = parser.ReadOffset< sbyte >( 15 );
        

    }
}
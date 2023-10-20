// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PvPSelectTrait", columnHash: 0xbddf8130 )]
public partial class PvPSelectTrait : ExcelRow
{
    
    public SeString Effect { get; private set; }
    public uint Icon { get; private set; }
    public short Value { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Effect = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        Value = parser.ReadOffset< short >( 8 );
        

    }
}
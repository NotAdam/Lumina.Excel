// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ConfigKey", columnHash: 0x927ebfb7 )]
public partial class ConfigKey : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString Label { get; private set; }
    public ushort Unknown5 { get; private set; }
    public byte Param { get; private set; }
    public byte Platform { get; private set; }
    public byte Category { get; private set; }
    public byte Unknown6 { get; private set; }
    public bool Required { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        Label = parser.ReadOffset< SeString >( 4 );
        Unknown5 = parser.ReadOffset< ushort >( 8 );
        Param = parser.ReadOffset< byte >( 10 );
        Platform = parser.ReadOffset< byte >( 11 );
        Category = parser.ReadOffset< byte >( 12 );
        Unknown6 = parser.ReadOffset< byte >( 13 );
        Required = parser.ReadOffset< bool >( 14 );
        

    }
}
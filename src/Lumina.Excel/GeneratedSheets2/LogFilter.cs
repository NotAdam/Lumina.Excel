// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "LogFilter", columnHash: 0x6ef5ba16 )]
public partial class LogFilter : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Example { get; private set; }
    public ushort Caster { get; private set; }
    public ushort Target { get; private set; }
    public byte LogKind { get; private set; }
    public byte Category { get; private set; }
    public byte DisplayOrder { get; private set; }
    public byte Preset { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Example = parser.ReadOffset< SeString >( 4 );
        Caster = parser.ReadOffset< ushort >( 8 );
        Target = parser.ReadOffset< ushort >( 10 );
        LogKind = parser.ReadOffset< byte >( 12 );
        Category = parser.ReadOffset< byte >( 13 );
        DisplayOrder = parser.ReadOffset< byte >( 14 );
        Preset = parser.ReadOffset< byte >( 15 );
        

    }
}
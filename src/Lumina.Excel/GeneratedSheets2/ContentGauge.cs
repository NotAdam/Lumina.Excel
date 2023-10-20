// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentGauge", columnHash: 0x55e3560d )]
public partial class ContentGauge : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString TextString { get; private set; }
    public short Unknown0 { get; private set; }
    public short Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public LazyRow< ContentGaugeColor > Color { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        TextString = parser.ReadOffset< SeString >( 4 );
        Unknown0 = parser.ReadOffset< short >( 8 );
        Unknown1 = parser.ReadOffset< short >( 10 );
        Unknown2 = parser.ReadOffset< short >( 12 );
        Unknown3 = parser.ReadOffset< byte >( 14 );
        Color = new LazyRow< ContentGaugeColor >( gameData, parser.ReadOffset< byte >( 15 ), language );
        Unknown4 = parser.ReadOffset< byte >( 16 );
        Unknown5 = parser.ReadOffset< byte >( 17 );
        Unknown6 = parser.ReadOffset< sbyte >( 18 );
        Unknown7 = parser.ReadOffset< sbyte >( 19 );
        Unknown8 = parser.ReadOffset< bool >( 20 );
        

    }
}
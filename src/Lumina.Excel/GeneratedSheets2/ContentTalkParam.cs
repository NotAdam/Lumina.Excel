// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentTalkParam", columnHash: 0xd4cefacf )]
public partial class ContentTalkParam : ExcelRow
{
    
    public LazyRow< ActionTimeline > TestAction { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown5 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public bool Param { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        TestAction = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        Unknown5 = parser.ReadOffset< byte >( 5 );
        Unknown3 = parser.ReadOffset< sbyte >( 6 );
        Unknown4 = parser.ReadOffset< sbyte >( 7 );
        Param = parser.ReadOffset< bool >( 8 );
        

    }
}
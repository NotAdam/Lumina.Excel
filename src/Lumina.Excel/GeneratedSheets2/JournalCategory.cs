// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "JournalCategory", columnHash: 0xd0118314 )]
public partial class JournalCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public byte SeparateType { get; private set; }
    public byte DataType { get; private set; }
    public LazyRow< JournalSection > JournalSection { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        SeparateType = parser.ReadOffset< byte >( 4 );
        DataType = parser.ReadOffset< byte >( 5 );
        JournalSection = new LazyRow< JournalSection >( gameData, parser.ReadOffset< byte >( 6 ), language );
        Unknown0 = parser.ReadOffset< byte >( 7 );
        

    }
}
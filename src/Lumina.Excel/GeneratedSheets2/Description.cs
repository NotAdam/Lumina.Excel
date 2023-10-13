// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Description", columnHash: 0x17dc52a3 )]
public partial class Description : ExcelRow
{
    
    public SeString TextLong { get; private set; }
    public SeString TextShort { get; private set; }
    public SeString TextCommentary { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< DescriptionSection > Section { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        TextLong = parser.ReadOffset< SeString >( 0 );
        TextShort = parser.ReadOffset< SeString >( 4 );
        TextCommentary = parser.ReadOffset< SeString >( 8 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 12 ), language );
        Section = new LazyRow< DescriptionSection >( gameData, parser.ReadOffset< uint >( 16 ), language );
        Unknown0 = parser.ReadOffset< byte >( 20 );
        Unknown5 = parser.ReadOffset< bool >( 21 );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SharlayanCraftWorks", columnHash: 0x92b51979 )]
public partial class SharlayanCraftWorks : ExcelRow
{
    
    public SeString Description { get; private set; }
    public LazyRow< Level > Questgiver { get; private set; }
    public ushort Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Description = parser.ReadOffset< SeString >( 0 );
        Questgiver = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        

    }
}
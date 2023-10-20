// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DescriptionSection", columnHash: 0x2020acf6 )]
public partial class DescriptionSection : ExcelRow
{
    
    public LazyRow< DescriptionString > String { get; private set; }
    public LazyRow< DescriptionPage > Page { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        String = new LazyRow< DescriptionString >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Page = new LazyRow< DescriptionPage >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GFateClimbing2TotemType", columnHash: 0xdbf43666 )]
public partial class GFateClimbing2TotemType : ExcelRow
{
    
    public LazyRow< PublicContentTextData > PublicContentTextData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        PublicContentTextData = new LazyRow< PublicContentTextData >( gameData, parser.ReadOffset< uint >( 0 ), language );
        

    }
}
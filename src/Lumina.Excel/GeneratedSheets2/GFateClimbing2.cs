// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GFateClimbing2", columnHash: 0xdbf43666 )]
public partial class GFateClimbing2 : ExcelRow
{
    
    public LazyRow< ContentEntry > ContentEntry { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ContentEntry = new LazyRow< ContentEntry >( gameData, parser.ReadOffset< uint >( 0 ), language );
        

    }
}
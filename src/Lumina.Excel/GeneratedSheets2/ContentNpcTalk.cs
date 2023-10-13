// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentNpcTalk", columnHash: 0xcfa3d5cd )]
public partial class ContentNpcTalk : ExcelRow
{
    
    public LazyRow< ContentTalk >[] ContentTalk { get; private set; }
    public int Type { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ContentTalk = new LazyRow< ContentTalk >[8];
        for (int i = 0; i < 8; i++)
        	ContentTalk[i] = new LazyRow< ContentTalk >( gameData, parser.ReadOffset< uint >( (ushort) ( 0 + i * 4 ) ), language );
        Type = parser.ReadOffset< int >( 32 );
        

    }
}
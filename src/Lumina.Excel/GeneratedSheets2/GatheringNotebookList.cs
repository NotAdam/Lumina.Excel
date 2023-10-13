// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringNotebookList", columnHash: 0x1da7bb26 )]
public partial class GatheringNotebookList : ExcelRow
{
    
    public LazyRow< GatheringItem >[] GatheringItem { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GatheringItem = new LazyRow< GatheringItem >[100];
        for (int i = 0; i < 100; i++)
        	GatheringItem[i] = new LazyRow< GatheringItem >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        Unknown0 = parser.ReadOffset< byte >( 400 );
        

    }
}
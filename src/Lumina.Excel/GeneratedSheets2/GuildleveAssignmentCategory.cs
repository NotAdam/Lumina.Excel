// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GuildleveAssignmentCategory", columnHash: 0xeb15b554 )]
public partial class GuildleveAssignmentCategory : ExcelRow
{
    
    public LazyRow< LeveAssignmentType >[] Category { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Category = new LazyRow< LeveAssignmentType >[8];
        for (int i = 0; i < 8; i++)
        	Category[i] = new LazyRow< LeveAssignmentType >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        

    }
}
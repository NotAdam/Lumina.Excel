// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanyCraftDraftCategory", columnHash: 0xf6570594 )]
public partial class CompanyCraftDraftCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< CompanyCraftType >[] CompanyCraftType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        CompanyCraftType = new LazyRow< CompanyCraftType >[10];
        for (int i = 0; i < 10; i++)
        	CompanyCraftType[i] = new LazyRow< CompanyCraftType >( gameData, parser.ReadOffset< ushort >( (ushort) ( 4 + i * 2 ) ), language );
        

    }
}
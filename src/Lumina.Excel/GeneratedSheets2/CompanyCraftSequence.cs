// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanyCraftSequence", columnHash: 0x6d444cc1 )]
public partial class CompanyCraftSequence : ExcelRow
{
    
    public uint Order { get; private set; }
    public LazyRow< Item > ResultItem { get; private set; }
    public int Category { get; private set; }
    public LazyRow< CompanyCraftDraftCategory > CompanyCraftDraftCategory { get; private set; }
    public LazyRow< CompanyCraftType > CompanyCraftType { get; private set; }
    public LazyRow< CompanyCraftDraft > CompanyCraftDraft { get; private set; }
    public LazyRow< CompanyCraftPart >[] CompanyCraftPart { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Order = parser.ReadOffset< uint >( 0 );
        ResultItem = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        Category = parser.ReadOffset< int >( 8 );
        CompanyCraftDraftCategory = new LazyRow< CompanyCraftDraftCategory >( gameData, parser.ReadOffset< int >( 12 ), language );
        CompanyCraftType = new LazyRow< CompanyCraftType >( gameData, parser.ReadOffset< int >( 16 ), language );
        CompanyCraftDraft = new LazyRow< CompanyCraftDraft >( gameData, parser.ReadOffset< int >( 20 ), language );
        CompanyCraftPart = new LazyRow< CompanyCraftPart >[8];
        for (int i = 0; i < 8; i++)
        	CompanyCraftPart[i] = new LazyRow< CompanyCraftPart >( gameData, parser.ReadOffset< ushort >( (ushort) ( 24 + i * 2 ) ), language );
        

    }
}
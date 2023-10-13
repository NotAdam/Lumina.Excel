// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanyCraftDraft", columnHash: 0xdf938294 )]
public partial class CompanyCraftDraft : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Order { get; private set; }
    public LazyRow< Item >[] RequiredItem { get; private set; }
    public LazyRow< CompanyCraftDraftCategory > CompanyCraftDraftCategory { get; private set; }
    public byte[] RequiredItemCount { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Order = parser.ReadOffset< uint >( 4 );
        RequiredItem = new LazyRow< Item >[3];
        for (int i = 0; i < 3; i++)
        	RequiredItem[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 8 + i * 4 ) ), language );
        CompanyCraftDraftCategory = new LazyRow< CompanyCraftDraftCategory >( gameData, parser.ReadOffset< byte >( 20 ), language );
        RequiredItemCount = new byte[3];
        for (int i = 0; i < 3; i++)
        	RequiredItemCount[i] = parser.ReadOffset< byte >( 21 + i * 1 );
        

    }
}
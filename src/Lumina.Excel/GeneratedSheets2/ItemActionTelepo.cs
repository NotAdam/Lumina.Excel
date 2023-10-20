// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemActionTelepo", columnHash: 0x5d58cc84 )]
public partial class ItemActionTelepo : ExcelRow
{
    
    public ILazyRow Requirement { get; private set; }
    public LazyRow< LogMessage > DenyMessage { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Requirement = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 0 ), language, "Quest", "GrandCompany" );
        DenyMessage = new LazyRow< LogMessage >( gameData, parser.ReadOffset< uint >( 4 ), language );
        

    }
}
// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CustomTalkNestHandlers", columnHash: 0xdbf43666 )]
public partial class CustomTalkNestHandlers : ExcelRow
{
    
    public ILazyRow NestHandler { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NestHandler = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 0 ), language, "GilShop", "SpecialShop", "DisposalShop", "ContentEntry" );
        

    }
}
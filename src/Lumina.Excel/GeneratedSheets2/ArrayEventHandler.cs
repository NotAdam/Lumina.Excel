// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ArrayEventHandler", columnHash: 0xb404681e )]
public partial class ArrayEventHandler : ExcelRow
{
    
    public ILazyRow[] Data { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Data = new ILazyRow[16];
        for (int i = 0; i < 16; i++)
        	Data[i] = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 0 + i * 4 ), language, "InstanceContentGuide", "Story", "Opening", "CustomTalk", "DefaultTalk", "GilShop", "Warp", "Quest" );
        

    }
}
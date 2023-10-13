// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringItemLevelConvertTable", columnHash: 0xde74b4c4 )]
public partial class GatheringItemLevelConvertTable : ExcelRow
{
    
    public byte GatheringItemLevel { get; private set; }
    public byte Stars { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GatheringItemLevel = parser.ReadOffset< byte >( 0 );
        Stars = parser.ReadOffset< byte >( 1 );
        

    }
}
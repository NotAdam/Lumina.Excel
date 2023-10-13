// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GatheringItem", columnHash: 0x0a2c014b )]
public partial class GatheringItem : ExcelRow
{
    
    public uint Unknown4 { get; private set; }
    public uint Unknown6 { get; private set; }
    public ILazyRow Item { get; private set; }
    public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public ushort Unknown8 { get; private set; }
    public byte Unknown7 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool IsHidden { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown4 = parser.ReadOffset< uint >( 0 );
        Unknown6 = parser.ReadOffset< uint >( 4 );
        Item = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 8 ), language, "Item", "EventItem" );
        GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        Unknown8 = parser.ReadOffset< ushort >( 16 );
        Unknown7 = parser.ReadOffset< byte >( 18 );
        Unknown2 = parser.ReadOffset< bool >( 19 );
        IsHidden = parser.ReadOffset< bool >( 19, 2 );
        

    }
}
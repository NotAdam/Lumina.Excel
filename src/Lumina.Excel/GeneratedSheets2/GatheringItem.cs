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
    
    public uint Unknown0 { get; private set; }
    public LazyRow< GatheringItem > SublimeVariant { get; private set; }
    public ILazyRow Item { get; private set; }
    public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; private set; }
    public ushort PerceptionReq { get; private set; }
    public ushort Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool IsHidden { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        SublimeVariant = new LazyRow< GatheringItem >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Item = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 8 ), language, "Item", "EventItem" );
        GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        PerceptionReq = parser.ReadOffset< ushort >( 14 );
        Unknown2 = parser.ReadOffset< ushort >( 16 );
        Unknown3 = parser.ReadOffset< byte >( 18 );
        Unknown4 = parser.ReadOffset< bool >( 19 );
        IsHidden = parser.ReadOffset< bool >( 19, 2 );
        

    }
}
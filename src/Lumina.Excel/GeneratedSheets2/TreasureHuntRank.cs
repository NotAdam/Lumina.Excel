// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TreasureHuntRank", columnHash: 0x3997d502 )]
public partial class TreasureHuntRank : ExcelRow
{
    
    public uint Icon { get; private set; }
    public LazyRow< Item > ItemName { get; private set; }
    public LazyRow< EventItem > KeyItemName { get; private set; }
    public LazyRow< EventItem > InstanceMap { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte MaxPartySize { get; private set; }
    public byte TreasureHuntTexture { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< uint >( 0 );
        ItemName = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 4 ), language );
        KeyItemName = new LazyRow< EventItem >( gameData, parser.ReadOffset< int >( 8 ), language );
        InstanceMap = new LazyRow< EventItem >( gameData, parser.ReadOffset< int >( 12 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 16 );
        Unknown1 = parser.ReadOffset< byte >( 18 );
        MaxPartySize = parser.ReadOffset< byte >( 19 );
        TreasureHuntTexture = parser.ReadOffset< byte >( 20 );
        Unknown2 = parser.ReadOffset< bool >( 21 );
        

    }
}
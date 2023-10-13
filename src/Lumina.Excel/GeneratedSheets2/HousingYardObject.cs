// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingYardObject", columnHash: 0xa0acf7ca )]
public partial class HousingYardObject : ExcelRow
{
    
    public uint UsageParameter { get; private set; }
    public LazyRow< CustomTalk > CustomTalk { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public ushort ModelKey { get; private set; }
    public byte HousingItemCategory { get; private set; }
    public byte UsageType { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public bool DestroyOnRemoval { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        UsageParameter = parser.ReadOffset< uint >( 0 );
        CustomTalk = new LazyRow< CustomTalk >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        ModelKey = parser.ReadOffset< ushort >( 12 );
        HousingItemCategory = parser.ReadOffset< byte >( 14 );
        UsageType = parser.ReadOffset< byte >( 15 );
        Unknown4 = parser.ReadOffset< byte >( 16 );
        Unknown10 = parser.ReadOffset< byte >( 17 );
        Unknown11 = parser.ReadOffset< byte >( 18 );
        Unknown12 = parser.ReadOffset< byte >( 19 );
        DestroyOnRemoval = parser.ReadOffset< bool >( 20 );
        Unknown8 = parser.ReadOffset< bool >( 20, 2 );
        Unknown9 = parser.ReadOffset< bool >( 20, 4 );
        Unknown13 = parser.ReadOffset< bool >( 20, 8 );
        Unknown14 = parser.ReadOffset< bool >( 20, 16 );
        

    }
}
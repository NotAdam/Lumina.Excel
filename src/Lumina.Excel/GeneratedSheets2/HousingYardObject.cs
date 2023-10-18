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
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool DestroyOnRemoval { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        UsageParameter = parser.ReadOffset< uint >( 0 );
        CustomTalk = new LazyRow< CustomTalk >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        ModelKey = parser.ReadOffset< ushort >( 12 );
        HousingItemCategory = parser.ReadOffset< byte >( 14 );
        UsageType = parser.ReadOffset< byte >( 15 );
        Unknown0 = parser.ReadOffset< byte >( 16 );
        Unknown1 = parser.ReadOffset< byte >( 17 );
        Unknown2 = parser.ReadOffset< byte >( 18 );
        Unknown3 = parser.ReadOffset< byte >( 19 );
        DestroyOnRemoval = parser.ReadOffset< bool >( 20 );
        Unknown4 = parser.ReadOffset< bool >( 20, 2 );
        Unknown5 = parser.ReadOffset< bool >( 20, 4 );
        Unknown6 = parser.ReadOffset< bool >( 20, 8 );
        Unknown7 = parser.ReadOffset< bool >( 20, 16 );
        

    }
}
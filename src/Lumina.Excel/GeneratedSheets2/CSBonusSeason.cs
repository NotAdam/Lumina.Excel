// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CSBonusSeason", columnHash: 0x05c5101f )]
public partial class CSBonusSeason : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Category0 { get; private set; }
    public ushort Category1 { get; private set; }
    public ushort Category2 { get; private set; }
    public ushort Category3 { get; private set; }
    public LazyRow< CSBonusTextData > Text0 { get; private set; }
    public LazyRow< CSBonusTextData > Text1 { get; private set; }
    public byte Unknown12 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown1 = parser.ReadOffset< ushort >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 6 );
        Category0 = parser.ReadOffset< ushort >( 8 );
        Category1 = parser.ReadOffset< ushort >( 10 );
        Category2 = parser.ReadOffset< ushort >( 12 );
        Category3 = parser.ReadOffset< ushort >( 14 );
        Text0 = new LazyRow< CSBonusTextData >( gameData, parser.ReadOffset< byte >( 16 ), language );
        Text1 = new LazyRow< CSBonusTextData >( gameData, parser.ReadOffset< byte >( 17 ), language );
        Unknown12 = parser.ReadOffset< byte >( 18 );
        Unknown3 = parser.ReadOffset< bool >( 19 );
        Unknown4 = parser.ReadOffset< bool >( 20 );
        Unknown0 = parser.ReadOffset< bool >( 21 );
        

    }
}
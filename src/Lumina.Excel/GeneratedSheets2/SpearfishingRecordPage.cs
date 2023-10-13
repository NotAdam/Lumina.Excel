// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SpearfishingRecordPage", columnHash: 0xe72da550 )]
public partial class SpearfishingRecordPage : ExcelRow
{
    
    public LazyRow< PlaceName > PlaceName { get; private set; }
    public int Image { get; private set; }
    public ushort Unknown5 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadOffset< int >( 0 ), language );
        Image = parser.ReadOffset< int >( 4 );
        Unknown5 = parser.ReadOffset< ushort >( 8 );
        Unknown0 = parser.ReadOffset< byte >( 10 );
        Unknown1 = parser.ReadOffset< byte >( 11 );
        Unknown2 = parser.ReadOffset< byte >( 12 );
        Unknown6 = parser.ReadOffset< byte >( 13 );
        

    }
}